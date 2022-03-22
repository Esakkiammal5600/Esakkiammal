$(document).ready(function () {
    var e = $("#header"); var d = $(".nav-link");
    if (e.length) {
        var n = function () {
            requestAnimationFrame(function () {
                if (56 <= $(this).scrollTop()) {
                    e.addClass("background");
                    d.addClass("text-default");
                } else {
                    d.removeClass("text-default");
                    e.removeClass("background");
                }
            })
        }; $(document).scroll(n), $(document).ready(n)
    } $(".hamburger").on("click", function () { $(this).toggleClass("opened"), $("#header").toggleClass("opened"), $("#navOverlay").toggleClass("opened") })
});