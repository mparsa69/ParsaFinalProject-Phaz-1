﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AdministratorAgg.Entities
{
    public class Administrator
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}
