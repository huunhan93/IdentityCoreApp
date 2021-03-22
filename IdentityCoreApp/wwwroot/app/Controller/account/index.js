var accountControler = function () {
    var _this = {};
    _this.initialize = function () {
        registerEvents();
    };

    function registerEvents() {
        $('#txtBirthDay').datepicker({
            format: 'dd/mm/yyyy',
            todayBtn: 'linked'
        });
        $('#frmAccount').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'vi',
            rules: {
                email: {
                    required: true
                },
                hoten: {
                    required: true
                }
            },
        });

        $("#btnUpdate").on("click", function (e) {
            e.preventDefault();
            if ($('#frmAccount').valid()) {
                var iduser = $('#txtIdUser').val();
                var email = $('#txtEmail').val();
                var hoten = $('#txtFullName').val();
                var diachi = $('#txtAddress').val();
                var ngaysinh = $('#txtBirthDay').val();
                var sdt = $('#txtPhoneNumber').val();
                update(iduser, email, hoten, diachi, ngaysinh, sdt);
            }
        });

        $("#btnChangePassword").on("click", function () {
            window.location.href = "/Account/UpdatePassword";
        });

        $("#btnLogout").on("click", function () {
            $.ajax({
                type: 'POST',
                dateType: 'json',
                url: '/Account/Logout',
                success: function (res) {
                    window.location.href = "/Login/Index";
                },
                error: function () {
                    tedu.notify('Có lỗi xảy ra', 'error');
                }
            });
        });
    };

    function update(iduser, email, hoten, diachi, ngaysinh, sdt) {
        $.ajax({
            type: 'PUT',
            data: {
                Id: iduser,
                FullName: hoten,
                Address: diachi,
                BirthDay: ngaysinh,
                PhoneNumber: sdt,
                Status: 1
            },
            dateType: 'json',
            url: '/Account/SaveEntity',
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