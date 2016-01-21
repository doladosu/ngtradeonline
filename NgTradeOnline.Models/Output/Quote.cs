﻿using System;

namespace NgTradeOnline.Models.Output
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public DateTime Date { get; set; }
        public decimal Low { get; set; }
        public decimal Open { get; set; }
        public int Volume { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public string Symbol { get; set; }
        public decimal Change1 { get; set; }
        public int Trades { get; set; }
    }
}