(function () {
    window.onerror = function (msg,file,line) {
        document.write(msg + "\r\n" + "\r\n"
            + file + "\r\n" + "\r\n"
            + line + "\r\n" + "\r\n"
            );
    }
    function Util() {
        var me = this;
        me.getQueryDictionary = function(href)
        {
            var start = href.indexOf("?");
            var query = window.location.href.substr(start + 1);
            var pairs = query.split('&');
            var result = {};
            pairs.forEach(function (item) {
                var pair = item.split('=');
                if (pair.length == 2)
                    result[pair[0]] = pair[1];
            });
            return result;
        }
    }

    window.util = new Util();
}());