/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 1.0.0 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2011-05-31
 * @copyright : Copyright (c) 2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommandMenu
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("items", new ConfigOption("items", new SerializationOptions("items", JsonMode.AlwaysArray), null, this.Items ));
                list.Add("shared", new ConfigOption("shared", null, false, this.Shared ));
                list.Add("enableScrolling", new ConfigOption("enableScrolling", null, true, this.EnableScrolling ));
                list.Add("minWidth", new ConfigOption("minWidth", new SerializationOptions(JsonMode.Raw), 120, this.MinWidth ));
                list.Add("maxHeight", new ConfigOption("maxHeight", new SerializationOptions(JsonMode.Raw), 0, this.MaxHeight ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", new SerializationOptions(JsonMode.Raw), 24, this.ScrollIncrement ));
                list.Add("showSeparator", new ConfigOption("showSeparator", null, true, this.ShowSeparator ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.Sides, this.Shadow ));
                list.Add("ignoreParentClicks", new ConfigOption("ignoreParentClicks", null, false, this.IgnoreParentClicks ));

                return list;
            }
        }
    }
}