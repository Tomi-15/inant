using System;

namespace Inant.Core.Models
{
    /// <summary>
    /// Represents an application to be installed
    /// </summary>
    public class Application
    {
        /// <summary>
        /// The name of the app
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The startup version of the app
        /// </summary>
        public Version Version { get; set; }

        /// <summary>
        /// The author of the application
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The name of the company who made the app
        /// </summary>
        public string Company { get; set; }
        
        /// <summary>
        /// The help link to display
        /// </summary>
        public Uri HelpLink { get; set; }
    }
}