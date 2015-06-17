<%@ Control Language="C#" %>
<%@ Register TagPrefix="sitefinity" Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" %>
<%@ Register TagPrefix="CustomErrorPages" Assembly="timw255.Sitefinity.CustomErrorPages" Namespace="timw255.Sitefinity.CustomErrorPages.Web.UI.CustomErrorPageItems" %>
<%@ Import Namespace="timw255.Sitefinity.CustomErrorPages" %>

<sitefinity:ResourceLinks ID="resourcesLinks" runat="server">
    <sitefinity:ResourceFile Name="Styles/Ajax.css" />
    <sitefinity:ResourceFile Name="Styles/DatePicker.css" />
    <sitefinity:ResourceFile Name="Styles/Grid.css" />
    <sitefinity:ResourceFile Name="Styles/ListView.css" />
    <sitefinity:ResourceFile Name="Styles/MaxWindow.css" />
    <sitefinity:ResourceFile Name="Styles/MenuMoreActions.css" />
    <sitefinity:ResourceFile Name="Styles/Tabstrip.css" />
    <sitefinity:ResourceFile Name="Styles/Window.css" />
    <sitefinity:ResourceFile Name="Telerik.Sitefinity.Resources.Scripts.JSON2.js" />
</sitefinity:ResourceLinks>
<sitefinity:ResourceLinks ID="resourcesLinks2" runat="server" UseEmbeddedThemes="true" Theme="Default">
    <sitefinity:ResourceFile Name="Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_common_min.css" Static="True" />
    <sitefinity:ResourceFile Name="Telerik.Sitefinity.Resources.Scripts.Kendo.styles.kendo_default_min.css" Static="True" />
    <sitefinity:ResourceFile Name="timw255.Sitefinity.CustomErrorPages.Web.Resources.CustomStylesKendoUIView.css" AssemblyInfo="timw255.Sitefinity.CustomErrorPages.CustomErrorPagesModule, timw255.Sitefinity.CustomErrorPages" Static="True" />
</sitefinity:ResourceLinks>
<h1 class="sfBreadCrumb">
    <asp:Literal runat="server" Text='CustomErrorPages'/>
</h1>
<div class="sfMain sfClearfix">
    <div class="sfContent">
        <!-- toolbar -->
        <div id="toolbar" class="sfAllToolsWrapper">
            <div class="sfAllTools">
                <ul class="sfActions">
                    <li class="sfMainAction">
                        <a id="createUserCustomErrorPageItem" class="sfLinkBtn sfSave">
                            <span class="sfLinkBtnIn">
                                <asp:Literal ID="createACustomErrorPageItem" runat="server" Text='<%$Resources:CustomErrorPagesResources, CreateACustomErrorPageItem %>'/>
                            </span>
                        </a>
                    </li>
                    <li class="sfGroupBtn">
                        <a id="deleteUserCustomErrorPageItems" class="sfLinkBtn sfDisabledLinkBtn">
                            <span class="sfLinkBtnIn">
                                <asp:Literal ID="deleteUserCustomErrorPageItemsLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, DeleteLabel %>'/>
                            </span>
                        </a>
                    </li>
                    <li class="sfQuickSort sfNoMasterViews sfDropdownList">
                        <asp:Literal ID="SortLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, SortLabel %>'/>
                        <input id="sortingDropDownList" />
                    </li>
                </ul>
            </div>
        </div>

        <!-- main area -->
        <div class="sfWorkArea" id="workArea">
            <div id="customErrorPageItemsMasterView">
                <CustomErrorPages:CustomErrorPageItemsMaster id="CustomErrorPageItemsMaster" runat="server" />
            </div>
            <div id="customErrorPageItemsDetailWindow" class="sfDialog sfFormDialog k-sitefinity">
                <CustomErrorPages:CustomErrorPageItemsDetail id="CustomErrorPageItemsDetail" runat="server" />
            </div>
        </div>
    </div>
</div>

<input id="customErrorPageItemsServiceUrlHidden" type="hidden" value="<%= VirtualPathUtility.ToAbsolute("~/" + CustomErrorPagesModule.CustomErrorPageItemsWebServiceUrl)  %>" />
