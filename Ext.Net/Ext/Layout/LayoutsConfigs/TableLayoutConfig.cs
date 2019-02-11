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
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TableLayoutConfig : LayoutConfig
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TableLayoutConfig(int columns, DomObject tableAttrs, bool renderHidden, string extraCls)
            : base(renderHidden, extraCls)
        {
            this.Columns = columns;
            this.tableAttrs = tableAttrs;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public TableLayoutConfig() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.Raw)]
        [DefaultValue(0)]
		[Description("")]
        public int Columns
        {
            get
            {
                object obj = this.ViewState["Columns"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["Columns"] = value;
            }
        }

        private DomObject tableAttrs;

        /// <summary>
        /// An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.
        /// </summary>
        [ConfigOption(JsonMode.Object)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An object containing properties which are added to the DomHelper specification used to create the layout's <table> element.")]
        public virtual DomObject TableAttrs
        {
            get
            {
                if (this.tableAttrs == null)
                {
                    this.tableAttrs = new DomObject();
                }

                return this.tableAttrs;
            }
        }
    }
}