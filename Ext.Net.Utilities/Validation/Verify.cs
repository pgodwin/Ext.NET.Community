/**
 * @version: 1.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2008-05-26
 * @copyright: Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

using System;

namespace Ext.Net.Utilities
{
    public abstract class Verify
    {
        public static void IsNotNull(object parameter, string parameterName)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(parameterName, parameterName);
            }
        }

        public static void IsString(object value, string paramterName)
        {
            if (!(value is string))
            {
                throw new ArgumentException(paramterName, paramterName);
            }
        }
    }
}
