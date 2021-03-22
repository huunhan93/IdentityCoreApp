using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityCoreApp.Data.Entities;
using IdentityCoreApp.Data.Enums;
using IdentityCoreApp.Utilities.Constants;

namespace IdentityCoreApp.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        public DbInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Staff",
                    NormalizedName = "Staff",
                    Description = "Staff"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "SuperAdmin",
                    NormalizedName = "SuperAdmin",
                    Description = "SuperAdmin"
                });
            }
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "hohuunhandt@gmail.com",
                    Balance = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active
                }, "123654$");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (!_context.Contacts.Any())
            {
                _context.Contacts.Add(new Contact()
                {
                    Id = CommonConstants.DefaultContactId,
                    Address ="Cao Lanh city, Dong Thap province",
                    Email = "hohuunhandt@gmail.com",
                    Name = "NhanHo",
                    Phone = "0123 456 789",
                    Status = Status.Active,
                    Website = "https://yrestaurant.com",
                    Lat = 21.0435009,
                    Lng = 105.7894758
                });
            }
            if (_context.Functions.Count() == 0)
            {
                _context.Functions.AddRange(new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "System",ParentId = null,SortOrder = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Role",ParentId = "SYSTEM",SortOrder = 1,Status = Status.Active,URL = "/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Function",ParentId = "SYSTEM",SortOrder = 2,Status = Status.Active,URL = "/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "PERMISSION", Name = "Permission",ParentId = "SYSTEM",SortOrder = 3,Status = Status.Active,URL = "/permission/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "User",ParentId = "SYSTEM",SortOrder =4,Status = Status.Active,URL = "/user/index",IconCss = "fa-home"  },
                    
                    new Function() {Id = "PRODUCT",Name = "Product Management",ParentId = null,SortOrder = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Category",ParentId = "PRODUCT",SortOrder =1,Status = Status.Active,URL = "/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Product",ParentId = "PRODUCT",SortOrder = 2,Status = Status.Active,URL = "/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CODE",Name = "Product code",ParentId = "PRODUCT",SortOrder = 3,Status = Status.Active,URL = "/productcode/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "BILL",Name = "Bill",ParentId = "PRODUCT",SortOrder = 4,Status = Status.Active,URL = "/bill/index",IconCss = "fa-chevron-down"  },

                    new Function() {Id = "RESTAURANT", Name = "Restaurant",ParentId = null,SortOrder = 3,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "RESTAURANT_LIST", Name = "List restaurant",ParentId = "RESTAURANT",SortOrder = 1,Status = Status.Active,URL = "/restaurant/index",IconCss = "fa-home"  },
                    new Function() {Id = "MENU", Name = "Menu",ParentId = "RESTAURANT",SortOrder = 2,Status = Status.Active,URL = "/menu/index",IconCss = "fa-home"  },
                    new Function() {Id = "TABLE", Name = "Table",ParentId = "RESTAURANT",SortOrder = 3,Status = Status.Active,URL = "/table/index",IconCss = "fa-home"  },

                    new Function() {Id = "WAREHOUSE",Name = "Warehoure",ParentId = null,SortOrder = 3,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "INPUT_WAREHOUSE",Name = "Input",ParentId = "WAREHOUSE",SortOrder =1,Status = Status.Active,URL = "/input/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "TRANSFER_WAREHOUSE",Name = "Transfer",ParentId = "WAREHOUSE",SortOrder =2,Status = Status.Active,URL = "/transfer/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "OUTPUT_WAREHOUSE",Name = "Oupt",ParentId = "WAREHOUSE",SortOrder =3,Status = Status.Active,URL = "/output/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "VIEW_INVENTORY",Name = "View Inventory",ParentId = "WAREHOUSE",SortOrder =4,Status = Status.Active,URL = "/inventory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "WAREHOUSE_LIST",Name = "List warehouse",ParentId = "WAREHOUSE",SortOrder =5,Status = Status.Active,URL = "/warehouse/index",IconCss = "fa-chevron-down"  },

                    new Function() {Id = "UTILITY",Name = "Utilities",ParentId = null,SortOrder = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortOrder = 1,Status = Status.Active,URL = "/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Feedback",ParentId = "UTILITY",SortOrder = 2,Status = Status.Active,URL = "/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Contact",ParentId = "UTILITY",SortOrder = 3,Status = Status.Active,URL = "/contact/index",IconCss = "fa-clone"  },

                    new Function() {Id = "REPORT",Name = "Report",ParentId = null,SortOrder = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Revenue report",ParentId = "REPORT",SortOrder = 1,Status = Status.Active,URL = "/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Visitor Report",ParentId = "REPORT",SortOrder = 2,Status = Status.Active,URL = "/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "READER",Name = "Reader Report",ParentId = "REPORT",SortOrder = 3,Status = Status.Active,URL = "/report/reader",IconCss = "fa-bar-chart-o"  },
                });
            }

            if (_context.Footers.Count(x => x.Id == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "Footer";
                _context.Footers.Add(new Footer()
                {
                    Id = CommonConstants.DefaultFooterId,
                    Content = content
                });
            }
            
            
            await _context.SaveChangesAsync();

        }
    }
}
