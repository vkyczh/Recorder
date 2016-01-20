(function () {
    function DetailPage() {
        var me = this;
        
        me.bind= function(json)
        {
            document.title = json.Title;            
            ko.applyBindings(json);
        }

        window.onload = function () {
            var result = util.getQueryDictionary(window.location.href);
            var record = window.external.GetRecordById(result["id"]);
            
            me.bind(JSON.parse(record));
        };

      
    }
  
    window.detailPage = new DetailPage();
}());