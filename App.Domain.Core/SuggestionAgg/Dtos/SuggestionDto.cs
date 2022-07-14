﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.SuggestionAgg.Dtos
{
    public class SuggestionDto
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public int ExpertId { get; set; }
        public int OrderId { get; set; }
    }
}
