using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace phuongtrinhb1.Models
{
    public class khachhang
    {
        [Key]
        public string username { get; set; }
        public string address { get; set; }

    }
} 