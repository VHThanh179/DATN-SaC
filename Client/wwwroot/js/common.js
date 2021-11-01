function ScrollLink() {
    var scrollLink = $('.scroll');

    // Smooth scrolling
    scrollLink.click(function (e) {
        e.preventDefault();
        $('body,html').animate({
            scrollTop: $(this.hash).offset().top
        }, 1000);
    });

    // Active link switching
    $(window).scroll(function () {
        var scrollbarLocation = $(this).scrollTop();

        scrollLink.each(function () {

            var sectionOffset = $(this.hash).offset().top - 20;

            if (sectionOffset <= scrollbarLocation) {
                $(this).parent().addClass('active');
                $(this).parent().siblings().removeClass('active');
            }
        })
    })
}
//function refreshMenu(obj) {

//    if (obj != "") {
//        var html = '<li class="dropdown"><a style="cursor:pointer" id="information" href="/info">' + obj.email + '</a><i class="bi bi-chevron-down"></i></li>';
//        html += '<li class="dropdown"><a class="nav-link btn btn-link text-dark" id="logout" href="/logout">Logout | </a></li>';
//        document.getElementById('navLogin').outerHTML = html;
//    }
//    else {
//        var html = '<li class="dropdown"><a style="cursor:pointer"<span>Tài khoản</span> id="register" href="/Register">Đăng ký</a><i class="bi bi-chevron-down"></i>';
//        html += '<li><a class="nav-link scrollto" href="/login">Đăng nhập</a></li>';
//        html += '<li><a class="nav-link scrollto" href="/register">Đăng ký</a></li>';
//        document.getElementById('navLogin').outerHTML = html;

//    }
//}