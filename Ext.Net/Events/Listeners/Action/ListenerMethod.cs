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
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Coolite.Ext.Web
{
    public abstract class ListenerMethod : ListenerAction
    {
        public static ActionMethodArgumentAttribute GetActionMethodArgumentAttribute(PropertyInfo property)
        {
            object[] attrs = property.GetCustomAttributes(typeof(ActionMethodArgumentAttribute), true);

            if (attrs.Length == 1)
            {
                return (ActionMethodArgumentAttribute)attrs[0];
            }
            return null;
        }

        protected virtual string BuildArgs()
        {
            PropertyInfo[] result = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            SortedList<int,PropertyInfo> argsProperties = new SortedList<int, PropertyInfo>();

            foreach (PropertyInfo property in result)
            {
                ActionMethodArgumentAttribute attr = GetActionMethodArgumentAttribute(property);

                if (attr != null)
                {
                    argsProperties.Add(attr.Position, property);
                }
            }

            string[] args = new string[argsProperties.Count];
            int lastNoneUnDefined = -1;
            foreach (KeyValuePair<int, PropertyInfo> argsProperty in argsProperties)
            {
                object obj = argsProperty.Value.GetValue(this, null);
                if(obj == null)
                {
                    args[argsProperty.Key] = "undefined";
                    continue;
                }

                /// TODO: need to think about more flexiable arguments
                string value = obj.ToString();
                if(obj is bool)
                {
                    value = value.ToLower();
                }
               
                args[argsProperty.Key] = value;

                if(value != "undefined")
                {
                    lastNoneUnDefined = argsProperty.Key;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= lastNoneUnDefined; i++)
            {
                sb.Append(args[i]).Append(",");
            }

            if(sb.Length > 0 && sb[sb.Length-1] == ',')
            {
                sb.Remove(sb.Length-1, 1);
            }
            
            return sb.ToString();
        }

        public override string GetScript()
        {
            if(this.IsDefault)
            {
                return "";
            }

            this.CheckControlTypeIsAcceptable();

            return string.Concat(this.Selector, ".", this.Name, "(", this.BuildArgs(), ");");
        }
    }

    public class ActionMethodArgumentAttribute : Attribute
    {
        private readonly int position;

        public ActionMethodArgumentAttribute(int position)
        {
            this.position = position;
        }

        public int Position
        {
            get { return position; }
        }
    }
}
