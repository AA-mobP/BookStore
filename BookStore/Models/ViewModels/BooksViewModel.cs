﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models.ViewModels
{
    public class BooksViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
}
