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
using System.Collections;
using System.Xml;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class BeforeRecordDeletedEventArgs : RecordModifiedEventArgs
    {
		IDictionary keys;
        private ConfirmationRecord confirmation;
        private bool cancel;
        private bool cancelAll;
		
        /// <summary>
        /// 
        /// </summary>
        /// <param name="record"></param>
        [Description("")]
        public BeforeRecordDeletedEventArgs(XmlNode record) : base(record) { }

        internal BeforeRecordDeletedEventArgs(XmlNode record, IDictionary keys, ConfirmationRecord confirmation)
            : base(record)
		{
			this.keys = keys;
            this.confirmation = confirmation;
		}
		
        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary Keys
        {
			get { return keys; }
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
        public bool CancelAll
        {
            get { return cancelAll; }
            set { cancelAll = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationRecord Confirmation
        {
            get { return confirmation; }
        }
    }
}