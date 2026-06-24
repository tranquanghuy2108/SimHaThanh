namespace Models.Config
{
    public class Settings
    {
        public required string ConnectionStr { get; set; }
        public string Key { get; set; }
        public string Issuer { get; set; }
    }
    public class MailSetting
    {
        public string MailAddress { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
    public class MailContent
    {
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
