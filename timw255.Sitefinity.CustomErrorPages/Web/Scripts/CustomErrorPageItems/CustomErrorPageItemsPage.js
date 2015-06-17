$(document).ready(function () {
    var webServiceUrl = $('#customErrorPageItemsServiceUrlHidden').val();
    
    var itemsCountPerPage = 50;
    var sortExpression = "DateCreated DESC";
    var itemsTotalCount;
    var isLastPageDeleted;

    var dataSource = new kendo.data.DataSource({
        transport: {
            read: {
                url: webServiceUrl + "?sortExpression=" + sortExpression + "&take=" + itemsCountPerPage,
                dataType: "json",
				cache: false,
            }
        },
        schema: {
            model: {
                id: "Id"
            },
            data: function (result) {
                itemsTotalCount = result.TotalCount;
                var items = result.Items;

                /* all items from the last page were deleted so the data source must be refreshed */
                isLastPageDeleted = (items.length == 0 && itemsTotalCount != 0);

                return items;
            }
        },
        change: function (e) {
            if (isLastPageDeleted) {
                /* refresh the data source */
                customErrorPageItemsMasterView.set_skip((customErrorPageItemsMasterView.get_currentPage() - 2) * customErrorPageItemsMasterView.get_itemsCountPerPage());
                customErrorPageItemsMasterView.get_dataSource().read();
                return;
            }
            customErrorPageItemsMasterView.refreshPager(itemsTotalCount);
        }
    });

    var customErrorPageItemsDetailView = new CustomErrorPageItemsDetail($("#customErrorPageItemsDetailWindow"), dataSource, webServiceUrl);
    var customErrorPageItemsMasterView = new CustomErrorPageItemsMaster(customErrorPageItemsDetailView, dataSource, itemsCountPerPage, webServiceUrl);
    customErrorPageItemsMasterView.set_sortExpression(sortExpression);

    jQuery("body").addClass("sfNoSidebar");

    $("#createUserCustomErrorPageItem").click(function () {
        customErrorPageItemsDetailView.show();
    });

    $("#createCustomErrorPageItemDecisionScreen").click(function () {
        customErrorPageItemsDetailView.show();
    });

    $(".sfCancelCustomErrorPageItemButton").click(function () {
        customErrorPageItemsDetailView.close();
    });

    $("#saveCustomErrorPageItemButton").click(function () {
        customErrorPageItemsDetailView.save();
    });
});