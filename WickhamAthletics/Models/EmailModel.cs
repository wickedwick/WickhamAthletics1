﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WickhamAthletics.Models
{
    public class EmailModel
    {
        public string Name { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}