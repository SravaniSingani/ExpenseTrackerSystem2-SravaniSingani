using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackerSystem2.Models
{
    public class Expense
    {

        //What describes an expense
        [Key]
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }

        //An expense has a Card Id
        //Each card has multiple expenses

        [ForeignKey("Card")]
        public int CardId { get; set; }
        public virtual Card Card { get; set; }

        //An expense has a Category Id
        //Each Category has multiple expenses

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }

    public class ExpenseDto
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public int CardId { get; set; }
        public string CardName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}