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
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
    /// <summary>
    /// Basic image field.
    /// </summary>
    [Meta]
    [ToolboxData("<{0}:Image runat=\"server\" />")]
    [ToolboxBitmap(typeof(Image), "Build.ToolboxIcons.Image.bmp")]
    [Designer(typeof(EmptyDesigner))]
    [Description("Basic image field.")]
    public partial class Image : BoxComponentBase
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public Image() { }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string XType
        {
            get
            {
                return "netimage";
            }
        }

        /// <summary>
		/// 
		/// </summary>
		[Category("0. About")]
		[Description("")]
        public override string InstanceOf
        {
            get
            {
                return "Ext.net.Image";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string ContainerStyle
        {
            get
            {
                return Const.DisplayInline;
            }
        }

        /// <summary>
        /// The height of this component in pixels (defaults to auto).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetHeight")]
        [Category("4. BoxComponent")]
        [DefaultValue(typeof(Unit), "")]
        [NotifyParentProperty(true)]
        [Description("The height of this component in pixels (defaults to auto).")]
        public override Unit Height
        {
            get
            {
                object obj = this.ViewState["Height"];
                return obj == null ? Unit.Empty : (Unit)this.ViewState["Height"];
            }
            set
            {
                this.ViewState["Height"] = value;
            }
        }

        /// <summary>
        /// The width of this component in pixels (defaults to auto).
        /// </summary>
        [Meta]
        [ConfigOption]
        [DirectEventUpdate(MethodName = "SetWidth")]
        [Category("4. BoxComponent")]
        [DefaultValue(typeof(Unit), "")]
        [NotifyParentProperty(true)]
        [Description("The width of this component in pixels (defaults to auto).")]
        public override Unit Width
        {
            get
            {
                object obj = this.ViewState["Width"];
                return obj == null ? Unit.Empty : (Unit)this.ViewState["Width"];
            }
            set
            {
                this.ViewState["Width"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.Ignore)]
        [Category("5. Image")]
        [DefaultValue("")]
        [DirectEventUpdate(MethodName = "SetImageUrl")]
        public virtual string ImageUrl
        {
            get
            {
                return (string)this.ViewState["ImageUrl"] ?? "";
            }
            set
            {
                this.ViewState["ImageUrl"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ConfigOption("imageUrl")]
        [DefaultValue("")]
        protected virtual string ImageUrlProxy
        {
            get
            {
                return this.ResolveUrlLink(this.ImageUrl);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("altText")]
        [Category("5. Image")]
        [DefaultValue("")]
        [DirectEventUpdate(MethodName = "SetAltText")]
        public virtual string AlternateText
        {
            get
            {
                return (string)this.ViewState["AlternateText"] ?? "";
            }
            set
            {
                this.ViewState["AlternateText"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption(JsonMode.ToLower)]
        [Category("5. Image")]
        [DefaultValue(ImageAlign.NotSet)]
        [DirectEventUpdate(MethodName = "SetAlign")]
        public ImageAlign Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return (obj == null) ? ImageAlign.NotSet : (ImageAlign)obj;
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }

        /// <summary>
        /// true to load image after rendering only
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("true to load image after rendering only")]
        public virtual bool LazyLoad
        {
            get
            {
                object obj = this.ViewState["LazyLoad"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["LazyLoad"] = value;
            }
        }

        /// <summary>
        /// true to monitor complete state and fire Complete event
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("true to monitor complete state and fire Complete event")]
        public virtual bool MonitorComplete
        {
            get
            {
                object obj = this.ViewState["MonitorComplete"];
                return (obj == null) ? true : (bool)obj;
            }
            set
            {
                this.ViewState["MonitorComplete"] = value;
            }
        }

        /// <summary>
        /// true to allow scroll the image by mouse dragging
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("true to allow scroll the image by mouse dragging")]
        public virtual bool AllowPan
        {
            get
            {
                object obj = this.ViewState["AllowPan"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["AllowPan"] = value;
            }
        }

        /// <summary>
        /// true to allow resize the image
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("true to allow resize the image")]
        public virtual bool Resizable
        {
            get
            {
                object obj = this.ViewState["Resizable"];
                return (obj == null) ? false : (bool)obj;
            }
            set
            {
                this.ViewState["Resizable"] = value;
            }
        }

        /// <summary>
        /// The milliseconds to poll complete state, ignored if MonitorComplete is not true (defaults to 200)
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(200)]
        [NotifyParentProperty(true)]
        [Description("The milliseconds to poll complete state, ignored if MonitorComplete is not true (defaults to 200)")]
        public virtual int MonitorPoll
        {
            get
            {
                object obj = this.ViewState["MonitorPoll"];
                return (obj == null) ? 200 : (int)obj;
            }
            set
            {
                this.ViewState["MonitorPoll"] = value;
            }
        }

        private Resizable resizeConfig;

        /// <summary>
        /// Resize object config
        /// </summary>
        [Meta]
        [Category("5. Image")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Resize object config")]
        public Resizable ResizeConfig
        {
            get
            {
                if (this.resizeConfig == null)
                {
                    this.resizeConfig = new Resizable();
                    this.resizeConfig.Visible = false;
                    this.resizeConfig.EnableViewState = false;
                }

                return this.resizeConfig;
            }
        }

		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("resizeConfig", JsonMode.Raw)]
        [DefaultValue("")]
		[Description("")]
        protected virtual string ResizeConfigProxy
        {
            get
            {
                string cfg = this.ResizeConfig.InitialConfig;

                if (cfg == "{}")
                {
                    return "";
                }

                return cfg;
            }
        }

        /// <summary>
        /// X offset
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [DirectEventUpdate(MethodName = "SetXDelta")]
        [Description("X offset")]
        public virtual int XDelta
        {
            get
            {
                object obj = this.ViewState["XDelta"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["XDelta"] = value;
            }
        }

        /// <summary>
        /// Y offset
        /// </summary>
        [Meta]
        [ConfigOption]
        [Category("5. Image")]
        [DefaultValue(0)]
        [NotifyParentProperty(true)]
        [DirectEventUpdate(MethodName = "SetYDelta")]
        [Description("Y offset")]
        public virtual int YDelta
        {
            get
            {
                object obj = this.ViewState["YDelta"];
                return (obj == null) ? 0 : (int)obj;
            }
            set
            {
                this.ViewState["YDelta"] = value;
            }
        }

        private ImageListeners listeners;

        /// <summary>
        /// Client-side JavaScript Event Handlers
        /// </summary>
        [Meta]
        [ConfigOption("listeners", JsonMode.Object)]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Client-side JavaScript Event Handlers")]
        public ImageListeners Listeners
        {
            get
            {
                if (this.listeners == null)
                {
                    this.listeners = new ImageListeners();
                }

                return this.listeners;
            }
        }

        private ImageDirectEvents directEvents;

        /// <summary>
        /// Server-side Ajax Event Handlers
        /// </summary>
        [Meta]
        [Category("2. Observable")]
        [NotifyParentProperty(true)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [ConfigOption("directEvents", JsonMode.Object)]
        [Description("Server-side Ajax Event Handlers")]
        public ImageDirectEvents DirectEvents
        {
            get
            {
                if (this.directEvents == null)
                {
                    this.directEvents = new ImageDirectEvents();
                }

                return this.directEvents;
            }
        }

        private LoadMask loadMask;

        /// <summary>
        /// 
        /// </summary>
        [Meta]
        [ConfigOption("loadMask", typeof(LoadMaskJsonConverter))]
        [Category("5. Image")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("")]
        public virtual LoadMask LoadMask
        {
            get
            {
                if (this.loadMask == null)
                {
                    this.loadMask = new LoadMask();
                    this.loadMask.TrackViewState();
                }

                return this.loadMask;
            }
        }


        /*  Public Methods
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        protected virtual void SetImageUrl(string url)
        {
            this.Call("setImageUrl", this.ResolveUrlLink(url));
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual void SetAltText(string altText)
        {
            this.Call("setAltText", altText);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual void SetAlign(ImageAlign align)
        {
            this.Call("setAlign", align.ToString().ToLower());
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void Scroll(int xDelta, int yDelta)
        {
            this.Call("scroll", xDelta, yDelta);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual void ScrollTo(int x, int y)
        {
            this.Call("scrollTo", x, y);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual void SetXDelta(int delta)
        {
            this.Call("scroll", delta);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual void SetYDelta(int delta)
        {
            this.Call("scroll", new JRawValue("undefined"), delta);
        }
    }
}