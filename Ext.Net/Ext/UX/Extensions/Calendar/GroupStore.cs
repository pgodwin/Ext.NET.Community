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

using System.ComponentModel;
using System.Web.UI;

namespace Ext.Net
{
    /// <summary>
    /// This is an calendar store that enables the events to have different colors based on CalendarId.
    /// </summary>
    public partial class GroupStore : Store
    {
        /// <summary>
        /// 
        /// </summary>
        public override ConfigOptionsExtraction ConfigOptionsExtraction
        {
            get
            {
                return CalendarPanel.ConfigOptionsEngine;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override bool IsDefault
        {
            get
            {
                return this.Groups.Count == 0 && this.Proxy.Count == 0;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        protected override void OnBeforeClientInit(Observable sender)
        {
            base.OnBeforeClientInit(sender);

            if (this.StandardFields)
            {
                this.AddStandardFields();
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private void EnsureReader()
        {
            if (this.Reader.Count == 0)
            {
                this.Reader.Add(new JsonReader { IDProperty = "CalendarId" });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("proxy", JsonMode.Raw)]
        [DefaultValue("")]
        [Description("")]
        protected override string MemoryProxy
        {
            get
            {
                if (this.Proxy.Count == 0 && this.Groups.Count > 0)
                {
                    string template = "new Ext.data.PagingMemoryProxy({0}, false)";
                    return string.Format(template, JSON.Serialize(this.Groups));
                }

                return base.MemoryProxy;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void AddStandardFields()
        {
            this.EnsureReader();
            this.Reader[0].Fields.Add(new RecordField { Name = "CalendarId", Type = RecordFieldType.Int });
            this.Reader[0].Fields.Add(new RecordField { Name = "Title", Type = RecordFieldType.String });
            //this.Reader[0].Fields.Add(new RecordField { Name = "Color", Type = RecordFieldType.String });
            this.StandardFields = false;
        }

        private GroupCollection groups;

        /// <summary>
        /// 
        /// </summary>
        [PersistenceMode(PersistenceMode.InnerProperty)]        
        [Description("")]        
        public virtual GroupCollection Groups
        {
            get
            {
                if (this.groups == null)
                {
                    this.groups = new GroupCollection();
                }

                return this.groups;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private bool standardFields = true;
        public virtual bool StandardFields
        {
            get
            {
                return this.standardFields;
            }
            set
            {
                this.standardFields = value;
            }
        }
    }
}