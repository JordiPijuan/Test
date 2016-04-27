﻿namespace Schibsted.Presentation.Mvc.UI.Filters
{
    using System.Security.Principal;

    /// <summary>
    /// Basic Authentication identity
    /// </summary>
    public class BasicAuthenticationIdentity : GenericIdentity
    {

        /// <summary>
        /// Get/Set for password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Get/Set for UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Basic Authentication Identity Constructor
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public BasicAuthenticationIdentity(string userName, string password)
            : base(userName, "Basic")
        {
            Password = password;
            UserName = userName;
        }

    }

}