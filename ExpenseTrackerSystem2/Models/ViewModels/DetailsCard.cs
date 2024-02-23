using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseTrackerSystem2.Models.ViewModels
{
    public class DetailsCard
    {
        public CardDto SelectedCard { get; set; }
        public IEnumerable<ExpenseDto> RelatedExpensestoCard { get; set; }
    }
}