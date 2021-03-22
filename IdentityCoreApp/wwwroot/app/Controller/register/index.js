var registerController = function () {
    var _this = {};
    _this.initialize = function () {
        registerEvents();
    };

    function registerEvents() {
        $('#frmRegister').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                hoten: {
                    required: true
                },
                email: {
                    required: true,
                    email: true
                },
                password: {
                    required: true,
                    minlength: 6
                },
                password_again: {
                    equalTo: "#txtPassword"
                },
                sdt: {
                    required: true
                }
            },
            messages: {
                email: {
                    required: "We need your email address to contact you",
                    email: "Your email address must be in the format of name@domain.com"
                },
                matkhau: {
                    //required: "We need your email address to contact you",
                    minlength: jQuery.validator.format("At least {6} characters required!")
                }
            }
        });
        $("#btnRegister").on("click", function (e) {
            e.preventDefault();
            if ($('#frmRegister').valid()) {
                var fullName = $('#txtHoTen').val();
                var email = $('#txtEmail').val();
                var pass = $('#txtPassword').val();
                var pass_again = $('#txtPassword_again').val();
                var phone = $('#txtSDT').val();
                register(fullName, pass, pass_again, email, phone);
            }
        });
    }

    var register = function (fullName, pass, pass_again, email, phone) {
        $.ajax({
            type: 'POST',
            data: {
                FullName: fullName,
                Password: pass,
                ConfirmPassword: pass_again,
                Email: email,
                PhoneNumber: phone
            },
            dateType: 'json',
            url: '/Account/Register',
            success: function (res) {
                if (res.Success) {
                    tedu.notify(res.Message, 'success');
                    window.location.href = "/Account/ThankYouForRegister";
                } else {
                    tedu.notify('Lỗi: ' + res.Message, 'error');
                }
            },
            error: function (e) {
                tedu.notify('Có lỗi xảy ra', 'error');
            }
        });
    };

    return _this;
};