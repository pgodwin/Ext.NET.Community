/**
 * @version: 1.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2008-05-26
 * @copyright: Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

namespace Ext.Net.Utilities
{
    public class UrlUtils
    {
        public static bool IsUrl(string url)
        {
            return (!string.IsNullOrEmpty(url) && url.IndexOf("://") >= 0);
        }
    }
}
