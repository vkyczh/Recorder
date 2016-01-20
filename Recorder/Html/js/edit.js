(function () {
    function Edit() {
        var me = this;
        me.bind = function (json) {
            document.title = json.Title;
            ko.applyBindings(json);
        }

        me.refresh = function () {
            if (me.query["from"] === "detail")
                window.location = "detail.html?id=" + me.id;
            else
                window.location.reload();
        }

        me.load = function ()
        {
            me.query = util.getQueryDictionary(window.location.href);
            me.id = me.query["id"];
            me.record = JSON.parse(window.external.GetRecordById(me.id ? me.id : ""));
            me.bind(me.record);
        }

        window.onload = function () {
            me.load();
        };
    }

    window.editPage = new Edit();
}());