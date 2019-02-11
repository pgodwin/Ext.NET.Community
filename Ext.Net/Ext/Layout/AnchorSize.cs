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
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class AnchorSize : ExtObject
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AnchorSize(Unit width, Unit height)
        {
            this.width = width;
            this.height = height;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AnchorSize(Unit width, Unit height, bool isFormField)
        {
            this.width = width;
            this.height = height;
            this.isFormField = isFormField;
        }

        private readonly bool isFormField;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(false)]
		[Description("")]
        public bool IsFormField
        {
            get
            {
                return this.isFormField;
            }
        }

        private readonly Unit width;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(typeof(Unit), "")]
		[Description("")]
        public Unit Width
        {
            get
            {
                return this.width;
            }
        }

        private readonly Unit height;

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption]
        [DefaultValue(typeof(Unit), "")]
		[Description("")]
        public Unit Height
        {
            get
            {
                return this.height;
            }
        }
    }
}