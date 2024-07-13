using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication16.Models
{
    public class QRCodeModel
    {
        public string QRCodeText {get;set;}
        public string QRImageUrl { get; set; }
    }
}