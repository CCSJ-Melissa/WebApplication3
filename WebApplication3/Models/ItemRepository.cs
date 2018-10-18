﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MidtermExam2.Models
{
    interface IItemRepository
    {
         string ItemRepository();
    }
    public class ItemRepository{ 
        int ItemID
        {
            get; set;
        }
        string Description
        {
            get; set;
        }
    }

        public class InMemoryItemRepository : IQueryable<Item>
        {
            public int ItemID { get; set; }
            public string Description { get; set; }
            public int UnitsOnHand { get; set; }
            public decimal Cost { get; set; }
            public decimal SellingPrice { get; set; }
        }
}
