﻿using System;

namespace HotelService.Models
{
    public class ReserveModel
    {
        public int Id { get; set; }
        public string TransactionId { get; set; }
        public DateTime ReservationDate { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ReservationStatus { get; set; }

    }
}
