﻿namespace BookStoreAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Book> Books { get; set; }
    }
}