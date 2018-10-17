using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MidtermExam2.Models
{
    public class Item
    {
		[Required(ErrorMessage = "Please enter an item")]
		public string ItemID {get; set;}
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the Units on Hand")]
		public int UnitsOnHand { get; set; }
		[Required(ErrorMessage = "Please enter a cost")]
		public decimal Cost {get; set; }
		[Required(ErrorMessage = "Please enter the selling price")]
		public decimal SellingPrice { get; set; }
	}
}
