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
using System.Collections.Generic;
using System.Xml;

using Newtonsoft.Json;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreSubmitDataEventArgs : EventArgs
    {
        private readonly XmlNode parameters;
        private readonly string json;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreSubmitDataEventArgs() { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreSubmitDataEventArgs(string json, XmlNode parameters)
        {
            this.parameters = parameters;
            this.json = json;
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public string Json
        {
            get
            {
                return this.json;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlNode Xml
        {
            get
            {
                return JsonConvert.DeserializeXmlNode("{records:{record:" + json + "}}");
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public List<T> Object<T>()
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        private ParameterCollection p;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ParameterCollection Parameters
        {
            get
            {
                if (p != null)
                {
                    return p;
                }

                if (this.parameters == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.XmlToParams(this.parameters);

                return p;
            }
        }
    }
}