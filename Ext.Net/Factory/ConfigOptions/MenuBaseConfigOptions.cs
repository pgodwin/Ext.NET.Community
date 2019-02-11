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
 * @date      : 2010-10-29
 * @copyright : Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public abstract partial class MenuBase
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
                
                list.Add("defaultType", new ConfigOption("defaultType", null, "menuitem", this.DefaultType ));
                list.Add("enableScrolling", new ConfigOption("enableScrolling", null, false, this.EnableScrolling ));
                list.Add("floating", new ConfigOption("floating", null, true, this.Floating ));
                list.Add("allowOtherMenus", new ConfigOption("allowOtherMenus", null, false, this.AllowOtherMenus ));
                list.Add("offsetX", new ConfigOption("offsetX", null, 0, this.OffsetX ));
                list.Add("offsetY", new ConfigOption("offsetY", null, 0, this.OffsetY ));
                list.Add("defaultOffsets", new ConfigOption("defaultOffsets", new SerializationOptions(JsonMode.Raw), "", this.DefaultOffsets ));
                list.Add("ignoreParentClicks", new ConfigOption("ignoreParentClicks", null, false, this.IgnoreParentClicks ));
                list.Add("minWidth", new ConfigOption("minWidth", null, Unit.Pixel(120), this.MinWidth ));
                list.Add("maxHeight", new ConfigOption("maxHeight", null, Unit.Empty, this.MaxHeight ));
                list.Add("scrollIncrement", new ConfigOption("scrollIncrement", new SerializationOptions(JsonMode.Raw), 24, this.ScrollIncrement ));
                list.Add("showSeparator", new ConfigOption("showSeparator", null, true, this.ShowSeparator ));
                list.Add("shadow", new ConfigOption("shadow", new SerializationOptions(typeof(ShadowJsonConverter)), ShadowMode.Sides, this.Shadow ));
                list.Add("subMenuAlign", new ConfigOption("subMenuAlign", null, "", this.SubMenuAlign ));
                list.Add("renderToForm", new ConfigOption("renderToForm", null, false, this.RenderToForm ));
                list.Add("disableMenuNavigationProxy", new ConfigOption("disableMenuNavigationProxy", new SerializationOptions("keyNav", JsonMode.Raw), "", this.DisableMenuNavigationProxy ));

                return list;
            }
        }
    }
}