using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace choque14.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string client { get; set; }
        public double total { get; set;}
        public string seller { get; set; }
    }
}
