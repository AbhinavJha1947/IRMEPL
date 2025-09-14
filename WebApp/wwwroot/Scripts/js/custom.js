$("[data-widget='collapse']").click(function() {
    //Find the box parent........
    var box = $(this).parents(".box").first();
    //Find the body and the footer
    var bf = box.find(".box-body, .box-footer");
    if (!$(this).children().hasClass("fa-plus")) {
        $(this).children(".fa-minus").removeClass("fa-minus").addClass("fa-plus");
        bf.slideUp();
    } else {
        //Convert plus into minus
        $(this).children(".fa-plus").removeClass("fa-plus").addClass("fa-minus");
        bf.slideDown();
    }
});

$(document).ready(function () {
   
    $('.table-fixed').DataTable({
        scrollY: '200px',
        scrollCollapse: true,
        paging: false,
        searching: false,
        search: false
    });
    $('.table-fixed-2').DataTable({
        scrollY: '200px',
        scrollCollapse: true,
        paging: false,
        searching: false,
        search: false
    });
    $('.table-fixed-3').DataTable({
        scrollY: '200px',
        scrollCollapse: true,
        paging: false,
        searching: false,
        search: false
    });
});