﻿using System;

namespace KuetOverflow.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Body { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Time { get; set; }
    }
}
