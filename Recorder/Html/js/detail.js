(function () {
    function DetailPage() {
        var me = this;

        me.bind= function(json)
        {
            ko.applyBindings(json);
        }
    }

    window.detailPage = new DetailPage();
}());