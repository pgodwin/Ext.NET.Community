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
using System.Xml;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeStoreChangedEventArgs : EventArgs
    {
        private readonly string jsonData;
        private bool cancel;
        private readonly XmlNode ajaxPostBackParams;
        private ConfirmationList confirmationList;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string jsonData, ConfirmationList confirmationList)
        {
            this.jsonData = jsonData;
            this.cancel = false;
            this.confirmationList = confirmationList;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public BeforeStoreChangedEventArgs(string jsonData, ConfirmationList confirmationList, XmlNode callbackParams)
            : this(jsonData, confirmationList)
        {
            this.ajaxPostBackParams = callbackParams;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool Cancel
        {
            get { return cancel; }
            set { cancel = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public XmlNode AjaxPostBackParams
        {
            get
            {
                return this.ajaxPostBackParams;
            }
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

                if (this.ajaxPostBackParams == null)
                {
                    return new ParameterCollection();
                }

                p = ResourceManager.XmlToParams(this.ajaxPostBackParams);

                return p;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationList ConfirmationList
        {
            get
            {
                return confirmationList;
            }
            internal set
            {
                confirmationList = value;
            }
        }

        private StoreDataHandler dataHandler;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public StoreDataHandler DataHandler
        {
            get
            {
                if (dataHandler == null)
                {
                    dataHandler = new StoreDataHandler(jsonData);
                }

                return dataHandler;
            }
        }
    }
}