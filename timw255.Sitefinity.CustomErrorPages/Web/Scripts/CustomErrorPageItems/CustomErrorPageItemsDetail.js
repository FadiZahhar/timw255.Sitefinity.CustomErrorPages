var CustomErrorPageItemsDetail = kendo.Class.extend({

    /* --------------------------------- Construction ------------------------------------ */

    init: function (form, dataSource, webServiceUrl) {
        form.kendoWindow({
            animation: false,
            modal: true,
            visible: false
        });
        form.parent().addClass("sfMaximizedWindow")
        this._formWindow = form.data("kendoWindow");
        this._dataSource = dataSource;
        this._webServiceUrl = webServiceUrl;
        this._formElements.pageId = GetPageSelectorId();
    },

    /* --------------------------------- public methods ---------------------------------- */

    show: function (id) {
        var that = this;
        this.reset();
        this.get_window().open();
        this.get_window().maximize();
        if (id) {
			$.ajax({
                type: 'GET',
                url: this.get_webServiceUrl() + id + "/",
                cache: false,
            }).done(function (data) {
                that.load(data.Item);
            });
            $("#createCustomErrorPageItemButtonText").hide();
            $("#saveChangesCustomErrorPageItemButtonText").show();
        }
        else {
            $("#createCustomErrorPageItemButtonText").show();
            $("#saveChangesCustomErrorPageItemButtonText").hide();
        }
    },

    close: function () {
        this.get_window().close();
    },

    load: function (data) {
        $(this._formElements.statusCode).val(data.StatusCode);

        var pageId = data.PageId;
        
        if (pageId) {
            $find(this._formElements.pageId).set_value(pageId);
        } else {
            $find(this._formElements.pageId).set_value("00000000-0000-0000-0000-000000000000");
        }

        this.set_id(data.Id);
    },

    save: function () {
        if (this.isValid()) {
            var data = this._getFormData();
            var that = this;
            $.ajax({
                type: 'PUT',
                url: that.get_webServiceUrl() + that.get_id() + "/",
                contentType: "application/json",
                processData: false,
                data: JSON.stringify(data),
                success: function (result, args) {
                    that.close();
                    that.get_dataSource().read();
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(Telerik.Sitefinity.JSON.parse(jqXHR.responseText).Detail);
                }
            });
        }
    },

    isValid: function () {
        var isValid = true;

        if ($(this._formElements.statusCode).val().length == 0) {
            $(this._formElements.statusCodeValidator).show();
            isValid = false;
        }
        else {
            $(this._formElements.statusCodeValidator).hide();
        }
        if ($(this._formElements.statusCode).val().length != 0 && $(this._formElements.statusCode).val().length > 255) {
            $(this._formElements.statusCodeLengthValidator).show();
            isValid = false;
        }
        else {
            $(this._formElements.statusCodeLengthValidator).hide();
        }

        var pageId = $find(this._formElements.pageId).get_value();

        if (pageId == "00000000-0000-0000-0000-000000000000") {
            $(this._formElements.pageIdValidator).show();
            isValid = false;
        }
        else {
            $(this._formElements.pageIdValidator).hide();
        }

        return isValid;
    },

    reset: function () {
        this.set_id("00000000-0000-0000-0000-000000000000");

        $(this._formElements.statusCode).val("");
        $(this._formElements.statusCodeValidator).hide();
        $(this._formElements.statusCodeLengthValidator).hide();

        $find(this._formElements.pageId).set_value("00000000-0000-0000-0000-000000000000");
        $(this._formElements.pageIdValidator).hide();
    },

    /* --------------------------------- event handlers ---------------------------------- */

    /* --------------------------------- private methods --------------------------------- */

    _getFormData: function () {
        var data = {
            "Item": {
                "StatusCode": $(this._formElements.statusCode).val(),
                "PageId": $find(this._formElements.pageId).get_value()
            }
        };
        return data;
    },

    /* --------------------------------- properties -------------------------------------- */

    get_window: function () {
        return this._formWindow;
    },

    get_dataSource: function () {
        return this._dataSource;
    },

    get_webServiceUrl: function () {
        return this._webServiceUrl;
    },

    get_id: function () {
        return this._id;
    },
    set_id: function (id) {
        this._id = id;
    },

    /* --------------------------------- private fields ---------------------------------- */

    _formElements: {
        statusCode: "#customErrorPageItemStatusCode",
        statusCodeValidator: "#customErrorPageItemStatusCodeValidator",
        statusCodeLengthValidator: "#customErrorPageItemStatusCodeLengthValidator",
        pageId: "#customErrorPageItemPageId",
        pageIdValidator: "#customErrorPageItemPageIdValidator"
    },
    _formWindow: null,
    _dataSource: null,
    _webServiceUrl: null,
    _id: "00000000-0000-0000-0000-000000000000"
});