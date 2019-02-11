/**
 * @version: 1.0.0
 * @author: Ext.NET, Inc. http://www.ext.net/
 * @date: 2008-05-26
 * @copyright: Copyright (c) 2010, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license: See license.txt and http://www.ext.net/license/. 
 * @website: http://www.ext.net/
 */

using System;
using System.IO;
using System.Collections;

namespace Ext.Net.Utilities
{
    public class FileUtils
    {
        public static string ReadFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                sr.Close();
                return text;
            }
        }

        public static void WriteFile(string path, string value)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(value);
            sw.Close();
        }

        public static void WriteToStart(string path, string value)
        {
            string temp = ReadFile(path);
            WriteFile(path, value.Trim() + temp.Trim());
        }

        public static void WriteToEnd(string path, string value)
        {
            string temp = ReadFile(path);
            WriteFile(path, temp.Trim() + value.Trim());
        }
    }
}
