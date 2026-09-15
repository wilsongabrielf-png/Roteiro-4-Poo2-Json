using System;

namespace ConsoleApp3.Models
{
    public class Pokemon
    {
        public string Name { get; set; } = string.Empty;
        public int Height { get; set; }
        public int Weight { get; set; }

        public int Id { get; set; }
        public int BaseExperience { get; set; }
    }
}
