using System.ComponentModel.DataAnnotations.Schema;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class ActorMovie
    {
        [ForeignKey("ID")]
        public int ActorID { get; set; }

        public string Chracter { get; set; }

        [ForeignKey("MovieID")]
        public int Movie;
    }
}