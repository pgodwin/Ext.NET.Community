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

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class SplitButtonBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ButtonBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string arrowHandler = "";

			/// <summary>
			/// A function called when the arrow button is clicked (can be used instead of click event).
			/// </summary>
			[DefaultValue("")]
			public virtual string ArrowHandler 
			{ 
				get
				{
					return this.arrowHandler;
				}
				set
				{
					this.arrowHandler = value;
				}
			}

			private string arrowTooltip = "";

			/// <summary>
			/// The title attribute of the arrow.
			/// </summary>
			[DefaultValue("")]
			public virtual string ArrowTooltip 
			{ 
				get
				{
					return this.arrowTooltip;
				}
				set
				{
					this.arrowTooltip = value;
				}
			}

        }
    }
}