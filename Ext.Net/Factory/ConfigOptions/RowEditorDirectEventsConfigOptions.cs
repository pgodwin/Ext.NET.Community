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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RowEditorDirectEvents
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("afterEdit", new ConfigOption("afterEdit", new SerializationOptions("afteredit", typeof(DirectEventJsonConverter)), null, this.AfterEdit ));
                list.Add("beforeEdit", new ConfigOption("beforeEdit", new SerializationOptions("beforeedit", typeof(DirectEventJsonConverter)), null, this.BeforeEdit ));
                list.Add("validateEdit", new ConfigOption("validateEdit", new SerializationOptions("validateedit", typeof(DirectEventJsonConverter)), null, this.ValidateEdit ));
                list.Add("preEdit", new ConfigOption("preEdit", new SerializationOptions("preedit", typeof(DirectEventJsonConverter)), null, this.PreEdit ));

                return list;
            }
        }
    }
}