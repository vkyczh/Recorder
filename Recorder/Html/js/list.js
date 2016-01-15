(function () {
    /*>>>>>开始：初始设置*/
    Notice = function (msg) { window.external.Alert(msg) };
    onerror = function (a, b, c) {
        document.write(a + "\r\n" + b + "\r\n" + c);
    }
    /*<<<<<结束：初始设置*/


    /*>>>>>开始：界面对象定义*/
    function ListPage() {
        var me = this;
        me.bind = bind;

        function ViewModel(list) {
            var me = this;
            me.list = ko.observableArray(list);
            me.formatDate = function (date) {
                return date.substr(0, 10);
            }
            me.detail = function (data, e) {
                window.external.ShowDetail(JSON.stringify(data));
            }
        }

        function bind() {
            var list = JSON.parse(window.external.Read());
            ko.applyBindings(new ViewModel(list));
        }


    }
    /*<<<<<结束：界面对象定义*/

    window.listPage = new ListPage();
    window.onload = function () {
        listPage.bind();
    }

}());