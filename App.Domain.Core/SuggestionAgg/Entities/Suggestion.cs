using App.Domain.Core.ExpertAgg.Entities;
using App.Domain.Core.OrderAgg.Dtos;
using App.Domain.Core.OrderAgg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.SuggestionAgg.Entities
{
    public class Suggestion
    {
        [Key]
        public int Id { get; set; }
        public DateTime? SuggestionDate { get; set; }
        [Display(Name = "قیمت")]
        public long Price { get; set; }
        [Display(Name = "ساعت شروع")]
        public string StartTime { get; set; }
        [Display(Name = "مدت زمان انجام کار")]
        public string Duration { get; set; }
        public bool IsApproved { get; set; } = false;

        #region Navigation Property
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        #endregion
    }
}
