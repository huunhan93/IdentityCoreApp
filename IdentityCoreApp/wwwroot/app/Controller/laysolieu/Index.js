var laySoLieuController = function () {
    var cachedObj = {
        donvis: []
    };
    this.initialize = function () {
        loadDonVis();

        registerEvents();
    };

    function registerEvents() {
        $("#ddlDonVis").on("change", function () {
            loadKhoVatTus($("#ddlDonVis").val());
        });
    }

    function loadDonVis() {
        return $.ajax({
            type: "GET",
            url: "/Common/GetDonVis",
            dataType: "json",
            success: function (response) {
                cachedObj.donvis = response;
                $("#ddlDonVis").html();
                var render = "";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.MA_DONVI + "'>" + item.TEN_DONVI + "</option>";
                });
                $("#ddlDonVis").html(render);
            },
            error: function () {
                tedu.notify('Has load color an error in progress', 'error');
            }
        });
    }

    function loadKhoVatTus(dvtt) {
        return $.ajax({
            type: "GET",
            url: "/Common/GetKhoVatTus",
            data: { dvtt: dvtt },
            dataType: "json",
            success: function (response) {
                cachedObj.donvis = response;
                $("#ddlKhoVatTus").html();
                var render = "";
                $.each(response, function (i, item) {
                    render += "<option value='" + item.MAKHOVATTU + "'>" + item.TENKHOVATTU + "</option>";
                });
                $("#ddlKhoVatTus").html(render);
            },
            error: function () {
                tedu.notify('Has load color an error in progress', 'error');
            }
        });
    }
};