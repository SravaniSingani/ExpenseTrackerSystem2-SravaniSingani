using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExpenseTrackerSystem2.Models;

namespace ExpenseTrackerSystem2.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }
        // A card has many expenses
        public ICollection<Expense> Expenses { get; set; }
    }

    public class CardDto
    {
        public int CardId { get; set; }
        public string CardName { get; set; }
        public string CardType { get; set; }


    }
}