using App.Domain.Core.OrderAgg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.CustomerAgg.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        [Display(Name = "توضیحات")]
        public string Email { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        [Display(Name = "پسورد")]
        public string Password { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }

        #region Navigation Property
        public ICollection<Order> Orders { get; set; }
        #endregion

    }
}
