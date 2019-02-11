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
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using Newtonsoft.Json;
using Ext.Net.Utilities;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class StoreDataHandler
    {
        private string jsonData;
        private XmlDocument xmlData;
        private readonly HttpContext context;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler(HttpContext context)
        {
            this.context = context;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler(string jsonData)
        {
            if (jsonData == null)
            {
                throw new ArgumentNullException("jsonData");
            }
            this.jsonData = jsonData;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string JsonData
        {
            get
            {
                if (jsonData == null)
                {
                    jsonData = context.Request["data"];
                }

                return jsonData;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlDocument XmlData
        {
            get
            {
                if (xmlData == null)
                {
                    RecordsToXmlConverter converter = new RecordsToXmlConverter();
                    
                    xmlData = (XmlDocument)JsonConvert.DeserializeObject(JsonData, typeof(XmlDocument), converter);
                }

                return xmlData;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ChangeRecords<T> ObjectData<T>()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.MissingMemberHandling = MissingMemberHandling.Ignore;
            StringReader sr = new StringReader(JsonData);
            ChangeRecords<T> data = (ChangeRecords<T>)serializer.Deserialize(sr, typeof(ChangeRecords<T>));

            return data;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationList BuildConfirmationList(string idColumnName)
        {
            if (idColumnName.IsEmpty())
            {
                return null;
            }

            ConfirmationList confirmationList = new ConfirmationList();

            XmlNodeList records = this.XmlData.SelectNodes("records/*/record");

            foreach (XmlNode node in records)
            {
                XmlNode keyNode = node.SelectSingleNode(idColumnName);

                if (keyNode.InnerText.IsEmpty())
                {
                    throw new InvalidOperationException("No id in submitted record");
                }

                confirmationList.Add(keyNode.InnerText, new ConfirmationRecord(false, keyNode.InnerText));
            }

            return confirmationList;
        }
    }
}
