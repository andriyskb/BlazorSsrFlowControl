﻿namespace BlazorSsrFlowControl.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public int? Quantity { get; set; }
    }
}
