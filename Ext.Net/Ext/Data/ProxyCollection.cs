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
using System.ComponentModel.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ProxyCollection : SingleItemStateCollection<DataProxy>
    {
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption(JsonMode.ObjectAllowEmpty)]
		[Description("")]
        public DataProxy Proxy
        {
            get
            {
                if (this.Count>0)
                {
                    return this[0];
                }

                return null;
            }
        }

        private StoreBase store;

        internal StoreBase Store
        {
            get { return store; }
            set { store = value; }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void InsertItem(int index, DataProxy item)
        {
            base.InsertItem(index, item);
            item.Store = Store;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override void SetItem(int index, DataProxy item)
        {
            base.SetItem(index, item);
            item.Store = Store;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class ProxyCollectionEditor : CollectionEditor
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ProxyCollectionEditor(Type type) : base(type) { }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override bool CanSelectMultipleInstances()
        {
            return false;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type[] CreateNewItemTypes()
        {
            return new Type[]
              {
                typeof(HttpProxy),
                typeof(ScriptTagProxy)
              };
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected override Type CreateCollectionItemType()
        {
            return typeof(HttpProxy);
        }
    }
}
