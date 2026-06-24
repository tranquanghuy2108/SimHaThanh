// ===========================
// CẤU HÌNH VÀ HÀM CHÍNH
// ===========================
const CART_KEY = "cart_data_v1"; // key lưu trong localStorage

// Lấy danh sách giỏ hàng
function getCart() {
  try {
    const data = localStorage.getItem(CART_KEY);
    return data ? JSON.parse(data) : [];
  } catch (e) {
    console.error("Lỗi đọc giỏ hàng:", e);
    return [];
  }
}

// Lưu giỏ hàng
function saveCart(cart) {
  localStorage.setItem(CART_KEY, JSON.stringify(cart));
  updateCartBadge();
}

// Xóa toàn bộ giỏ hàng
function clearCart() {
  localStorage.removeItem(CART_KEY);
  updateCartBadge();
}

// ===========================
// CHỨC NĂNG CƠ BẢN
// ===========================

// Thêm sản phẩm vào giỏ
function addToCart(id, name, type, price, qty, esim) {
  const cart = getCart();
  const existing = cart.find(i => i.id === id && i.type === type);
  if (existing) {
    existing.qty = qty;
  } else {
    cart.push({ id, name, type, price, qty, esim });
  }
  saveCart(cart);
  showToast(`Đã thêm "${name}" vào giỏ hàng!`);
}

// Giảm số lượng hoặc xóa sản phẩm
function removeFromCart(id) {
  let cart = getCart();
  const item = cart.find(i => i.id === id);
  if (item) {
    if (item.qty > 1) {
      item.qty -= 1;
    } else {
      cart = cart.filter(i => i.id !== id);
    }
    saveCart(cart);
    showToast(`Đã xóa 1 sản phẩm khỏi giỏ hàng!`);
  }
}

// Cập nhật hiển thị tổng số item
function updateCartBadge() {
  const badge = document.getElementById("cartCount");
  if (!badge) return;

  const cart = getCart();
  const totalQty = cart.reduce((sum, i) => sum + i.qty, 0);
  badge.textContent = totalQty;
  badge.style.display = totalQty > 0 ? "inline" : "none";
}

// Hiển thị danh sách sản phẩm trong giỏ
function renderCartList(containerId) {
  const container = document.getElementById(containerId);
  if (!container) return;

  const cart = getCart();
  if (cart.length === 0) {
    container.innerHTML = "<p>Giỏ hàng trống.</p>";
    return;
  }

  let html = `
    <table class="table table-striped" cellspacing="0" cellpadding="8" width="100%">
      <thead>
        <tr>
        <th style="width: 35%;">SIM</th>
        <th style="width: 20%;">Giá</th>
        <th style="width: 15%;">SL</th>
        <th style="width: 20%;">Tổng</th>
        <th style="width: 5%;">ESim</th>
        <th style="width: 5%;">Xóa</th>
        </tr>
      </thead>
      <tbody>
  `;

  let total = 0;
  for (const item of cart) {
    const itemTotal = item.price * item.qty;
    total += itemTotal;
    if (item.esim) total += 50000 * item.qty;
    var inputStr = `<input class="form-control" type="number" value="${item.qty}" onchange="changeQty(${item.id}, ${item.type}, this.value )"/>`;
    var quantity = item.type != 0 ? inputStr : item.qty.toString();
    html += `
      <tr>
        <td class="align-middle mt-1">
          <h4 class="mt-2 text-danger">${item.name}</h4>
          <input id="" type="hidden" value="${item.id}"/>
          <input type="hidden" value="${item.type}"/>
          <input type="hidden" value="${item.name}"/>
        </td>
        <td class="align-middle mt-1">
          ${item.price.toLocaleString()}₫
          <input type="hidden" value="${item.price}"/>
        </td>
        <td class="align-middle text-center mt-1">
          ${quantity}
        </td>
        <td class="align-middle mt-1">
          ${itemTotal.toLocaleString()}₫
        </td>
        <td class="align-middle mt-1">
          <input id="${item.id}${item.type}" type="checkbox" value="${item.esim}" onclick="OnClickESim(${item.id},${item.type})" ${item.esim == true ? 'checked' : ''}/>
        </td>
        <td class="align-middle mt-1">
          <a href="#" onclick="DeleteItem(${item.id}, ${item.type})">
            <i class="bi bi-trash"></i>
          </a>
        </td>
      </tr>
    `;
  }

  html += `
    </tbody>
    </table>
    <h3 style="text-align:right;margin-top:10px;">Tổng cộng: ${total.toLocaleString()}₫</h3>
  `;

  container.innerHTML = html;
}

// Tăng/giảm số lượng
function changeQty(id, type, qty) {
  const cart = getCart();
  const item = cart.find(i => i.id === id && i.type === type);
  if (item) {
    item.qty = qty;
    if (item.qty <= 0) {
      const index = cart.indexOf(item);
      cart.splice(index, 1);
    }
    saveCart(cart);
    renderCartList("cartContainer");
  }
}

// Xóa sản phẩm hoàn toàn
function deleteItem(id, type) {
  debugger;
  const cart = getCart().filter(i => !(i.id == id && i.type == type));
  saveCart(cart);
  renderCartList("cartContainer");
}

// Thanh toán (giả lập)
function checkoutCart() {
  alert("Thanh toán thành công! Cảm ơn bạn đã mua hàng ❤️");
  clearCart();
  renderCartList("cartContainer");
}

// ===========================
// HỖ TRỢ GIAO DIỆN
// ===========================

// Thông báo nhỏ (toast)
function showToast(msg) {
  let toast = document.getElementById("toast");
  if (!toast) {
    toast = document.createElement("div");
    toast.id = "toast";
    toast.style.position = "fixed";
    toast.style.bottom = "20px";
    toast.style.right = "20px";
    toast.style.background = "rgba(0,0,0,0.8)";
    toast.style.color = "#fff";
    toast.style.padding = "10px 20px";
    toast.style.borderRadius = "8px";
    toast.style.zIndex = "9999";
    document.body.appendChild(toast);
  }
  toast.textContent = msg;
  toast.style.opacity = "1";
  setTimeout(() => (toast.style.opacity = "0"), 2000);
}

// ===========================
// KHỞI TẠO
// ===========================
document.addEventListener("DOMContentLoaded", updateCartBadge);

// Cập nhật khi có tab khác thay đổi
window.addEventListener("storage", (e) => {
  if (e.key === CART_KEY) updateCartBadge();
});
