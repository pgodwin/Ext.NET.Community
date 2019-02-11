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
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;

using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public partial class XControl
    {
        /*  ScriptBuilder
            -----------------------------------------------------------------------------------------------*/

        internal string GetClientConstructor()
        {
            return this.GetClientConstructor(false, null);
        }

        internal string GetClientConstructor(bool instanceOnly)
        {
            return this.GetClientConstructor(instanceOnly, null);
        }

        internal virtual string GetClientConstructor(bool instanceOnly, string body)
        {
            if (this is ICustomConfigSerialization)
            {
                Observable parent = this.ParentComponent;

                if (parent == null)
                {
                    parent = (Observable)ReflectionUtils.GetTypeOfParent(this, typeof(Observable));
                }

                return (this as ICustomConfigSerialization).ToScript(parent);
            }

            if (this.InstanceOf.IsNotEmpty())
            {
                string template = (instanceOnly) ? "new {1}({2})" : ((this is Component) ? "" : "this.{0}=").ConcatWith("new {1}({2});");

                return string.Format(template, this.ClientID, this.InstanceOf, body ?? this.InitialConfig);
            }

            return "";
        }

        internal string BuildInitScript()
        {
            return (this.IsLazy) ? this.clientInitScript : this.before.ConcatWith(this.clientInitScript, this.after);
        }

        string clientInitScript = "";

		/// <summary>
		/// 
		/// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Description("")]
        public virtual string ClientInitScript
        {
            get
            {
                return (!RequestManager.IsAjaxRequest) ? this.BuildInitScript() : "";
            }
        }
    }
}