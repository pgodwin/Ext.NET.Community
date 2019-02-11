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
 ********/using System;
using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PanelResizerDirectEvents : ComponentDirectEvents
    {
        private ComponentDirectEvent dragStart;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragstart", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DragStart
        {
            get
            {
                if (this.dragStart == null)
                {
                    this.dragStart = new ComponentDirectEvent();
                }

                return this.dragStart;
            }
        }

        private ComponentDirectEvent drag;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drag", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent Drag
        {
            get
            {
                if (this.drag == null)
                {
                    this.drag = new ComponentDirectEvent();
                }

                return this.drag;
            }
        }

        private ComponentDirectEvent dragEnd;

        /// <summary>
        /// 
        /// </summary>
        [ListenerArgument(0, "item", typeof(PanelResizer))]
        [ListenerArgument(1, "e", typeof(Object))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("dragend", typeof(DirectEventJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description("")]
        public virtual ComponentDirectEvent DragEnd
        {
            get
            {
                if (this.dragEnd == null)
                {
                    this.dragEnd = new ComponentDirectEvent();
                }

                return this.dragEnd;
            }
        }
    }
}