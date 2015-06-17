<%@ Control Language="C#" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.Fields" TagPrefix="sf" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.FieldControls" TagPrefix="sfFields" %>
<sf:FormManager ID="formManager" runat="server" />
<fieldset class="sfNewItemForm">
    <a id="backToCustomErrorPageItems" href="javascript:void(0);" class="sfBack sfCancelCustomErrorPageItemButton">
        <asp:Literal ID="backToMasterLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, BackToLabel %>'></asp:Literal>
    </a>
    <h1>
        <asp:Literal ID="createACustomErrorPageItemLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CreateACustomErrorPageItem %>'></asp:Literal>
    </h1>
    <div class="sfForm sfFirstForm">
        <ul class="sfFormIn">
            <li class="sfTitleField">
                <label for="customErrorPageItemStatusCode" class="sfTxtLbl">
                    <asp:Literal ID="customErrorPageItemStatusCodeTitle" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemStatusCodeLabel %>'></asp:Literal>
                </label>
                <input id="customErrorPageItemStatusCode" type="text" class="sfTxt" />
                <div id="customErrorPageItemStatusCodeValidator" class="sfError" style="display:none;">
                    <asp:Literal ID="customErrorPageItemStatusCodeEmptyErrorLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemStatusCodeCannotBeEmpty %>'></asp:Literal>
                </div>
                <div id="customErrorPageItemStatusCodeLengthValidator" class="sfError" style="display:none;">
                    <asp:Literal ID="customErrorPageItemStatusCodeLengthErrorLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemStatusCodeInvalidLength %>'></asp:Literal>
                </div>
            </li>
            <li class="sfFormSeparator">
                <label for="customErrorPageItemPageId" class="sfTxtLbl">
                    <asp:Literal ID="customErrorPageItemPageIdTitle" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemPageIdLabel %>'></asp:Literal>
                </label>
                <sf:PageField ID="customErrorPageItemPageId" runat="server" WebServiceUrl="~/Sitefinity/Services/Pages/PagesService.svc/" DisplayMode="Write" />
                <div id="customErrorPageItemPageIdValidator" class="sfError" style="display:none;">
                    <asp:Literal ID="customErrorPageItemPageIdEmptyErrorLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemPageIdCannotBeEmpty %>'></asp:Literal>
                </div>
            </li>

        </ul>
    </div>
        
    <div class="sfButtonArea sfMainFormBtns">
        <a id="saveCustomErrorPageItemButton" class="sfLinkBtn sfSave">
            <span id="createCustomErrorPageItemButtonText" class="sfLinkBtnIn">
                <asp:Literal ID="createCustomErrorPageItemButtonLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CreateThisCustomErrorPageItemButton %>' />
            </span>
            <span id="saveChangesCustomErrorPageItemButtonText" class="sfLinkBtnIn" style="display:none;">
                <asp:Literal ID="saveChangesCustomErrorPageItemButtonLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, SaveChangesLabel %>' />
            </span>
        </a>
        <a id="cancel" class="sfCancel sfCancelCustomErrorPageItemButton">
            <asp:Literal ID="cancelLiteral1" runat="server" Text='<%$Resources:CustomErrorPagesResources, CancelLabel %>' />
        </a>
    </div>
</fieldset>
<script type="text/javascript">
    function GetPageSelectorId() {
        return "<%= customErrorPageItemPageId.ClientID %>";
    }
</script>