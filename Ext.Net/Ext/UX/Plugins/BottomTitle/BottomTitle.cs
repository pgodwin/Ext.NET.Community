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
 * @version   : 1.2.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2011-09-12
 * @copyright : Copyright (c) 2006-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [ToolboxBitmap(typeof(BottomTitle), "Build.ToolboxIcons.Plugin.bmp")]
    [ToolboxData("<{0}:BottomTitle runat=\"server\" />")]
    [Description("")]
    public partial class BottomTitle : Plugin
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public BottomTitle() { }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 2;

                string theme = "";

                if (this.ResourceManager.Theme != Theme.Default)
                {
                    theme = "-" + this.ResourceManager.Theme.ToString().ToLowerInvariant();
                }

                baseList.Add(new ClientStyleItem(typeof(BottomTitle), "Ext.Net.Build.Ext.Net.ux.plugins.bottomtitle.css.bottomtitle"+theme+"-embedded.css", "/ux/plugins/bottomtitle/css/bottomtitle"+theme+".css"));
                baseList.Add(new ClientScriptItem(typeof(BottomTitle), "Ext.Net.Build.Ext.Net.ux.plugins.bottomtitle.bottomtitle.js", "/ux/plugins/bottomtitle/bottomtitle.js"));

                return baseList;
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.BottomTitle";
            }
        }
    }
}