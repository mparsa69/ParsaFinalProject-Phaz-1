using App.Domain.Core.OrderAgg.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.OrderAgg.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatusCode Status { get; set; } = OrderStatusCode.WaitForSuggestion;
        //public string Status { get; set; }
        public int CustomerId { get; set; }
        public int ThirdCategoryId { get; set; }
    }
}
