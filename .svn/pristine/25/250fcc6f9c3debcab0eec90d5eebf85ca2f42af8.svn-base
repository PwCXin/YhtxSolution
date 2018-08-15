

/**
* 生成UUID
*/
var random4 = function () {
    return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
};
var GetUUID = function () {
    return (random4() + random4() + "-" + random4() + "-" + random4() + "-" + random4() + "-" + random4() + random4() + random4());
};

var getRootPath = function () {
    //获取当前网址，如： http://localhost:8083/uimcardprj/share/meun.jsp
    var curWwwPath = window.document.location.href;
    //获取主机地址之后的目录，如： uimcardprj/share/meun.jsp
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    if (pos == 5) {
        pos = curWwwPath.indexOf(pathName, 7);
    }
    //获取主机地址，如： http://localhost:8083
    var localhostPath = curWwwPath.substring(0, pos);
    //获取带"/"的项目名，如：/uimcardprj
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    //return (localhostPath + projectName);
    return (localhostPath);
}