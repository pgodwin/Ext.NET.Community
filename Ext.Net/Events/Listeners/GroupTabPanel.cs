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
using System.Web.UI;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class GroupTabPanelListeners : ContainerListeners
    {
        private ComponentListener beforeGroupChange;

        /// <summary>
        /// Fires before the active group changes. Handlers can return false to cancel the tab change.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "newGroup", typeof(GroupTab), "The group being activated")]
        [ListenerArgument(2, "currentGroup", typeof(GroupTab), "The current active group")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforegroupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires before the active group changes. Handlers can return false to cancel the tab change.")]
        public virtual ComponentListener BeforeGroupChange
        {
            get
            {
                if (this.beforeGroupChange == null)
                {
                    this.beforeGroupChange = new ComponentListener();
                }

                return this.beforeGroupChange;
            }
        }

        private ComponentListener groupChange;

        /// <summary>
        /// Fires after the active group has changed.
        /// </summary>
        [ListenerArgument(0, "item", typeof(GroupTabPanel), "this")]
        [ListenerArgument(1, "group", typeof(GroupTab), "The new active group")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("groupchange", typeof(ListenerJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("Fires after the active group has changed.")]
        public virtual ComponentListener GroupChange
        {
            get
            {
                if (this.groupChange == null)
                {
                    this.groupChange = new ComponentListener();
                }

                return this.groupChange;
            }
        }
    }
}