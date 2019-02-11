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

using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI.WebControls;

using Ext.Net.Utilities;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class PanelActionList : ExtControlActionList
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public PanelActionList(IComponent component) : base(component) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Collapsed
        {
            get
            {
                return ((Panel)this.Control).Collapsed;
            }
            set
            {
                this.GetPropertyByName("Collapsed").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Collapsible
        {
            get
            {
                return ((Panel)this.Control).Collapsible;
            }
            set
            {
                this.GetPropertyByName("Collapsible").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Border
        {
            get
            {
                return ((Panel)this.Control).Border;
            }
            set
            {
                this.GetPropertyByName("Border").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Frame
        {
            get
            {
                return ((Panel)this.Control).Frame;
            }
            set
            {
                this.GetPropertyByName("Frame").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string Title
        {
            get
            {
                return ((Panel)this.Control).Title;
            }
            set
            {
                this.GetPropertyByName("Title").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Unit Height
        {
            get
            {
                return ((Panel)this.Control).Height;
            }
            set
            {
                this.GetPropertyByName("Height").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Unit Width
        {
            get
            {
                return ((Panel)this.Control).Width;
            }
            set
            {
                this.GetPropertyByName("Width").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string BodyStyle
        {
            get
            {
                return ((PanelBase)this.Control).BodyStyle;
            }
            set
            {
                this.GetPropertyByName("BodyStyle").SetValue(this.Control, value);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Icon Icon
        {
            get
            {
                return ((PanelBase)this.Control).Icon;
            }
            set
            {
                this.GetPropertyByName("Icon").SetValue(this.Control, value);
            }
        }

        private string padding = "padding: 6px;";
        private bool paddingAdded = false;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddPadding()
        {
            string style = ((PanelBase)this.Control).BodyStyle;

            if (!this.paddingAdded || style.IsEmpty())
            {
                this.paddingAdded = true;
                this.GetPropertyByName("BodyStyle").SetValue(this.Control, style + padding);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void RemovePadding()
        {
            string style = ((PanelBase)this.Control).BodyStyle;

            if (this.paddingAdded || style.Contains(padding))
            {
                this.paddingAdded = false;
                this.GetPropertyByName("BodyStyle").SetValue(this.Control, style.Replace(padding, ""));
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override DesignerActionItemCollection GetSortedActionItems()
        {
            this.AddPropertyItem(new DesignerActionPropertyItem("Border", "Border", "500", "Adds/Removes Border from Panel."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Collapsible", "Collapsible", "500", "Enable the Panel to be collapsible."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Collapsed", "Collapsed on Page Load", "500", "Set the Panel to be collapsed when the Page first loads."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Frame", "Frame", "500", "Render with custom rounded borders."));
            this.AddPropertyItem(new DesignerActionPropertyItem("Title", "Title", "500", "Change the Title of the Panel"));
            this.AddPropertyItem(new DesignerActionPropertyItem("Width", "Width", "500", "Change the Width of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("Height", "Height", "500", "Change the Height of the control"));
            this.AddPropertyItem(new DesignerActionPropertyItem("Icon", "Icon", "500", "Set an icon to use in the Title bar"));
            this.AddPropertyItem(new DesignerActionPropertyItem("BodyStyle", "BodyStyle", "500", "Custom CSS styles to be applied to the body element"));

            DesignerActionMethodItem add = new DesignerActionMethodItem(this, "AddPadding", "Add Body Padding", "500", "Add 6px of padding to the Body");
            DesignerActionMethodItem remove = new DesignerActionMethodItem(this, "RemovePadding", "Remove Body Padding", "500", "Remove the 6px of padding from the Body");

            if (!this.paddingAdded && !((PanelBase)this.Control).BodyStyle.Contains(this.padding))
            {
                this.AddMethodItem(add);
                this.RemoveMethodItem(remove);
            }
            else
            {
                this.AddMethodItem(remove);
                this.RemoveMethodItem(add);
            }
           
            return base.GetSortedActionItems();
        }
    }
}