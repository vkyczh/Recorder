(function () {

    /*>>>>>开始：界面对象定义*/
    function ListPage() {
        var me = this;
        me.bind = bind;
        function ViewModel(list) {
            var vm = this;
            vm.Title = ko.observable("");
            vm.Tag = ko.observable("");
            vm.search = function () {
                var result = JSON.parse(external.Search(vm.Title(),vm.Tag()));
                vm.list(result);
            }
            vm.dataRefreshed = function (data) {
                window.location.reload();
            };
            vm.list = ko.observableArray(list);
            vm.formatDate = function (date) {
                return date.substr(0, 10);
            }
            vm.delete = function (data) {
                if (external.Delete(data.Id))
                    vm.list.remove(data);
            }

            vm.detail = function (data, e) {
                window.external.ShowDetail(JSON.stringify(data));
            }
        }

        function bind() {
            var list = JSON.parse(window.external.Read());
            me.vm = new ViewModel(list);
            ko.applyBindings(me.vm);
        }


    }
    /*<<<<<结束：界面对象定义*/

    window.listPage = new ListPage();
    window.onload = function () {
        listPage.bind();
    }

}());