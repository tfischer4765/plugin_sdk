﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaComputer.Plugin
{
    /// <summary>
    /// Contains informations about a Plugin
    /// </summary>
    public class PluginInfo
    {
        public PluginInfo() { }

        /// <summary>
        /// Plugin Name (displayed in the aquasuite)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Plugin version string
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// A detailed german plugin description
        /// </summary>
        public string DescriptionDE { get; set; }

        /// <summary>
        /// A detailed english plugin description
        /// </summary>
        public string DescriptionEN { get; set; }

        /// <summary>
        /// when the plugin need the filename property = true
        /// </summary>
        public bool UseFilename { get; set; }

        /// <summary>
        /// when the plugin need the path property = true
        /// </summary>
        public bool UsePath { get; set; }
    }
}
