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

using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ResourceManagerDesigner : ExtControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            if (this.Control is ResourceManager)
            {
                ResourceHandler.CheckConfiguration(component.Site);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string XGetDesignTimeHtml()
        {
            if (((ResourceManager)this.Control).HideInDesign)
            {
                return base.XGetDesignTimeHtml();
            }

            return base.XGetDesignTimeHtml() + base.CreatePlaceHolderDesignTimeHtml(this.Message);
        }

        private string Message
        {
            get
            {
                ResourceManager sm = (ResourceManager)this.Control;

                string url = this.GetWebResourceUrl("Ext.Net.Build.Images.logo.gif");
                string template = 
                @"<table style=""margin: 8px;"">
                    <tr>
                        <th style=""font-weight:bold;"" width=""125"">Theme</th>
                        <td width=""100"">{0}</td>
                    </tr>
                    <tr>
                        <th style=""font-weight:bold;"">Adapter</th>
                        <td>{1}</td>
                    </tr>
                    <tr>
                        <th style=""font-weight:bold;"">Script Mode</th>
                        <td>{2}</td>
                    </tr>
                    <tr>
                        <td style=""text-alight:right;"" colspan=""2""><img src=""{3}"" /></td>
                    </tr>
                </table>";

                return string.Format(template, sm.Theme.ToString(), sm.ScriptAdapter.ToString(), sm.ScriptMode.ToString(), url);
            }
        }

        private DesignerActionListCollection actionLists;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionListCollection XActionLists
        {
            get
            {
                if (actionLists == null)
                {
                    actionLists = new DesignerActionListCollection();
                    actionLists.Add(new ResourceManagerActionList(this.Component));
                }

                return actionLists;
            }
        }
    }
}