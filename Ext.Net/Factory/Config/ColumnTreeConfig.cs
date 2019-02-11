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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    public partial class ColumnTree
    {
		/*  Ctor
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public ColumnTree(Config config)
        {
            this.Apply(config);
        }


		/*  Implicit ColumnTree.Config Conversion to ColumnTree
			-----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ColumnTree(ColumnTree.Config config)
        {
            return new ColumnTree(config);
        }
        
        /// <summary>
        /// 
        /// </summary>
        new public partial class Config : TreePanel.Config 
        { 
			/*  Implicit ColumnTree.Config Conversion to ColumnTree.Builder
				-----------------------------------------------------------------------------------------------*/
        
            /// <summary>
			/// 
			/// </summary>
			public static implicit operator ColumnTree.Builder(ColumnTree.Config config)
			{
				return new ColumnTree.Builder(config);
			}
			
			
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			        
			private ColumnTreeColumnCollection columns = null;

			/// <summary>
			/// An array of column configuration objects
			/// </summary>
			public ColumnTreeColumnCollection Columns
			{
				get
				{
					if (this.columns == null)
					{
						this.columns = new ColumnTreeColumnCollection();
					}
			
					return this.columns;
				}
			}
			
			private bool hideHeaders = false;

			/// <summary>
			/// True to hide the grid's header (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool HideHeaders 
			{ 
				get
				{
					return this.hideHeaders;
				}
				set
				{
					this.hideHeaders = value;
				}
			}

        }
    }
}