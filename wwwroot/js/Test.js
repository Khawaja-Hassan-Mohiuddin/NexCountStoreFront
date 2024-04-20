$(document).ready(function () {
    var $window = $(window),
        $sidebar = $(".sticky-sidebar"),
        $shape = $(".shape"),
        offset = $sidebar.offset();

    $window.scroll(function () {
        if ($window.scrollTop() > offset.top + $shape.outerHeight(true)) {
            $sidebar.addClass("fixed-sidebar");
        } else {
            $sidebar.removeClass("fixed-sidebar");
        }
    });
});