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
using System.ComponentModel.Design;
using System.Configuration;
using System.Text;
using System.Web.UI;
using System.Web.UI.Design;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
	[Description("")]
    public partial class ExtControlDesigner : System.Web.UI.Design.ControlDesigner
    {
		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override void Initialize(IComponent component)
        {
            base.Initialize(component); 
            this.control = (XControl)component;
        }

        XControl control;
        internal XControl Control
        {
            get
            {
                return this.control;
            }
        }

        private DesignMode ReadDesignMode()
        {
            if (this.Component.Site == null)
            {
                return DesignMode.Enabled;
            }

            try
            {
                IWebApplication app = (IWebApplication)this.Component.Site.GetService(typeof(IWebApplication));

                if (app == null)
                {
                    return DesignMode.Enabled;
                }

                Configuration configFile = app.OpenWebConfiguration(true);
                GlobalConfig config = configFile.GetSection("extnet") as GlobalConfig;

                if (config != null)
                {
                    return config.DesignMode;
                }
            }
            catch (Exception)
            {
            }

            return DesignMode.Enabled;
        }

        private static DesignMode? designMode;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual DesignMode DesignMode
        {
            get
            {
                return DesignMode.Disabled;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual bool Disabled
        {
            get
            {
                DesignMode mode = this.DesignMode;
                return mode == DesignMode.Disabled || mode == DesignMode.ActionsOnly;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual bool ActionsDisabled
        {
            get
            {
                DesignMode mode = this.DesignMode;
                return mode == DesignMode.Disabled;
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        protected virtual string EmptyDesignerText
        {
            get
            {
                return base.CreatePlaceHolderDesignTimeHtml(this.Message);    
            }
        }

        private string Message
        {
            get
            {
                return @"<table style=""margin: 8px;"">
                    <tr>
                        <td style=""white-space: nowrap;padding-right:8px;"">Please configure in Source View.</td>
                    </tr>
                </table>";
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string XGetDesignTimeHtml(DesignerRegionCollection regions)
        {
            return base.GetDesignTimeHtml(regions);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual string XGetDesignTimeHtml()
        {
            return base.GetDesignTimeHtml();
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string GetDesignTimeHtml(DesignerRegionCollection regions)
        {
            if (this.Disabled)
            {
                return this.EmptyDesignerText;
            }
            return this.XGetDesignTimeHtml(regions);
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public override string GetDesignTimeHtml()
        {
            if (this.Disabled)
            {
                return this.EmptyDesignerText;
            }
            return this.XGetDesignTimeHtml();
        }

        private DesignerActionListCollection actionLists;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public virtual DesignerActionListCollection XActionLists
        {
            get
            {
                if (this.actionLists == null)
                {
                    this.actionLists = new DesignerActionListCollection();
                    this.actionLists.Add(new ExtControlActionList(this.Component));
                }

                return this.actionLists;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Description("")]
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                if (this.ActionsDisabled)
                {
                    return base.ActionLists;
                }

                return this.XActionLists;
            }
        }

        /*  Properties
            -----------------------------------------------------------------------------------------------*/

        public override bool AllowResize
        {
            get
            {
                return !this.Disabled;
            }
        }

        private ExtControlDesigner currentDesigner;

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public ExtControlDesigner CurrentDesigner
        {
            get
            {
                return currentDesigner??this;
            }
            set 
            {
                currentDesigner = value; 
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string GetWebResourceUrl(string webResourceName)
        {
            IServiceProvider serviceProvider = this.Component.Site;
            string result = "";

            if (serviceProvider != null)
            {
                IResourceUrlGenerator urlGenerator =
                    (IResourceUrlGenerator)serviceProvider.GetService(typeof(IResourceUrlGenerator));

                if (urlGenerator != null)
                {
                    result = urlGenerator.GetResourceUrl(this.Component.GetType(), webResourceName);
                }
            }

            return result;
        }

        List<Icon> icons = new List<Icon>();

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void AddIcon(Icon icon)
        {
            if (icon != Icon.None && !this.CurrentDesigner.icons.Contains(icon))
            {
                this.CurrentDesigner.icons.Add(icon);
            }
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public string GetIconStyleBlock()
        {
            try
            {
                if (this.icons.Count > 0)
                {
                    StringBuilder iconlist = new StringBuilder(128);

                    foreach (Icon icon in this.icons)
                    {
                        iconlist.Append(this.Control.ResourceManager.GetIconClass(icon));
                    }

                    return string.Format(ResourceManager.StyleBlockTemplate, iconlist.ToString());
                }
            }
            catch
            {
                // swallow Exception
            }

            return "";
        }
        
        /*  HTML
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        public virtual string HtmlBegin { get { return ""; } }

        /// <summary>
        /// 
        /// </summary>
        public virtual string HtmlEnd { get { return ""; } }

        /*  ActionList
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string WriteLog(string message)
        {
            //string path = @"c:\Ext.Net.Designer.Log.txt";
            //FileUtils.WriteFile(path, message);

            return message;
        }

		/// <summary>
		/// 
		/// </summary>
		[Description("")]
        public void Refresh()
        {
            try
            {
                IMenuCommandService menuService =
                    (IMenuCommandService)GetService(typeof(IMenuCommandService));

                if (menuService != null)
                {
                    CommandID r = new CommandID(new Guid("{5efc7975-14bc-11cf-9b2b-00aa00573819}"), 189);
                    menuService.GlobalInvoke(r);
                }
            }
            catch { }
        }



        /*  Error Handeling
            -----------------------------------------------------------------------------------------------*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected override string GetErrorDesignTimeHtml(Exception e)
        {
            return base.GetDesignTimeHtml() + string.Format(ErrorMessageTemplate, e.Message, e.StackTrace);
        }

        private static string ErrorMessageTemplate
        {
            get
            {
return @"<br /><div class=""x-tip x-form-invalid-tip"" style=""position: autstarttop: auto; left:auto; visibility: visible; z-index: auto; border:0 none;display: block;"">
  <div class=""x-tip-tl"">
    <div class=""x-tip-tr"">
      <div class=""x-tip-tc"">
        <div class=""x-tip-header x-unselectable""><span class=""x-tip-header-text""></span></div>
      </div>
    </div>
  </div>
    <div class=""x-tip-bwrap"">
        <div class=""x-tip-ml"">
            <div class=""x-tip-mr"">
                <div class=""x-tip-mc"">
                    <div style=""height: auto; width: auto;"" class=""x-tip-body"">Oops! A <b>Ext.Net</b> Desgin-Time Error has occured.<br />Error Message: {0}<br /><br />Stack Trace: <br /><pre>{1}</pre><br /></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""x-tip-bl x-panel-nofooter"">
      <div class=""x-tip-br"">
        <div class=""x-tip-bc""></div>
      </div>
    </div>
  </div>
</div>";
            }
        }


        /*  Simple DesignTime Log
            -----------------------------------------------------------------------------------------------*/

        //StringBuilder log = null;

        //private string ReadLog()
        //{
        //    if (this.control.Trace)
        //    {
        //        return this.log.ToString();
        //    }
        //    return "";
        //}

        //private void WriteLog(string name, string value)
        //{
        //    if (this.control.Trace)
        //    {
        //        string template = "<div style=\"margin: 12px;font:normal 11px tahoma, arial, helvetica, sans-serif;color:#444;\"><h4>{0}</h4><code>{1}</code></div>";
        //        this.log.Append(string.Format(template, name, HttpUtility.HtmlAttributeEncode(value)));
        //    }
        //}
    }
}