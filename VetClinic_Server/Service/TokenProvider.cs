﻿namespace VetClinic_Server.Service
{
    public class TokenProvider
    {
        public string XsrfToken { get; set; }
    }

    public class InitialApplicationState
    {
        public string XsrfToken { get; set; }
    }
}
