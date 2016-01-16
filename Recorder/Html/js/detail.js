(function () {
    function DetailPage() {
        var me = this;

        me.bind= function(json)
        {
            document.title = json.Title;
            ko.applyBindings(json);
        }
    }

    window.detailPage = new DetailPage();
}());