﻿using System;

namespace WebBanHangOnline.Models.ViewModels
{
    public class RevenueStatisticViewModel
    {
        public DateTime Date { get; set; }
        public decimal Benefit { get; set; }//lợi nhuân
        public decimal Revenues { get; set; }// tổng giá bán
    }
}