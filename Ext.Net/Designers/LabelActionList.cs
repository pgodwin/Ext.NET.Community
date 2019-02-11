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
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LabelActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LabelActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Text
        {
            get
            {
                return ((Label)this.Control).Text;
            }
            set
            {
                this.GetPropertyByName("Text").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Html
        {
            get
            {
                return ((Label)this.Control).Html;
            }
            set
            {
                this.GetPropertyByName("Html").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Cls
        {
            get
            {
                return ((Label)this.Control).Cls;
            }
            set
            {
                this.GetPropertyByName("Cls").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string StyleSpec
        {
            get
            {
                return ((Label)this.Control).StyleSpec;
            }
            set
            {
                this.GetPropertyByName("StyleSpec").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("Text", "Text", "500", "Set the text of the Label."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Html", "Html", "500", "Set the text of the Label."));
            //this.AddPropertyItem(new DesignerActionPropertyItem("Cls", "Class", "500", "Set the class of the Label."));
            //this.AddPropertyItem(new DesignerActionPropertyItem("StyleSpec", "Style", "500", "Set the style of the Label."));

            return base.GetSortedActionItems();
        }
    }
}
