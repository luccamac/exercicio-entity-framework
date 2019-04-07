﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _ExercicioEFCoreCodeFirst.PL
{
    class Movie
    {
        public int ID { get; set; } 
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Gross { get; set; }
        public double Rating { get; set; }
        public int GenreID { get; set; } //chave estrangeira
        public Genre Genre { get; set; } //significa quem o filme tem 1 genero ("cardinalidade")
    }
}
