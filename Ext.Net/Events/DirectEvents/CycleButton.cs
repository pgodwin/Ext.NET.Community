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
    public partial class CycleButtonDirectEvents : SplitButtonDirectEvents
    {
        private ComponentDirectEvent change;

        /// <summary>
        /// Fires after the button's active menu items has changed. Note that if a changeHandler function is set on this CycleButton, it will be called instead on active items change and this change event will not be fired.
        /// </summary>
        [ListenerArgument(0, "item", typeof(CycleButton), "this")]
        [ListenerArgument(1, "item")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("change", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the button's active menu items has changed. Note that if a changeHandler function is set on this CycleButton, it will be called instead on active items change and this change event will not be fired.")]
        public virtual ComponentDirectEvent Change
        {
            get
            {
                if (this.change == null)
                {
                    this.change = new ComponentDirectEvent();
                }

                return this.change;
            }
        }
    }
}