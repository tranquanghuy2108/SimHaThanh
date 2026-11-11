const objectionablePatterns = [
  /\b(?:dm|dmm|vcl|vl|cc|clgt)\b/i,
  /(?:do\s+(?:ngu|dien)|thang\s+(?:ngu|cho)|con\s+(?:dien|cho))/i,
  /(?:giet\s*(?:may|nguoi)|danh\s*chet|hiep\s*dam|khung\s*bo)/i,
];

const normalizeContent = (content) =>
  String(content ?? "")
    .normalize("NFD")
    .replace(/[\u0300-\u036f]/g, "")
    .replace(/đ/g, "d")
    .toLowerCase()
    .replace(/\s+/g, " ")
    .trim();

export const validateUserGeneratedText = (content, { required = false } = {}) => {
  const normalizedContent = normalizeContent(content);

  if (required && !normalizedContent) {
    return {
      isAllowed: false,
      message: "Vui lòng nhập nội dung trước khi gửi.",
    };
  }

  if (!normalizedContent) {
    return { isAllowed: true };
  }

  if (objectionablePatterns.some((pattern) => pattern.test(normalizedContent))) {
    return {
      isAllowed: false,
      message:
        "Nội dung có ngôn từ hoặc hành vi không phù hợp nên không thể được đăng. Vui lòng chỉnh sửa và tuân thủ Quy tắc cộng đồng.",
    };
  }

  return { isAllowed: true };
};

export const formatModerationReport = ({
  reporterUserId,
  source,
  targetUserId,
  contentId,
  content,
  channelUrl,
}) => {
  const details = [
    "[UGC REPORT]",
    `Nguồn: ${source}`,
    `Người báo cáo: ${reporterUserId ?? "không xác định"}`,
    `Người bị báo cáo: ${targetUserId ?? "không xác định"}`,
    contentId != null ? `Nội dung: ${contentId}` : null,
    channelUrl ? `Kênh chat: ${channelUrl}` : null,
    content ? `Trích đoạn: ${String(content).slice(0, 300)}` : null,
    `Thời gian: ${new Date().toISOString()}`,
  ].filter(Boolean);

  return details.join("\n");
};
