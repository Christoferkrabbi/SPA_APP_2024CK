﻿namespace Backend.Model
{
    public record Person
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public string? Name { get; set; }     
    }
}
