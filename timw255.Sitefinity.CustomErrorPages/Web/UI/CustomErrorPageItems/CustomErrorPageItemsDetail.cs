using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.Fields;

namespace timw255.Sitefinity.CustomErrorPages.Web.UI.CustomErrorPageItems
{
    /// <summary>
    /// This control provides user interface for creating and editing customErrorPageItem definitions.
    /// </summary>
    public class CustomErrorPageItemsDetail : SimpleView
    {
        protected PageField PageSelector
        {
            get { return Container.GetControl<PageField>("customErrorPageItemPageId", true); }
        }

        #region Properties
        /// <summary>
        /// Obsolete. Use LayoutTemplatePath instead.
        /// </summary>
        protected override string LayoutTemplateName
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the layout template's relative or virtual path.
        /// </summary>
        public override string LayoutTemplatePath
        {
            get
            {
                if (string.IsNullOrEmpty(base.LayoutTemplatePath))
                    base.LayoutTemplatePath = CustomErrorPageItemsDetail.layoutTemplatePath;
                return base.LayoutTemplatePath;
            }
            set
            {
                base.LayoutTemplatePath = value;
            }
        }

        /// <summary>
        /// Gets the <see cref="T:System.Web.UI.HtmlTextWriterTag" /> value that
        /// corresponds to this Web server control. This property is used primarily by control
        /// developers.
        /// </summary>
        /// <returns>One of the <see cref="T:System.Web.UI.HtmlTextWriterTag" /> enumeration values.</returns>
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                //we use div wrapper tag to make easier common styling
                return HtmlTextWriterTag.Div;
            }
        }
        #endregion

        #region Public and overriden methods
        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <param name="container"></param>
        /// <remarks>
        /// Initialize your controls in this method. Do not override CreateChildControls method.
        /// </remarks>
        protected override void InitializeControls(GenericContainer container)
        {
            PageSelector.RootNodeID = Telerik.Sitefinity.Abstractions.SiteInitializer.CurrentFrontendRootNodeId;
        }
        #endregion

        #region Private fields and constants
        private static readonly string layoutTemplatePath = string.Concat(CustomErrorPagesModule.ModuleVirtualPath, "timw255.Sitefinity.CustomErrorPages.Web.UI.CustomErrorPageItems.CustomErrorPageItemsDetail.ascx");
        #endregion
    }
}
