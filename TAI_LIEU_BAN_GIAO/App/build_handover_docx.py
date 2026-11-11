from pathlib import Path
import re

from docx import Document
from docx.enum.section import WD_SECTION
from docx.enum.table import WD_CELL_VERTICAL_ALIGNMENT, WD_TABLE_ALIGNMENT
from docx.enum.text import WD_ALIGN_PARAGRAPH
from docx.oxml import OxmlElement
from docx.oxml.ns import qn
from docx.shared import Inches, Pt, RGBColor

ROOT = Path(__file__).resolve().parent
OUT = ROOT / "BAN_GIAO_SOURCE_CODE_SIM_HA_THANH.docx"
SOURCES = [
    ROOT / "01_TONG_QUAN_VA_KIEN_TRUC.md",
    ROOT / "02_CAI_DAT_BUILD_PHAT_HANH.md",
    ROOT / "03_CAU_HINH_TICH_HOP_VA_VAN_HANH.md",
    ROOT / "04_CHECKLIST_BAN_GIAO_VA_RUI_RO.md",
]


def set_cell_shading(cell, fill):
    tc_pr = cell._tc.get_or_add_tcPr()
    shd = tc_pr.find(qn("w:shd"))
    if shd is None:
        shd = OxmlElement("w:shd")
        tc_pr.append(shd)
    shd.set(qn("w:fill"), fill)


def set_cell_margins(cell, top=100, start=120, bottom=100, end=120):
    tc = cell._tc
    tc_pr = tc.get_or_add_tcPr()
    tc_mar = tc_pr.first_child_found_in("w:tcMar")
    if tc_mar is None:
        tc_mar = OxmlElement("w:tcMar")
        tc_pr.append(tc_mar)
    for tag, value in (("top", top), ("start", start), ("bottom", bottom), ("end", end)):
        node = tc_mar.find(qn(f"w:{tag}"))
        if node is None:
            node = OxmlElement(f"w:{tag}")
            tc_mar.append(node)
        node.set(qn("w:w"), str(value))
        node.set(qn("w:type"), "dxa")


def set_repeat_table_header(row):
    tr_pr = row._tr.get_or_add_trPr()
    tbl_header = OxmlElement("w:tblHeader")
    tbl_header.set(qn("w:val"), "true")
    tr_pr.append(tbl_header)


def remove_paragraph_borders(style):
    p_pr = style._element.get_or_add_pPr()
    borders = p_pr.find(qn("w:pBdr"))
    if borders is not None:
        p_pr.remove(borders)


def set_font(run, name="Arial", size=None, bold=None, color=None):
    run.font.name = name
    run._element.get_or_add_rPr().rFonts.set(qn("w:ascii"), name)
    run._element.get_or_add_rPr().rFonts.set(qn("w:hAnsi"), name)
    if size is not None:
        run.font.size = Pt(size)
    if bold is not None:
        run.bold = bold
    if color is not None:
        run.font.color.rgb = RGBColor(*color)


def add_inline_runs(paragraph, text):
    parts = re.split(r"(`[^`]+`|\*\*[^*]+\*\*)", text)
    for part in parts:
        if not part:
            continue
        if part.startswith("`") and part.endswith("`"):
            run = paragraph.add_run(part[1:-1])
            set_font(run, "Courier New", 9.5, color=(40, 40, 40))
        elif part.startswith("**") and part.endswith("**"):
            run = paragraph.add_run(part[2:-2])
            set_font(run, "Arial", 10.5, bold=True)
        else:
            run = paragraph.add_run(part)
            set_font(run, "Arial", 10.5)


