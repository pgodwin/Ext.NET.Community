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

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// 
        /// </summary>
        public partial class Builder : BoxComponentBase.Builder<Image, Image.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new Image()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Image component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(Image.Config config) : base(new Image(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(Image component)
            {
                return component.ToBuilder();
            }
            
            
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			 
 			/// <summary>
			/// The height of this component in pixels (defaults to auto).
			/// </summary>
            public virtual Image.Builder Height(Unit height)
            {
                this.ToComponent().Height = height;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// The width of this component in pixels (defaults to auto).
			/// </summary>
            public virtual Image.Builder Width(Unit width)
            {
                this.ToComponent().Width = width;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Image.Builder ImageUrl(string imageUrl)
            {
                this.ToComponent().ImageUrl = imageUrl;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Image.Builder AlternateText(string alternateText)
            {
                this.ToComponent().AlternateText = alternateText;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// 
			/// </summary>
            public virtual Image.Builder Align(ImageAlign align)
            {
                this.ToComponent().Align = align;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// true to load image after rendering only
			/// </summary>
            public virtual Image.Builder LazyLoad(bool lazyLoad)
            {
                this.ToComponent().LazyLoad = lazyLoad;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// true to monitor complete state and fire Complete event
			/// </summary>
            public virtual Image.Builder MonitorComplete(bool monitorComplete)
            {
                this.ToComponent().MonitorComplete = monitorComplete;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// true to allow scroll the image by mouse dragging
			/// </summary>
            public virtual Image.Builder AllowPan(bool allowPan)
            {
                this.ToComponent().AllowPan = allowPan;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// true to allow resize the image
			/// </summary>
            public virtual Image.Builder Resizable(bool resizable)
            {
                this.ToComponent().Resizable = resizable;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// The milliseconds to poll complete state, ignored if MonitorComplete is not true (defaults to 200)
			/// </summary>
            public virtual Image.Builder MonitorPoll(int monitorPoll)
            {
                this.ToComponent().MonitorPoll = monitorPoll;
                return this as Image.Builder;
            }
             
 			// /// <summary>
			// /// Resize object config
			// /// </summary>
            // public virtual TBuilder ResizeConfig(Resizable resizeConfig)
            // {
            //    this.ToComponent().ResizeConfig = resizeConfig;
            //    return this as TBuilder;
            // }
             
 			/// <summary>
			/// X offset
			/// </summary>
            public virtual Image.Builder XDelta(int xDelta)
            {
                this.ToComponent().XDelta = xDelta;
                return this as Image.Builder;
            }
             
 			/// <summary>
			/// Y offset
			/// </summary>
            public virtual Image.Builder YDelta(int yDelta)
            {
                this.ToComponent().YDelta = yDelta;
                return this as Image.Builder;
            }
             
 			// /// <summary>
			// /// Client-side JavaScript Event Handlers
			// /// </summary>
            // public virtual TBuilder Listeners(ImageListeners listeners)
            // {
            //    this.ToComponent().Listeners = listeners;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// Server-side Ajax Event Handlers
			// /// </summary>
            // public virtual TBuilder DirectEvents(ImageDirectEvents directEvents)
            // {
            //    this.ToComponent().DirectEvents = directEvents;
            //    return this as TBuilder;
            // }
             
 			// /// <summary>
			// /// 
			// /// </summary>
            // public virtual TBuilder LoadMask(LoadMask loadMask)
            // {
            //    this.ToComponent().LoadMask = loadMask;
            //    return this as TBuilder;
            // }
            

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.Image(this);
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image()
        {
            return this.Image(new Image());
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image(Image component)
        {
            return new Image.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public Image.Builder Image(Image.Config config)
        {
            return new Image.Builder(new Image(config));
        }
    }
}