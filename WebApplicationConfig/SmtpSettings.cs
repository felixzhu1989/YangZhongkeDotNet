﻿namespace WebApplicationConfig
{
    public record SmtpSettings
    {
        public string Server { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