def add_markdown_table(doc, lines):
    rows = []
    for line in lines:
        cells = [cell.strip() for cell in line.strip().strip("|").split("|")]
        rows.append(cells)
    if len(rows) > 1 and all(re.fullmatch(r":?-{3,}:?", cell.replace(" ", "")) for cell in rows[1]):
        rows.pop(1)
    table = doc.add_table(rows=len(rows), cols=max(len(r) for r in rows))
    table.alignment = WD_TABLE_ALIGNMENT.CENTER
    table.style = "Table Grid"
    table.autofit = True
    for r_idx, row_data in enumerate(rows):
        row = table.rows[r_idx]
        if r_idx == 0:
            set_repeat_table_header(row)
        for c_idx, value in enumerate(row_data):
            cell = row.cells[c_idx]
            cell.vertical_alignment = WD_CELL_VERTICAL_ALIGNMENT.CENTER
            set_cell_margins(cell)
            if r_idx == 0:
                set_cell_shading(cell, "1F4E78")
            elif r_idx % 2 == 0:
                set_cell_shading(cell, "EAF2F8")
            p = cell.paragraphs[0]
            p.paragraph_format.space_after = Pt(0)
            p.paragraph_format.line_spacing = 1.05
            p.alignment = WD_ALIGN_PARAGRAPH.CENTER if c_idx == 0 and len(row_data) > 2 else WD_ALIGN_PARAGRAPH.LEFT
            p.clear()
            add_inline_runs(p, value)
            for run in p.runs:
                set_font(run, run.font.name or "Arial", 8.5, bold=(r_idx == 0), color=((255, 255, 255) if r_idx == 0 else (0, 0, 0)))
    doc.add_paragraph().paragraph_format.space_after = Pt(1)


def parse_markdown(doc, path):
    lines = path.read_text(encoding="utf-8").splitlines()
    i = 1  # Skip the H1 because the combined document supplies section titles.
    in_code = False
    code_lines = []
    while i < len(lines):
        line = lines[i]
        if line.startswith("```"):
            if in_code:
                p = doc.add_paragraph()
                p.paragraph_format.left_indent = Inches(0.25)
                p.paragraph_format.right_indent = Inches(0.15)
                p.paragraph_format.space_after = Pt(8)
                for idx, code_line in enumerate(code_lines):
                    run = p.add_run(code_line + ("\n" if idx < len(code_lines) - 1 else ""))
                    set_font(run, "Courier New", 8.5, color=(35, 35, 35))
                code_lines = []
                in_code = False
            else:
                in_code = True
            i += 1
            continue
        if in_code:
            code_lines.append(line)
            i += 1
            continue
        if line.startswith("|") and i + 1 < len(lines) and lines[i + 1].startswith("|"):
            table_lines = []
            while i < len(lines) and lines[i].startswith("|"):
                table_lines.append(lines[i])
                i += 1
            add_markdown_table(doc, table_lines)
            continue
        if line.startswith("## "):
            p = doc.add_paragraph(style="Heading 2")
            p.add_run(line[3:].strip())
        elif line.startswith("### "):
            p = doc.add_paragraph(style="Heading 3")
            p.add_run(line[4:].strip())
        elif re.match(r"^\d+\. ", line):
            p = doc.add_paragraph()
            p.paragraph_format.left_indent = Inches(0.24)
            p.paragraph_format.first_line_indent = Inches(-0.24)
            add_inline_runs(p, line)
        elif line.startswith("- [ ] "):
            p = doc.add_paragraph(style="List Bullet")
            add_inline_runs(p, "☐ " + line[6:])
        elif line.startswith("- "):
            p = doc.add_paragraph(style="List Bullet")
            add_inline_runs(p, line[2:])
        elif line.strip():
            p = doc.add_paragraph()
            add_inline_runs(p, line.strip())
        i += 1


doc = Document()
section = doc.sections[0]
section.page_width = Inches(8.5)
section.page_height = Inches(11)
section.top_margin = Inches(0.75)
section.bottom_margin = Inches(0.7)
section.left_margin = Inches(0.78)
section.right_margin = Inches(0.78)

styles = doc.styles
styles["Normal"].font.name = "Arial"
styles["Normal"]._element.rPr.rFonts.set(qn("w:ascii"), "Arial")
styles["Normal"]._element.rPr.rFonts.set(qn("w:hAnsi"), "Arial")
styles["Normal"].font.size = Pt(10.5)
styles["Normal"].paragraph_format.space_after = Pt(6)
styles["Normal"].paragraph_format.line_spacing = 1.12
remove_paragraph_borders(styles["Title"])
for style_name, size, before, after in (("Title", 26, 0, 16), ("Heading 1", 18, 14, 8), ("Heading 2", 13.5, 12, 5), ("Heading 3", 11.5, 9, 4)):
    style = styles[style_name]
    style.font.name = "Arial"
    style._element.rPr.rFonts.set(qn("w:ascii"), "Arial")
    style._element.rPr.rFonts.set(qn("w:hAnsi"), "Arial")
    style.font.size = Pt(size)
    style.font.bold = True
    style.font.color.rgb = RGBColor(0, 0, 0)
    style.paragraph_format.space_before = Pt(before)
    style.paragraph_format.space_after = Pt(after)
    style.paragraph_format.keep_with_next = True

