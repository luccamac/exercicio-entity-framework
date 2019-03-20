using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExercicioEFCoreCodeFirst
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Gross { get; set; }

        public double Rating { get; set; }

        [ForeignKey("GenreID")]
        public int GenreID { get; set; }

        public Genre Genre { get; set; }
    }
}
