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

using System.ComponentModel;

namespace Ext.Net
{
    /// <summary>
    /// A config object in the format: {field: 'fieldName', direction: 'ASC|DESC'}. The direction property is case-sensitive.
    /// </summary>
    [Meta]
    [ToolboxItem(false)]
    [DefaultProperty("Field")]
    [Description("A config object in the format: {field: 'fieldName', direction: 'ASC|DESC'}. The direction property is case-sensitive.")]
    public partial class SortInfo : StateManagedItem
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortInfo() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public SortInfo(string field, SortDirection direction)
        {
            this.Field = field;
            this.Direction = direction;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool IsDefault
        {
            get
            {
                return string.IsNullOrEmpty(this.Field);
            }
        }

        private string field = "";

        /// <summary>
        /// Internal UI Event. Fired before the view is refreshed.
        /// </summary>
        [Meta]
        [ConfigOption]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        [Description("Internal UI Event. Fired before the view is refreshed.")]
        public string Field
        {
            get
            {
                return this.field;
            }
            set
            {
                this.field = value;
            }
        }

        private SortDirection direction = SortDirection.Default;

        /// <summary>
        /// The direction to sort ("asc" or "desc")
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [DefaultValue(SortDirection.Default)]
        [NotifyParentProperty(true)]
        [Description("The direction to sort (\"asc\" or \"desc\")")]
        public SortDirection Direction
        {
            get
            {
                return this.direction;
            }
            set
            {
                this.direction = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string ToExtConfigString()
        {
            return "";
        }
    }
}
