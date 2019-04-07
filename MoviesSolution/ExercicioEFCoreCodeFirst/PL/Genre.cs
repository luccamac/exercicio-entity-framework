using System;
using System.Collections.Generic;
using System.Text;

namespace _ExercicioEFCoreCodeFirst.PL
{
    class Genre
    {
        public int GenreID { get; set; }//chave primaria [Key] (notaçao)
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }//chave estrangeira --> genero tem 0 ou mais filmes
    }
}
