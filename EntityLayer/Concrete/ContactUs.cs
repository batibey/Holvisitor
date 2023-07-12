﻿namespace EntityLayer.Concrete
{
    public class ContactUs
    {
        public int ContactUsID { get; set; }
        public string? Name { get; set; }
        public string? Mail { get; set; }
        public string? Subject { get; set; }
        public string? MessageBody { get; set; }
        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }
    }
}
