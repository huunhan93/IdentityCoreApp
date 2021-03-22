var loginController = function () {
    var _this = {};
    _this.initialize = function () {
        registerEvents();
    };

    var registerEvents = function () {
        $('#frmLogin').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                email: {
                    required: true
                },
                password: {
                    required: true,
                    minlength: 6 
                }
            },
            messages: {
                matkhau: {
                    //required: "We need your email address to contact you",
                    minlength: jQuery.validator.format("At least {0} characters required!")
                }
            }
        });

        $('#btnLogin').on('click', function (e) {
            e.preventDefault();
            if ($('#frmLogin').valid()) {
                var user = $('#txtEmail').val();
                var pass = $('#txtPassword').val();
                var remember = $('#customCheck').is(":checked");
                login(user, pass, remember);
            }
            
        });
        $('#txtPassword').on('keypress', function (e) {
            if (e.which === 13) {
                $('#btnLogin').click();
            }
        });
    };

    var login = function (user, pass, remember) {
        $.ajax({
            type: 'POST',
            data: {
                Email: user,
                Password: pass,
                RememberMe: remember
            },
            dateType: 'json',
            url: '/login/authen',
            success: function (res) {
                if (res.Success) {
                    window.location.href = "/Home/Index";
                } else {
                    tedu.notify('Lỗi: ' + res.Message, 'error');
                }
            },
            error: function () {
                tedu.notify('Có lỗi xảy ra', 'error');
            }
        });
    };

    

    return _this;
}