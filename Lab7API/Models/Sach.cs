﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab7API.Models
{
    public class Sach
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String AuthorName { get; set; }
        public decimal Price { get; set; }
    }
}