var forgotPasswordController = function () {
    this.initialize = function () {
        registerEvents();
    };

    function registerEvents() {
        $('#frmForgotPassword').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                email: {
                    required: true,
                    email: true
                }
            },
            messages: {
                email: {
                    required: "We need your email address to contact you",
                    email: "Your email address must be in the format of name@domain.com"
                }
            }
        });

        $('#btnForgotPassword').on('click', function (e) {
            e.preventDefault();
            if ($('#frmForgotPassword').valid()) {
                $(this).addClass("disabled");
                $.ajax({
                    type: 'POST',
                    data: {
                        Email: $("#txtEmail").val()
                    },
                    dateType: 'json',
                    url: '/account/ForgotPassword',
                    success: function (res) {
                        if (res.Success) {
                            tedu.notify('Thành công: ' + res.Message, 'success');
                        } else {
                            tedu.notify('Lỗi: ' + res.Message, 'error');
                        }
                        $('#btnForgotPassword').removeClass("disabled");
                    },
                    error: function (e) {
                        $('#btnForgotPassword').removeClass("disabled");
                    }
                });
            }
        });
    }
};