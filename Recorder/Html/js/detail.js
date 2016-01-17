(function () {
    function DetailPage() {
        var me = this;

        me.bind= function(json)
        {
            document.title = json.Title;            
            ko.applyBindings(json);
        }

        window.onload = function () {
            var start = window.location.href.indexOf("?");
            var query = window.location.href.substr(start + 1);
            var id = query.substr(query.indexOf("=") + 1);
            var record = window.external.GetRecordById(id);
            me.bind(JSON.parse(record));
        };
    }
  
    window.detailPage = new DetailPage();
}());