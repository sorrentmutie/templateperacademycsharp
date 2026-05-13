using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Console.UI.ViewModel;
    public class MostSoldProductViewModel
    {
        public int Id { get; init; }
        public required string Name { get; init; }
        public int SoldQuantity { get; init; }
        public decimal SoldTotal { get; init; }
}

