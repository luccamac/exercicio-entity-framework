using System;
using System.Collections.Generic;
using System.Text;

namespace _ExercicioEFCoreCodeFirst.PL
{
    class ActorMovie
    {
        public int ActorMovieID { get; set; }
        public string Character { get; set; }

        public int MovieId { get; set; }//id do movie
        public Movie Movie { get; set; }

        public int ActorId{ get; set; }
        public Actor Actor { get; set; }
        
    }
}
