using System.ComponentModel.DataAnnotations;

namespace HaylandMontalvo_ProyectoCF.Models
{
    public class Burger
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }  
        public bool WithCheese { get; set; }
        [Range(0.01 , 3.50)]
        public decimal precio { get; set; } 


    }
}
