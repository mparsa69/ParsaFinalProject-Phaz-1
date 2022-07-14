using App.Domain.Core.SuggestionAgg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.ExpertAgg.Entities
{
    public class Expert
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        public string Password { get; set; }
        [Display(Name = "تصویر")]
        public string ImageUrl { get; set; }
        [Display(Name = "موبایل")]
        public string Mobile { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }


        #region Navigation Property
        public ICollection<Suggestion> Suggestions { get; set; }
        public ICollection<ExpertSkill>? ExpertSkills { get; set; }
        #endregion


    }
}