title = doc.add_paragraph(style="Title")
title.alignment = WD_ALIGN_PARAGRAPH.LEFT
title.add_run("Tài liệu bàn giao source code Sim Hà Thành")
subtitle = doc.add_paragraph()
run = subtitle.add_run("Ứng dụng di động Expo và React Native cho Android và iOS")
set_font(run, "Arial", 14, color=(50, 50, 50))
subtitle.paragraph_format.space_after = Pt(24)

meta = doc.add_table(rows=5, cols=2)
meta.style = "Table Grid"
meta.alignment = WD_TABLE_ALIGNMENT.LEFT
metadata = [
    ("Phiên bản ứng dụng", "1.0.4"),
    ("Repository", "TG-A Sim Hà Thành MobileApp"),
    ("Mốc rà soát", "Nhánh main, commit 723a3b932d1e3a8d9386312e0e77b2f40f92b0c2 và working tree ngày 10/11/2026"),
    ("Đối tượng sử dụng", "Đội kỹ thuật, vận hành và quản trị phát hành của bên nhận"),
    ("Mức bảo mật", "Không chứa giá trị secret; credential được bàn giao qua kênh bảo mật riêng"),
]
for idx, (key, value) in enumerate(metadata):
    for cell in meta.rows[idx].cells:
        set_cell_margins(cell, 120, 140, 120, 140)
        cell.vertical_alignment = WD_CELL_VERTICAL_ALIGNMENT.CENTER
    set_cell_shading(meta.cell(idx, 0), "D9EAF7")
    p1 = meta.cell(idx, 0).paragraphs[0]
    p1.clear()
    r1 = p1.add_run(key)
    set_font(r1, "Arial", 9.5, bold=True)
    p2 = meta.cell(idx, 1).paragraphs[0]
    p2.clear()
    r2 = p2.add_run(value)
    set_font(r2, "Arial", 9.5)

doc.add_paragraph()
p = doc.add_paragraph()
r = p.add_run("Kết luận bàn giao")
set_font(r, "Arial", 12, bold=True)
p.paragraph_format.space_after = Pt(5)
p = doc.add_paragraph()
add_inline_runs(p, "Source có đủ mã ứng dụng, dự án native Android/iOS và cấu hình build để tiếp tục phát triển. Trước khi chuyển repository, bên giao cần xử lý token Sendbird nằm trong client, credential được Git theo dõi, cấu hình ký Android release và chốt một commit/tag bàn giao sạch.")

doc.add_page_break()
contents = doc.add_paragraph(style="Heading 1")
contents.add_run("Nội dung tài liệu")
for item in [
    "1  Tổng quan và kiến trúc source code",
    "2  Cài đặt build và phát hành",
    "3  Cấu hình tích hợp và vận hành",
    "4  Checklist bàn giao và rủi ro",
]:
    p = doc.add_paragraph()
    add_inline_runs(p, item)

section_titles = [
    "1 Tổng quan và kiến trúc source code",
    "2 Cài đặt build và phát hành",
    "3 Cấu hình tích hợp và vận hành",
    "4 Checklist bàn giao và rủi ro",
]
for idx, (source, section_title) in enumerate(zip(SOURCES, section_titles)):
    doc.add_page_break()
    h = doc.add_paragraph(style="Heading 1")
    h.add_run(section_title)
    parse_markdown(doc, source)

footer = doc.sections[0].footer
fp = footer.paragraphs[0]
fp.alignment = WD_ALIGN_PARAGRAPH.CENTER
fr = fp.add_run("Tài liệu bàn giao source code Sim Hà Thành  |  10/11/2026")
set_font(fr, "Arial", 8, color=(90, 90, 90))

doc.core_properties.title = "Tài liệu bàn giao source code Sim Hà Thành"
doc.core_properties.subject = "Kiến trúc, cấu hình, build, vận hành và checklist bàn giao"
doc.core_properties.author = "Đội dự án Sim Hà Thành"
doc.core_properties.keywords = "Sim Hà Thành, React Native, Expo, bàn giao source code"
doc.save(OUT)
print(OUT)
