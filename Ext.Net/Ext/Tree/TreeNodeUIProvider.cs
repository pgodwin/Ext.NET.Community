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

using System.ComponentModel;
using System.Text;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class TreeNodeUIProvider : StateManagedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [Description("")]
        public virtual string Alias
        {
            get
            {
                return (string)this.ViewState["Alias"] ?? "";
            }
            set
            {
                this.ViewState["Alias"] = value;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [Meta]
        [Description("")]
        public virtual string ClassName
        {
            get
            {
                return (string)this.ViewState["ClassName"] ?? "";
            }
            set
            {
                this.ViewState["ClassName"] = value;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [Description("")]
    public partial class TreeNodeUIProviders : StateManagedCollection<TreeNodeUIProvider>
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string ToScript()
        {
            if (this.Count == 0)
            {
                return "{}";
            }

            StringBuilder sb = new StringBuilder(256);
            
            sb.Append("{");
            
            bool removeComma = false;

            foreach (TreeNodeUIProvider uiProvider in this)
            {
                sb.AppendFormat("{0}:{1},", uiProvider.Alias, uiProvider.ClassName);
                removeComma = true;
            }
            
            if (removeComma)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            
            sb.Append("}");

            return sb.ToString();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string ToString()
        {
            return this.ToScript();
        }
    }
}