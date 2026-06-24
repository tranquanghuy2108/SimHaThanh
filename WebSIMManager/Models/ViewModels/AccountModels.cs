using System.ComponentModel.DataAnnotations;

namespace Models.ViewModels
{
	public class LoginRequest
	{
		[Required]
		[Display(Name = "email/tài khoản")]
		public string Username { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "mật khâu")]
		public string Password { get; set; }
		public bool RememberMe { get; set; }
	}
	public class ChangePasswordRequest
	{
		public Guid? id { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập mật khẩu hiện tại.")]
		[DataType(DataType.Password)]
		public string current_user_pass { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập mật khẩu mới.")]
		[DataType(DataType.Password)]
		public string new_user_pass { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập xác nhận mật khẩu mới.")]
		[DataType(DataType.Password)]
		[Compare("new_user_pass", ErrorMessage = "Nhập lại mật khẩu không đúng")]
		public string confirm_user_pass { get; set; }
	}
	public class ForgotPassRequest
	{
		[Required(ErrorMessage = "Bạn chưa nhập email.")]
		public string Email { get; set; }
	}
	public class UserCreateRequest
	{
		public Guid? Id { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập tên đầy đủ.")]
		public string FullName { get; set; }
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Địa chỉ email không hợp lệ")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập tài khoản.")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập lại mật khẩu.")]
		[Compare("Password", ErrorMessage = "Nhập lại mật khẩu không đúng")]
		[DataType(DataType.Password)]
		public string RePassword { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
		public string PhoneNumber { get; set; }
		public string? Address { get; set; }
		public string? Avatar { get; set; }
		public string? Website { get; set; }
		public string? Remark { get; set; }
		public int? GroupId { get; set; }
		public int? AgentGroupId { get; set; }
        public int? DiscountForSimSellersId { get; set; }
        public bool? IsActive { get; set; }
		public bool? IsCollaborator { get; set; }
		public bool IsAgent { get; set; }
        public bool IsConsignmentAgent { get; set; }
        public bool? IsStaff { get; set; }
	}
	public class UserEditRequest
	{
		public Guid? Id { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập tên đầy đủ.")]
		public string FullName { get; set; }
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Địa chỉ email không hợp lệ")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập tài khoản.")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
		public string PhoneNumber { get; set; }
		public string? Address { get; set; }
		public string? Avatar { get; set; }
		public string? Website { get; set; }
		public string? Remark { get; set; }
		public int? GroupId { get; set; }
		public int? AgentGroupId { get; set; }
		public int? DiscountForSimSellersId { get; set; }
		public bool? IsActive { get; set; }
		public bool? IsCollaborator { get; set; }
		public bool IsAgent { get; set; }
        public bool IsConsignmentAgent { get; set; }
        public bool? IsStaff { get; set; }
        public double? OldDebt { get; set; }
    }
	public class UserMobileCreateRequest
	{
		[Required(ErrorMessage = "Bạn chưa nhập tên đầy đủ.")]
		public string FullName { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập số điện thoại.")]
		[RegularExpression(@"^(\d{9,12})$", ErrorMessage = "Số điện thoại không hợp lệ")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập mật khẩu.")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "Bạn chưa nhập lại mật khẩu.")]
		[Compare("Password", ErrorMessage = "Nhập lại mật khẩu không đúng")]
		[DataType(DataType.Password)]
		public string RePassword { get; set; }
		public int GroupId { get; set; }
		public bool? IsStaff { get; set; }
	}
	public class UserViewModel
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public DateTime Birthday { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }

		public string Role { get; set; }
		public string Remark { get; set; }
		public string RegionManager { get; set; }
		public bool IsActive { get; set; }
		public bool? IsStaff { get; set; }

	}
	public class UserInfoModels
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
        public string? Avatar { get; set; }
        public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Role { get; set; }
		public string Remark { get; set; }
		public string Token { get; set; }
		public bool IsStaff { get; set; }
		public bool IsAgent { get; set; }
        public bool IsConsignmentAgent { get; set; }
    }
	public class UserInfoAPIModels
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
        public string? Avatar { get; set; }
        public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Role { get; set; }
		public string Remark { get; set; }
		public string Token { get; set; }
		public bool IsStaff { get; set; }
		public bool IsAgent { get; set; }
		public int? AgentID { get; set; }
        public string? AgentName { get; set; }
        public List<DiscountModel>? Discount { get; set; }
    }

	//Role
	public class RoleGroupView
	{
		public int Id { get; set; }
		public string Stt { get; set; }
		public string GroupName { get; set; }
		public string RoleInGroup { get; set; }
		public string Description { get; set; }
	}
	public class RoleView
	{
		public Guid Id { get; set; }
		public string Stt { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
	public class RoleCreate
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
	}
	public class AppGroupCreate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Guid>? RoleIds { get; set; }
		public bool IsStaffRole { get; set; }
		public string? Description { get; set; }
	}
	//
	public class AgentViewModel
	{
		public Guid Id { get; set; }
		public string Username { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string AgentGroup { get; set; }
		public string Remark { get; set; }
		public string RegionManager { get; set; }
		public string SimNumber { get; set; }
        public bool IsConsignmentAgent { get; set; }
    }
}
