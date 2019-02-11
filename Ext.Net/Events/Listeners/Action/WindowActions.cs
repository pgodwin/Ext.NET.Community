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
using System.ComponentModel;

namespace Coolite.Ext.Web
{
    public abstract class WindowAction : ListenerMethod
    {
        protected override Type[] AllowedTypes
        {
            get
            {
                return new Type[] { typeof(Window) };
            }
        }
    }

    public class WindowClose : WindowAction
    {
        protected override string Name
        {
            get
            {
                return "close";
            }
        }
    }

    public class WindowShow : WindowAction
    {
        protected override string Name
        {
            get 
            {
                return "show";
            }
        }

        [DefaultValue("undefined")]
        [NotifyParentProperty(true)]
        [ActionMethodArgument(0)]
        public string AnimateTarget
        {
            get
            {
                return (string)this.ViewState["AnimateTarget"] ?? "undefined";
            }
            set
            {
                this.ViewState["AnimateTarget"] = value;
            }
        }

        [DefaultValue("undefined")]
        [NotifyParentProperty(true)]
        [ActionMethodArgument(1)]
        public string Callback
        {
            get
            {
                return (string)this.ViewState["Callback"] ?? "undefined";
            }
            set
            {
                this.ViewState["Callback"] = value;
            }
        }

        [DefaultValue("undefined")]
        [NotifyParentProperty(true)]
        [ActionMethodArgument(2)]
        public string Scope
        {
            get
            {
                return (string)this.ViewState["Scope"] ?? "undefined";
            }
            set
            {
                this.ViewState["Scope"] = value;
            }
        }
    }

    public class WindowHide : WindowShow
    {
        protected override string Name
        {
            get
            {
                return "hide";
            }
        }
    }

    public class WindowCollapse : WindowAction
    {
        protected override string Name
        {
            get
            {
                return "collapse";
            }
        }

        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [ActionMethodArgument(0)]
        public bool Animate
        {
            get
            {
                object o = this.ViewState["Animate"];
                return o == null ? true : (bool)o;
            }
            set
            {
                this.ViewState["Animate"] = value;
            }
        }
    }

    public class WindowExpand : WindowCollapse
    {
        protected override string Name
        {
            get
            {
                return "expand";
            }
        }
    }
}
