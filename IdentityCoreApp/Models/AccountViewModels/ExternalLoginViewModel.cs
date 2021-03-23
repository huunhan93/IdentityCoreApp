using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCoreApp.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required(ErrorMessage = "Full name is required", AllowEmptyStrings = false)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone number is required", AllowEmptyStrings = false)]
        public string PhoneNumber { get; set; }

    }
}
