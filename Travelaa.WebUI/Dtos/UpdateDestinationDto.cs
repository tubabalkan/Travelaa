﻿namespace Travelaa.WebUI.Dtos
{
    public class UpdateDestinationDto
    {
        public int destinationId { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string ImageUrt { get; set; }
        public int countDay { get; set; }
        public string subTitle { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public DateTime date { get; set; }
    }
}
