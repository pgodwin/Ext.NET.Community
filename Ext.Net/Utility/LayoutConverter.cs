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
using System.ComponentModel;
using System.Reflection;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class LayoutConverter : StringConverter
    {
        private static List<string> layoutNames;
        private static Dictionary<string, string> xtypes;

        private static List<Type> layoutTypes;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public static List<Type> LayoutTypes
        {
            get
            {
                if (layoutTypes == null)
                {
                    layoutTypes = new List<Type>();

                    foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                    {
                        if (type.IsSubclassOf(typeof(Layout)))
                        {
                            layoutTypes.Add(type);
                        }
                    }

                    if (layoutTypes.Count > 0)
                    {
                        layoutNames = layoutTypes.ConvertAll(delegate(Type input) { 
                            return input.Name.Replace("Layout", ""); 
                        });
                    }
                }

                return layoutTypes;
            }
        }

        internal static Dictionary<string, string> XTypes
        {
            get
            {
                if (xtypes == null)
                {
                    xtypes = new Dictionary<string, string>();

                    foreach (Type type in LayoutConverter.LayoutTypes)
                    {
                        xtypes.Add(type.Name.Replace("Layout", ""), type.GetProperty("LayoutType").GetValue(Activator.CreateInstance(type),null).ToString());
                    }
                }

                return xtypes;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public LayoutConverter() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if ((context == null) || (context.Container == null))
            {
                return null;
            }

            if (LayoutConverter.LayoutTypes.Count > 0)
            {
                LayoutConverter.layoutNames.Sort();

                return new TypeConverter.StandardValuesCollection(LayoutConverter.layoutNames);
            }

            return null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
    }
}