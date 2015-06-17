using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace timw255.Sitefinity.CustomErrorPages
{
    /// <summary>
    /// Localizable strings for the CustomErrorPages module
    /// </summary>
    /// <remarks>
    /// You can use Sitefinity Thunder to edit this file.
    /// To do this, open the file's context menu and select Edit with Thunder.
    /// 
    /// If you wish to install this as a part of a custom module,
    /// add this to the module's Initialize method:
    /// App.WorkWith()
    ///     .Module(ModuleName)
    ///     .Initialize()
    ///         .Localization<CustomErrorPagesResources>();
    /// </remarks>
    /// <see cref="http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-import-events-from-facebook/creating-the-resources-class"/>
    [ObjectInfo("CustomErrorPagesResources", ResourceClassId = "CustomErrorPagesResources", Title = "CustomErrorPagesResourcesTitle", TitlePlural = "CustomErrorPagesResourcesTitlePlural", Description = "CustomErrorPagesResourcesDescription")]
    public class CustomErrorPagesResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="CustomErrorPagesResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public CustomErrorPagesResources()
        {
        }

        /// <summary>
        /// Initializes new instance of <see cref="CustomErrorPagesResources"/> class with the provided <see cref="ResourceDataProvider"/>.
        /// </summary>
        /// <param name="dataProvider"><see cref="ResourceDataProvider"/></param>
        public CustomErrorPagesResources(ResourceDataProvider dataProvider)
            : base(dataProvider)
        {
        }
        #endregion

        #region Class Description
        /// <summary>
        /// CustomErrorPages Resources
        /// </summary>
        [ResourceEntry("CustomErrorPagesResourcesTitle",
            Value = "CustomErrorPages module labels",
            Description = "The title of this class.",
            LastModified = "2015/06/15")]
        public string CustomErrorPagesResourcesTitle
        {
            get
            {
                return this["CustomErrorPagesResourcesTitle"];
            }
        }

        /// <summary>
        /// CustomErrorPages Resources Title plural
        /// </summary>
        [ResourceEntry("CustomErrorPagesResourcesTitlePlural",
            Value = "CustomErrorPages module labels",
            Description = "The title plural of this class.",
            LastModified = "2015/06/15")]
        public string CustomErrorPagesResourcesTitlePlural
        {
            get
            {
                return this["CustomErrorPagesResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for CustomErrorPages module.
        /// </summary>
        [ResourceEntry("CustomErrorPagesResourcesDescription",
            Value = "Contains localizable resources for CustomErrorPages module.",
            Description = "The description of this class.",
            LastModified = "2015/06/15")]
        public string CustomErrorPagesResourcesDescription
        {
            get
            {
                return this["CustomErrorPagesResourcesDescription"];
            }
        }
        #endregion

        #region Labels
        /// <summary>
        /// word: Actions
        /// </summary>
        [ResourceEntry("ActionsLabel",
            Value = "Actions",
            Description = "word: Actions",
            LastModified = "2015/06/15")]
        public string ActionsLabel
        {
            get
            {
                return this["ActionsLabel"];
            }
        }

        /// <summary>
        /// Title of the link for closing the dialog and going back to the CustomErrorPages module
        /// </summary>
        [ResourceEntry("BackToLabel",
            Value = "Go Back",
            Description = "Title of the link for closing the dialog and going back",
            LastModified = "2015/06/15")]
        public string BackToLabel
        {
            get
            {
                return this["BackToLabel"];
            }
        }

        /// <summary>
        /// word: Cancel
        /// </summary>
        [ResourceEntry("CancelLabel",
            Value = "Cancel",
            Description = "word: Cancel",
            LastModified = "2015/06/15")]
        public string CancelLabel
        {
            get
            {
                return this["CancelLabel"];
            }
        }

        /// <summary>
        /// word: Save
        /// </summary>
        /// <value>Save</value>
        [ResourceEntry("SaveLabel",
            Value = "Save",
            Description = "word: Save",
            LastModified = "2015/06/15")]
        public string SaveLabel
        {
            get
            {
                return this["SaveLabel"];
            }
        }

        /// <summary>
        /// phrase: Save changes
        /// </summary>
        [ResourceEntry("SaveChangesLabel",
            Value = "Save changes",
            Description = "phrase: Save changes",
            LastModified = "2015/06/15")]
        public string SaveChangesLabel
        {
            get
            {
                return this["SaveChangesLabel"];
            }
        }

        /// <summary>
        /// word: Delete
        /// </summary>
        [ResourceEntry("DeleteLabel",
            Value = "Delete",
            Description = "word: Delete",
            LastModified = "2015/06/15")]
        public string DeleteLabel
        {
            get
            {
                return this["DeleteLabel"];
            }
        }

        /// <summary>
        /// Phrase: Yes, delete these items
        /// </summary>
        /// <value>Yes, delete these items</value>
        [ResourceEntry("YesDeleteTheseItemsButton",
            Value = "Yes, delete these items",
            Description = "Phrase: Yes, delete these items",
            LastModified = "2015/06/15")]
        public string YesDeleteTheseItemsButton
        {
            get
            {
                return this["YesDeleteTheseItemsButton"];
            }
        }

        /// <summary>
        /// Text of the button that confirms deletion of an item.
        /// </summary>
        /// <value>Yes, delete this item</value>
        [ResourceEntry("YesDeleteThisItemButton",
            Value = "Yes, delete this item",
            Description = "Text of the button that confirms deletion of an item.",
            LastModified = "2015/06/15")]
        public string YesDeleteThisItemButton
        {
            get
            {
                return this["YesDeleteThisItemButton"];
            }
        }

        /// <summary>
        /// Phrase: items are about to be deleted. Continue?
        /// </summary>
        /// <value>items are about to be deleted. Continue?</value>
        [ResourceEntry("BatchDeleteConfirmationMessage",
            Value = "items are about to be deleted. Continue?",
            Description = "Phrase: items are about to be deleted. Continue?",
            LastModified = "2015/06/15")]
        public string BatchDeleteConfirmationMessage
        {
            get
            {
                return this["BatchDeleteConfirmationMessage"];
            }
        }

        /// <summary>
        /// word: Sort
        /// </summary>
        /// <value>Sort</value>
        [ResourceEntry("SortLabel",
            Value = "Sort",
            Description = "word: Sort",
            LastModified = "2015/06/15")]
        public string SortLabel
        {
            get
            {
                return this["SortLabel"];
            }
        }

        /// <summary>
        /// Phrase: Custom sorting
        /// </summary>
        /// <value>Custom sorting</value>
        [ResourceEntry("CustomSortingDialogHeader",
            Value = "Custom sorting",
            Description = "Phrase: Custom sorting",
            LastModified = "2015/06/15")]
        public string CustomSortingDialogHeader
        {
            get
            {
                return this["CustomSortingDialogHeader"];
            }
        }

        /// <summary>
        /// word: or
        /// </summary>
        /// <value>or</value>
        [ResourceEntry("OrLabel",
            Value = "or",
            Description = "word: or",
            LastModified = "2015/06/15")]
        public string OrLabel
        {
            get
            {
                return this["OrLabel"];
            }
        }

        /// <summary>
        /// Phrase: Sort by
        /// </summary>
        /// <value>Sort by</value>
        [ResourceEntry("SortByLabel",
            Value = "Sort by",
            Description = "Phrase: Sort by",
            LastModified = "2015/06/15")]
        public string SortByLabel
        {
            get
            {
                return this["SortByLabel"];
            }
        }

        /// <summary>
        /// word: Yes
        /// </summary>
        /// <value>Yes</value>
        [ResourceEntry("YesLabel",
            Value = "Yes",
            Description = "word: Yes",
            LastModified = "2013/06/26")]
        public string YesLabel
        {
            get
            {
                return this["YesLabel"];
            }
        }

        /// <summary>
        /// word: No
        /// </summary>
        /// <value>No</value>
        [ResourceEntry("NoLabel",
            Value = "No",
            Description = "word: No",
            LastModified = "2013/06/26")]
        public string NoLabel
        {
            get
            {
                return this["NoLabel"];
            }
        }
        #endregion

        #region CustomErrorPageItems
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the CustomErrorPageItem's page.</value>
        [ResourceEntry("CustomErrorPageItemGroupPageTitle",
            Value = "Custom Error Pages",
            Description = "The title of CustomErrorPageItem's page.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemGroupPageTitle
        {
            get
            {
                return this["CustomErrorPageItemGroupPageTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageDescription
        /// </summary>
        /// <value>Description for the CustomErrorPageItem's page.</value>
        [ResourceEntry("CustomErrorPageItemGroupPageDescription",
            Value = "Custom Error Pages",
            Description = "The description of CustomErrorPageItem's page.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemGroupPageDescription
        {
            get
            {
                return this["CustomErrorPageItemGroupPageDescription"];
            }
        }

        /// <summary>
        /// The URL name of CustomErrorPageItem's page.
        /// </summary>
        [ResourceEntry("CustomErrorPageItemGroupPageUrlName",
            Value = "Custom Error Pages",
            Description = "The URL name of CustomErrorPageItem's page.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemGroupPageUrlName
        {
            get
            {
                return this["CustomErrorPageItemGroupPageUrlName"];
            }
        }

        /// <summary>
        /// Message displayed to user when no customErrorPageItems exist in the system
        /// </summary>
        /// <value>No customErrorPageItems have been created yet</value>
        [ResourceEntry("NoCustomErrorPageItemsCreatedMessage",
            Value = "No Custom Error Pages have been created yet",
            Description = "Message displayed to user when no customErrorPageItems exist in the system",
            LastModified = "2015/06/15")]
        public string NoCustomErrorPageItemsCreatedMessage
        {
            get
            {
                return this["NoCustomErrorPageItemsCreatedMessage"];
            }
        }

        /// <summary>
        /// Title of the button for creating a new customErrorPageItem
        /// </summary>
        /// <value>Create a customErrorPageItem</value>
        [ResourceEntry("CreateACustomErrorPageItem",
            Value = "Create a Custom Error Page",
            Description = "Title of the button for creating a new customErrorPageItem",
            LastModified = "2015/06/15")]
        public string CreateACustomErrorPageItem
        {
            get
            {
                return this["CreateACustomErrorPageItem"];
            }
        }

        /// <summary>
        /// Label for editing a new customErrorPageItem
        /// </summary>
        /// <value>Create a customErrorPageItem</value>
        [ResourceEntry("EditACustomErrorPageItem",
            Value = "Edit a Custom Error Page",
            Description = "Label for editing a new customErrorPageItem",
            LastModified = "2015/06/15")]
        public string EditACustomErrorPageItem
        {
            get
            {
                return this["EditACustomErrorPageItem"];
            }
        }

        /// <summary>
        /// CustomErrorPageItem StatusCode.
        /// </summary>
        /// <value>Status Code</value>
        [ResourceEntry("CustomErrorPageItemStatusCodeLabel",
            Value = "Status Code",
            Description = "CustomErrorPageItem StatusCode.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemStatusCodeLabel
        {
            get
            {
                return this["CustomErrorPageItemStatusCodeLabel"];
            }
        }

        /// <summary>
        /// Error message displayed if the user does not enter customErrorPageItem StatusCode.
        /// </summary>
        [ResourceEntry("CustomErrorPageItemStatusCodeCannotBeEmpty",
            Value = "The Status Code cannot be empty.",
            Description = "Error message displayed if the user does not enter customErrorPageItem StatusCode.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemStatusCodeCannotBeEmpty
        {
            get
            {
                return this["CustomErrorPageItemStatusCodeCannotBeEmpty"];
            }
        }

        /// <summary>
        /// Error message displayed if the user enters too long StatusCode.
        /// </summary>
        /// <value>StatusCode value is too long. Maximum allowed is 255 characters.</value>
        [ResourceEntry("CustomErrorPageItemStatusCodeInvalidLength",
            Value = "Status Code value is too long. Maximum allowed is 255 characters.",
            Description = "Error message displayed if the user enters too long StatusCode.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemStatusCodeInvalidLength
        {
            get
            {
                return this["CustomErrorPageItemStatusCodeInvalidLength"];
            }
        }

        /// <summary>
        /// CustomErrorPageItem PageId.
        /// </summary>
        /// <value>Page To Return</value>
        [ResourceEntry("CustomErrorPageItemPageIdLabel",
            Value = "Page To Return",
            Description = "CustomErrorPageItem PageId.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemPageIdLabel
        {
            get
            {
                return this["CustomErrorPageItemPageIdLabel"];
            }
        }

        /// <summary>
        /// Error message displayed if the user does not enter customErrorPageItem PageId.
        /// </summary>
        [ResourceEntry("CustomErrorPageItemPageIdCannotBeEmpty",
            Value = "The PageId of the Custom Error Page cannot be empty.",
            Description = "Error message displayed if the user does not enter customErrorPageItem PageId.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemPageIdCannotBeEmpty
        {
            get
            {
                return this["CustomErrorPageItemPageIdCannotBeEmpty"];
            }
        }

        /// <summary>
        /// Message displayed to user when deleting a user customErrorPageItem.
        /// </summary>
        [ResourceEntry("DeleteCustomErrorPageItemConfirmationMessage",
            Value = "Are you sure you want to delete this Custom Error Page?",
            Description = "Message displayed to user when deleting a user customErrorPageItem.",
            LastModified = "2015/06/15")]
        public string DeleteCustomErrorPageItemConfirmationMessage
        {
            get
            {
                return this["DeleteCustomErrorPageItemConfirmationMessage"];
            }
        }

        /// <summary>
        /// phrase: Create this customErrorPageItem
        /// </summary>
        [ResourceEntry("CreateThisCustomErrorPageItemButton",
            Value = "Create this Custom Error Page",
            Description = "phrase: Create this customErrorPageItem",
            LastModified = "2015/06/15")]
        public string CreateThisCustomErrorPageItemButton
        {
            get
            {
                return this["CreateThisCustomErrorPageItemButton"];
            }
        }

        /// <summary>
        /// The URL name of CustomErrorPageItem's page.
        /// </summary>
        /// <value>CustomErrorPageItemMasterPageUrl</value>
        [ResourceEntry("CustomErrorPageItemMasterPageUrl",
            Value = "CustomErrorPageItemMasterPageUrl",
            Description = "The URL name of CustomErrorPageItem's page.",
            LastModified = "2015/06/15")]
        public string CustomErrorPageItemMasterPageUrl
        {
            get
            {
                return this["CustomErrorPageItemMasterPageUrl"];
            }
        }
        #endregion
    }
}