﻿using System;

namespace KuetOverflow.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int ClassID { get; set; }
        public string Body { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
    }
}