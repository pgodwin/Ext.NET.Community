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
    public partial class ImageButton
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
                
                list.Add("imageUrl", new ConfigOption("imageUrl", new SerializationOptions(JsonMode.Ignore), "", this.ImageUrl ));
                list.Add("imageUrlProxy", new ConfigOption("imageUrlProxy", new SerializationOptions("imageUrl"), "", this.ImageUrlProxy ));
                list.Add("overImageUrl", new ConfigOption("overImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.OverImageUrl ));
                list.Add("overImageUrlProxy", new ConfigOption("overImageUrlProxy", new SerializationOptions("overImageUrl"), "", this.OverImageUrlProxy ));
                list.Add("disabledImageUrl", new ConfigOption("disabledImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.DisabledImageUrl ));
                list.Add("disabledImageUrlProxy", new ConfigOption("disabledImageUrlProxy", new SerializationOptions("disabledImageUrl"), "", this.DisabledImageUrlProxy ));
                list.Add("pressedImageUrl", new ConfigOption("pressedImageUrl", new SerializationOptions(JsonMode.Ignore), "", this.PressedImageUrl ));
                list.Add("pressedImageUrlProxy", new ConfigOption("pressedImageUrlProxy", new SerializationOptions("pressedImageUrl"), "", this.PressedImageUrlProxy ));
                list.Add("alternateText", new ConfigOption("alternateText", new SerializationOptions("altText"), "", this.AlternateText ));
                list.Add("align", new ConfigOption("align", new SerializationOptions(JsonMode.ToLower), ImageAlign.NotSet, this.Align ));

                return list;
            }
        }
    }
}