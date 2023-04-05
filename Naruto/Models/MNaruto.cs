﻿using System.ComponentModel.DataAnnotations;

namespace Naruto.Models
{
    public class MNaruto
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Clan { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string Jutsu { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
    }
}
