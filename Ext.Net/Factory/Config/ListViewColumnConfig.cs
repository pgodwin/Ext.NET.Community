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

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ListViewColumn
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ListViewColumn(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ListViewColumn.Config Conversion to ListViewColumn
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ListViewColumn(ListViewColumn.Config config)
        {
            return new ListViewColumn(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : StateManagedItem.Config 
        { 
			/*  Implicit ListViewColumn.Config Conversion to ListViewColumn.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ListViewColumn.Builder(ListViewColumn.Config config)
			{
				return new ListViewColumn.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private TextAlign align = TextAlign.Left;

			/// <summary>
			/// Set the CSS text-align property of the column. Defaults to 'left'.
			/// </summary>
			[DefaultValue(TextAlign.Left)]
			public virtual TextAlign Align 
			{ 
				get
				{
					return this.align;
				}
				set
				{
					this.align = value;
				}
			}

			private string cls = null;

			/// <summary>
			/// Optional. This option can be used to add a CSS class to the cell of each row for this column.
			/// </summary>
			[DefaultValue(null)]
			public virtual string Cls 
			{ 
				get
				{
					return this.cls;
				}
				set
				{
					this.cls = value;
				}
			}

			private string dataIndex = null;

			/// <summary>
			/// (optional) The name of the field in the grid's Ext.data.Store's Ext.data.Record definition from which to draw the column's value. If not specified, the column's index is used as an index into the Record's data Array.
			/// </summary>
			[DefaultValue(null)]
			public virtual string DataIndex 
			{ 
				get
				{
					return this.dataIndex;
				}
				set
				{
					this.dataIndex = value;
				}
			}

			private string header = "";

			/// <summary>
			/// The header text to display in the Grid view.
			/// </summary>
			[DefaultValue("")]
			public virtual string Header 
			{ 
				get
				{
					return this.header;
				}
				set
				{
					this.header = value;
				}
			}

			private bool sortable = false;

			/// <summary>
			/// Specify true to enable sorting on this column (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool Sortable 
			{ 
				get
				{
					return this.sortable;
				}
				set
				{
					this.sortable = value;
				}
			}

			private string template = "";

			/// <summary>
			/// Specify a string to pass as the configuration string for Ext.XTemplate. By default an Ext.XTemplate will be implicitly created using the dataIndex.
			/// </summary>
			[DefaultValue("")]
			public virtual string Template 
			{ 
				get
				{
					return this.template;
				}
				set
				{
					this.template = value;
				}
			}
        
			private XTemplate xTemplate = null;

			/// <summary>
			/// An XTemplate to use to process a Record's data to produce a column's rendered value.
			/// </summary>
			public XTemplate XTemplate
			{
				get
				{
					if (this.xTemplate == null)
					{
						this.xTemplate = new XTemplate();
					}
			
					return this.xTemplate;
				}
			}
			
			private double width = 0.0;

			/// <summary>
			/// Percentage of the container width this column should be allocated. Columns that have no width specified will be allocated with an equal percentage to fill 100% of the container width. To easily take advantage of the full container width, leave the width of at least one column undefined. Note that if you do not want to take up the full width of the container, the width of every column needs to be explicitly defined.
			/// </summary>
			[DefaultValue(0.0)]
			public virtual double Width 
			{ 
				get
				{
					return this.width;
				}
				set
				{
					this.width = value;
				}
			}

        }
    }
}