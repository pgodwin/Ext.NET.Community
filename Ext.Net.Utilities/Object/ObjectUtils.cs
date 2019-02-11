/**
 * @version: 1.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2008-05-26
 * @copyright: Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

using System.Reflection;
using System;
using System.ComponentModel;

namespace Ext.Net.Utilities
{
    public static class ObjectUtils
    {
        public static bool IsNull(this object instance)
        {
            return instance == null;
        }

        public static T Apply<T>(object to, object from) where T : IComponent
        {
            return (T)ObjectUtils.Apply(to, from);
        }

        public static object Apply(object to, object from)
        {
            PropertyInfo toProperty;

            object fromValue = null;
            object defaultValue = null;

            foreach (PropertyInfo fromProperty in from.GetType().GetProperties())
            {
                if (fromProperty.CanRead)
                {
                    fromValue = fromProperty.GetValue(from, null);
                    defaultValue = ReflectionUtils.GetDefaultValue(fromProperty);

                    if (fromValue != null && !fromValue.Equals(defaultValue))
                    {
                        toProperty = to.GetType().GetProperty(fromProperty.Name, BindingFlags.Instance | BindingFlags.Public);

                        if (toProperty != null && toProperty.CanWrite && toProperty != null && toProperty.GetType().Equals(fromProperty.GetType()))
                        {
                            toProperty.SetValue(to, fromValue, null);
                        }
                    }
                }
            }

            return to;
        }
    }
}