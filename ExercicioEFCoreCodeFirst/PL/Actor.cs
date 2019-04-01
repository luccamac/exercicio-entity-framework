using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    class Actor
    {
        [Key]
        public int ID { get; set; }

        public DateTime DateOfBirth { get; set; }

        public String Name { get; set; }

        public ActorMovie actorMovie { get; set; }
    }
}
