﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentalStoreAppAPI.Domain.Models
{
    public class StaffRoleModel
    {
        public int StaffRoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}
