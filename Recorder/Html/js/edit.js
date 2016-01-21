(function () {
    function Edit() {
        var me = this;
        function ViewModel(json)
        {
            var vm = this;
            vm.data = json;
            vm.save = function (json) {
                if (!json.data.Title)
                {
                    document.write("标题都不写你好意思点保存，我都不好意思再让你点了。哼！");
                    return;
                }
                var r = window.external.Save(JSON.stringify(json.data));
                if (r)
                    editPage.refresh();
                else
                    window.external.Alert("操作失败。");
            }
        }
        me.bind = function (json) {
            document.title = json.Title;
            ko.applyBindings(new ViewModel(json));
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