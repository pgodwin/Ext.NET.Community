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

using System.ComponentModel;
using System.Web.UI;

using Ext.Net.Utilities;

namespace Ext.Net
{
    [Meta]
    public partial class BooleanColumn : Column
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BooleanColumn() { }

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
                return "booleancolumn";
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("false")]
        [Description("The string returned by the renderer when the column value is falsey (but not undefined) (defaults to 'false').")]
        public virtual string FalseText
        {
            get
            {
                object obj = this.ViewState["FalseText"];
                return (obj == null) ? "false" : (string)obj;
            }
            set
            {
                this.ViewState["FalseText"] = value;
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is not falsey (defaults to 'true').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("true")]
        [Description("The string returned by the renderer when the column value is not falsey (defaults to 'true').")]
        public virtual string TrueText
        {
            get
            {
                object obj = this.ViewState["TrueText"];
                return (obj == null) ? "true" : (string)obj;
            }
            set
            {
                this.ViewState["TrueText"] = value;
            }
        }

        /// <summary>
        /// The string returned by the renderer when the column value is undefined (defaults to ' ').
        /// </summary>
        [ConfigOption]
        [Category("3. BooleanColumn")]
        [DefaultValue("&#160;")]
        [Description("The string returned by the renderer when the column value is undefined (defaults to ' ').")]
        public virtual string UndefinedText
        {
            get
            {
                object obj = this.ViewState["UndefinedText"];
                return (obj == null) ? "&#160;" : (string)obj;
            }
            set
            {
                this.ViewState["UndefinedText"] = value;
            }
        }
    }
}