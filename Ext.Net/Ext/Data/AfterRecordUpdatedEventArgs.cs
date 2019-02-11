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
 * @version   : 1.2.0 - Ext.NET Pro License
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2011-09-12
 * @copyright : Copyright (c) 2006-2011, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
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
    public partial class AfterRecordUpdatedEventArgs : RecordModifiedEventArgs
    {
        private int rowsAffected;
        private Exception e;
        private bool exceptionHandled;
        IDictionary keys;
        IDictionary newValues;
		IDictionary oldValues;
        private ConfirmationRecord confirmation;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordUpdatedEventArgs (XmlNode record) : base(record) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public AfterRecordUpdatedEventArgs(XmlNode record, int rowsAffected, Exception e, IDictionary keys, IDictionary newValues, IDictionary oldValues, ConfirmationRecord confirmation)
            : base(record)
        {
            this.rowsAffected = rowsAffected;
            this.e = e;
            this.keys = keys;
            this.newValues = newValues;
            this.oldValues = oldValues;
            this.confirmation = confirmation;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public int AffectedRows
        {
            get { return rowsAffected; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Exception Exception
        {
            get { return e; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool ExceptionHandled
        {
            get { return exceptionHandled; }
            set { exceptionHandled = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public IDictionary Keys {
			get { return keys; }
		}

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary NewValues
        {
			get { return newValues; }
		}

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public IDictionary OldValues
        {
			get { return oldValues; }
		}

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ConfirmationRecord Confirmation
        {
            get
            {
                return confirmation;
            }
        }
    }
}