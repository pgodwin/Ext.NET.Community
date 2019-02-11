/**
 * @version: 1.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2008-05-26
 * @copyright: Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

using System;
using System.Collections.Generic;

namespace Ext.Net.Utilities
{
    public static class EnumerableUtils
    {
        public static IEnumerable<T> Each<T>(this IEnumerable<T> instance, Action<T> action)
        {
            foreach (T item in instance)
            {
                action(item);
            }

            return instance;
        }

        public static int Each<T>(this int instance, Action<int> action)
        {
            for (int i = 0; i < instance; i++)
            {
                action(i);
            } 

            return instance;
        }
    }
}