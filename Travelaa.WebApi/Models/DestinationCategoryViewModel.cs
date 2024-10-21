﻿using Travelaa.EntityLayer.Concrete;

namespace Travelaa.WebApi.Models
{
    public class DestinationCategoryViewModel
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string ImageUrt { get; set; }
        public int CountDay { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
    }
}
