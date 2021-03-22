var updatePasswordController = function () {
    var _this = {};
    _this.initialize = function () {
        registerEvents();
    };

    function registerEvents() {
        $('#frmTaiKhoan').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                password_old: {
                    required: true
                },
                password: "required",
                password_again: {
                    equalTo: "#txtPassword"
                }
            },
            messages: {
                password_old: {
                    //required: "We need your email address to contact you",
                    minlength: jQuery.validator.format("At least {6} characters required!")
                },
                password: {
                    //required: "We need your email address to contact you",
                    minlength: jQuery.validator.format("At least {6} characters required!")
                },
                password_again: {
                    //required: "We need your email address to contact you",
                    minlength: jQuery.validator.format("At least {6} characters required!")
                }
            }
        });

        $("#btnCapNhat").on("click", function (e) {
            e.preventDefault();
            if ($('#frmTaiKhoan').valid()) {
                var userId = $('#txtIdUser').val();
                var password_old = $('#txtPassword_old').val();
                var password = $('#txtPassword').val();
                
                changePassword(userId, password_old, password);
            }
        });
        
    };

    function changePassword(userId, password_old, password) {
        $.ajax({
            type: 'PUT',
            data: {
                userId: userId,
                password_old: password_old,
                password: password,
            },
            dateType: 'json',
            url: '/taikhoan/UpdatePassword',
            success: function (res) {
                if (res.Success) {
                    tedu.notify(res.Message, 'success');
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