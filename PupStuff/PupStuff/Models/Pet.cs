using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PupStuff.Models
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        public int PetAge { get; set; }
        public string PetPersonalityColor { get; set; }

    }
}
