using Shared.Models;
using System.ComponentModel.DataAnnotations;



namespace Formation.Models
{
    public class Restaurant
    {
       
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
     
        public string Address { get; set; }
        [Required]
   
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string cuisine { get; set; }
        public Cuisine Cuisines { get; set; }
    }
}
