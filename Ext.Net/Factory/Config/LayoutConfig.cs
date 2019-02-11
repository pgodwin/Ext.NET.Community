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
    public abstract partial class Layout
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Component.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string extraCls = "";

			/// <summary>
			/// An optional extra CSS class that will be added to the content Container (defaults to ''). This can be useful for adding customized styles to the content Container or any of its children using standard CSS rules.
			/// </summary>
			[DefaultValue("")]
			public virtual string ExtraCls 
			{ 
				get
				{
					return this.extraCls;
				}
				set
				{
					this.extraCls = value;
				}
			}

			private bool renderHidden = false;

			/// <summary>
			/// True to hide each contained items on render (defaults to false).
			/// </summary>
			[DefaultValue(false)]
			public virtual bool RenderHidden 
			{ 
				get
				{
					return this.renderHidden;
				}
				set
				{
					this.renderHidden = value;
				}
			}
        
			private ItemsCollection<Component> items = null;

			/// <summary>
			/// Items collection
			/// </summary>
			public ItemsCollection<Component> Items
			{
				get
				{
					if (this.items == null)
					{
						this.items = new ItemsCollection<Component>();
					}
			
					return this.items;
				}
			}
			
        }
    }
}