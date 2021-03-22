using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using IdentityCoreApp.Data.Enums;
using IdentityCoreApp.Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public AppUser() { }
        public AppUser(Guid id, string fullName, string userName,
            string email, string phoneNumber, string address, string avatar, Status status)
        {
            Id = id;
            FullName = fullName;
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            Avatar = avatar;
            Status = status;
        }

        public string FullName { get; set; }
        public DateTime? BirthDay { set; get; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public decimal Balance { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
    }
}
