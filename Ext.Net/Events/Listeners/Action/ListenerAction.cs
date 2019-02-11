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
using System.Web.UI;
using Coolite.Utilities;

namespace Coolite.Ext.Web
{
    public abstract class ListenerAction : StateManagedItem
    {
        [IDReferenceProperty(typeof(WebControl))]
        [DefaultValue("")]
        [NotifyParentProperty(true)]
        public string ControlID
        {
            get
            {
                object o = this.ViewState["ControlID"];
                return o == null ? "" : (string) o;
            }
            set
            {
                this.ViewState["ControlID"] = value;
            }
        }

        protected virtual Type[] AllowedTypes
        {
            get
            {
                return new Type[0];
            }
        }

        protected abstract string Name
        { 
            get;
        }

        protected virtual bool ControlIsRequired
        {
            get
            {
                return true;
            }
        }

        protected string Selector
        {
            get
            {
                return this.ControlIsRequired ? this.GetControl().ClientID : this.ControlID;
            }
        }

        public abstract string GetScript();

        protected Control GetControl()
        {
            if (this.IsDefault)
            {
                return null;
            }

            Control control = ControlUtils.FindControl(this.Owner, this.ControlID);

            if (control == null)
            {
                throw new InvalidOperationException(string.Concat("The control with ID='", this.ControlID, "' can't be find"));
            }

            return control;
        }

        protected void CheckControlTypeIsAcceptable()
        {
            Type[] allowedTypes = this.AllowedTypes;
            if (allowedTypes.Length == 0 || this.IsDefault)
            {
                return;
            }

            Control control = this.GetControl();

            foreach (Type allowedType in allowedTypes)
            {
                if(control.GetType().IsAssignableFrom(allowedType))
                {
                    return;
                }
            }

            throw new InvalidCastException(string.Concat("The control with type='", control.GetType().ToString(),"' doesn't acceptable."));
        }

        public override bool IsDefault
        {
            get
            {
                return string.IsNullOrEmpty(this.ControlID);
            }
        }
    }

    public class ListenerActionCollection : StateManagedCollection<ListenerAction>
    {
    }
}
