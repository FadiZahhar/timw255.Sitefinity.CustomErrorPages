<%@ Control Language="C#" %>

<style type="text/css">
.k-loading-mask { visibility: hidden; }
</style>
<!-- no customErrorPageItems created screen -->
<div id="customErrorPageItemsDecisionScreen" style="display:none;" class="sfEmptyList">
    <p class="sfMessage sfMsgNeutral sfMsgVisible"><asp:Literal ID="noCustomErrorPageItemsCreatedLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, NoCustomErrorPageItemsCreatedMessage %>'></asp:Literal></p>
    <ol class="sfWhatsNext">
        <li class="sfCreateItem">
            <a id="createCustomErrorPageItemDecisionScreen">
                <asp:Literal ID="createACustomErrorPageItemLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CreateACustomErrorPageItem %>'></asp:Literal>
                <span class="sfDecisionIcon"></span>
            </a>
        </li>
    </ol>
</div>

<!-- customErrorPageItems grid -->
<table id="customErrorPageItemsGrid" class="rgTopOffset rgMasterTable" style="display: none;">
    <thead>
        <tr>
            <th class="sfCheckBoxCol">
                <input type="checkbox" id="checkAllCheckbox" name="checkAllCheckbox" value="" />
            </th>
            <th class="sfTitleCol">
                <asp:Literal ID="customErrorPageItemHeader" runat="server" Text='<%$Resources:CustomErrorPagesResources, CustomErrorPageItemStatusCodeLabel %>'></asp:Literal>
            </th>
            <th class="sfMoreActions sfLast">
                <asp:Literal ID="actionsHeader" runat="server" Text='<%$Resources:CustomErrorPagesResources, ActionsLabel %>'></asp:Literal>
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td colspan="5">
            </td>
        </tr>
    </tbody>
    <tfoot>
        <tr class="rgPager">
            <td class="rgPagerCell NumericPages" colspan="5">
                <div class="rgWrap rgNumPart">
                    <div id="pagesWrapper">
                    </div>
                </div>
            </td>
        </tr>
    </tfoot>
</table>
<!-- customErrorPageItems grid row template -->
<script id="customErrorPageItemsRowTemplate" type="text/x-kendo-template" style="display: none;">
    <tr>
        <td class="sfCheckBoxCol">
            <input type="checkbox" data-command="check" data-id="#= Id #" value=""/>
        </td>
        <td class="sfTitleCol">
            <a class="sfEditButton sfItemTitle sfactive" data-command="edit" data-id="#= Id #">
                <strong>#= StatusCode #</strong>                
            </a>
        </td>
        <td class="sfMoreActions sfLast">
            <ul class="sfActionsMenu">
                <li class="sfFirst sfLast">
                    #= ActionsLabel #
                    <ul>
                        <li>
                            <a class="sfDeleteItm" data-command="delete" data-id="#= Id #">
                                #= DeleteLabel #
                            </a>
                        </li>   
                    </ul>
                <li>
            </ul>
        </td>
    </tr>
</script>
<!-- END customErrorPageItems grid row template -->

<div id="deleteCustomErrorPageItemConfirmationDialog" class="sfSelectorDialog">
    <p>
        <asp:Literal ID="deleteCustomErrorPageItemConfirmationLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, DeleteCustomErrorPageItemConfirmationMessage %>'/>
    </p>
    <div class="sfButtonArea">
        <a id="confirmCustomErrorPageItemDeleteButton" class="sfLinkBtn sfDelete">
            <span class="sfLinkBtnIn">
                <asp:Literal ID="deleteCustomErrorPageItemButtonLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, YesDeleteThisItemButton %>'/>
            </span>
        </a>
        <a id="cancelDeleteCustomErrorPageItemButton" class="sfCancel">
            <asp:Literal ID="cancelDeleteLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CancelLabel %>'/>
        </a>
    </div>
</div>

<div id="batchDeleteCustomErrorPageItemConfirmationDialog" class="sfSelectorDialog">
    <p>
        <span id="batchDeleteCustomErrorPageItemCountLabel"></span>
        <span id="batchDeleteCustomErrorPageItemConfirmationSpan">
            <asp:Literal ID="batchDeleteCustomErrorPageItemConfirmationLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, BatchDeleteConfirmationMessage %>'/>
        </span>
    </p>
    <div class="sfButtonArea">
        <a id="confirmCustomErrorPageItemBatchDeleteButton" class="sfLinkBtn sfDelete">
            <span class="sfLinkBtnIn">
                <asp:Literal ID="batchDeleteCustomErrorPageItemButtonLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, YesDeleteTheseItemsButton %>'/>
            </span>
        </a>
        <a id="cancelBatchDeleteCustomErrorPageItemButton" class="sfCancel">
            <asp:Literal ID="cancelBatchDeleteLiteral" runat="server" Text='<%$Resources:CustomErrorPagesResources, CancelLabel %>'/>
        </a>
    </div>
</div>

<div id="customErrorPageItemCustomSortingDialog" class="sfSelectorDialog">
    <h1><asp:literal ID="customSortingDialogHeader" runat="server" Text="<%$Resources:CustomErrorPagesResources, CustomSortingDialogHeader%>" /></h1>
    <div class="sfSortingCondition">
        <div class="sfSortRules">
            <label class="sfTxtLbl" for="customSortingCustomErrorPageItemPropertiesDropDownList">
                <asp:Literal ID="sortByLiteral" runat="server" Text="<%$Resources:CustomErrorPagesResources, SortByLabel%>" />
            </label>
			<div class="sfDropdownList sfInlineBlock sfAlignTop">
				<input id="customSortingCustomErrorPageItemPropertiesDropDownList" class="valid" />
			</div>
            <div class="sfInlineBlock">
                <ol class="sfRadioList">
                    <li>
                        <input id="ascendingRadioButton" type="radio" value="ASC" name="customSortingOrder" checked="checked">
                        <label for="ascendingRadioButton">Ascending</label>
                    </li>
                    <li>
                        <input id="descendingRadioButton" type="radio" value="DESC" name="customSortingOrder">
                        <label for="descendingRadioButton">Descending</label>
                    </li>
                </ol>
            </div>
        </div>
    </div>

    <div class="sfButtonArea sfSelectorBtns">
        <a ID="saveCustomSortingButton" Class="sfLinkBtn sfSave">
            <span class="sfLinkBtnIn">
                <asp:Literal ID="saveCustomSortingLiteral" runat="server" Text="<%$Resources:CustomErrorPagesResources, SaveLabel %>" />
            </span>
        </a>
        <asp:Literal ID="orLiteral" runat="server" Text="<%$Resources:CustomErrorPagesResources, OrLabel%>" />
        <a ID="cancelCustomSortingButton" Class="sfCancel">
            <asp:Literal ID="cancelCustomSortingLiteral" runat="server" Text="<%$Resources:CustomErrorPagesResources, CancelLabel %>" />
        </a>
    </div>
</div>