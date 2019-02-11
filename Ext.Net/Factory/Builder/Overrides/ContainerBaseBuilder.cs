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

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class ContainerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TContainerBase"></typeparam>
        /// <typeparam name="TBuilder"></typeparam>
        new public abstract partial class Builder<TContainerBase, TBuilder> : BoxComponent.Builder<TContainerBase, TBuilder>
            where TContainerBase : ContainerBase
            where TBuilder : Builder<TContainerBase, TBuilder>
        {
            //public virtual ItemsBuilder<TContainerBase, TBuilder> Items()
            //{
            //    return new ItemsBuilder<TContainerBase, TBuilder>(this.ToControl(), this as TBuilder);
            //}

            /// <summary>
            /// Items collection
            /// </summary>
            [Description("Items collection")]
            public virtual TBuilder Items(Action<ItemsBuilder<TContainerBase, TBuilder>> action)
            {
                action(new ItemsBuilder<TContainerBase, TBuilder>(this.ToComponent(), this as TBuilder));
                return this as TBuilder;
            }
        }
    }
}