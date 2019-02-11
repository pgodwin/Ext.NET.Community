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

using System.Web.UI;
using System.ComponentModel;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class SingleItemStateCollection<T> : SingleItemCollection<T>, IStateManager where T : IStateManager
    {
        private bool isTrackingViewState;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void LoadViewState(object state)
        {
            if (state != null && this.Count > 0)
            {
                this[0].LoadViewState(state);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public object SaveViewState()
        {
            return this.Count > 0 ? this[0].SaveViewState() : null;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void TrackViewState()
        {
            this.isTrackingViewState = true;

            if (this.Count > 0)
            {
                this[0].TrackViewState();
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public bool IsTrackingViewState
        {
            get { return isTrackingViewState; }
        }
    }
}