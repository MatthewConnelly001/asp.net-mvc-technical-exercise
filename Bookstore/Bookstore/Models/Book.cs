﻿using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? BookingNumber { get; set; }  // Null = Not booked
    }
}
