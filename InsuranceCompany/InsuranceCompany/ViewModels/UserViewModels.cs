﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceCompany.ViewModels
{
    public class UserPageViewModel : PageViewModel<UserViewModel> { }

    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int UserRole { get; set; }

        public string FullName { get; set; }

        public bool IsActive { get; set; }
    }
}
