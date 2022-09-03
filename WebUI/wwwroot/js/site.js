$(function () {
    var pgurl = window.location.href.substr(window.location.href
        .lastIndexOf("/") + 1);
    pgurl = "/Home/" + pgurl;
    $("#mynavigation li").each(function () {
        var link = $("a", this).attr('href');
        console.log("pgurl = "+pgurl);
        console.log("link = "+link);
        console.log(link == pgurl);
        if (link == pgurl) {
            $("a", this).addClass("activeheader");
        } else if (pgurl == "/Home/" && link =="/Home/index") {
            $("a", this).addClass("activeheader");
          
        }
    })
});