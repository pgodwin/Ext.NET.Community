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

using Ext.Net.Utilities;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    [Meta]
    [Description("")]
    public partial class DateColumn : Column
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public DateColumn() { }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("xtype")]
        [DefaultValue("")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "datecolumn";
            }
        }

        /// <summary>
        /// A formatting string as used by Date.format to format a Date for this Column.
        /// </summary>
        [Meta]
        [Category("3. DateColumn")]
        [DefaultValue("")]
        [Description("A formatting string as used by Date.format to format a Date for this Column.")]
        public virtual string Format
        {
            get
            {
                return (string)this.ViewState["Format"] ?? "";
            }
            set
            {
                this.ViewState["Format"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("format")]
        [DefaultValue("")]
		[Description("")]
        protected virtual string FormatProxy
        {
            get
            {
                return this.Format.IsEmpty() ? "" : DateTimeUtils.ConvertNetToPHP(this.Format);
            }
        }
    }
}