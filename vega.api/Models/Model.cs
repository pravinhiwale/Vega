using System.ComponentModel.DataAnnotations;

namespace vega.api.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Make Make { get ; set;}
        // this is an inverse property , the other side of the association so each model is also associated with the make
        //its also called as a navigation property

        public int MakeId { get; set; }
        // foreign key property because this will help simplify creating and updating objects in the future 
        // if we follow naming convention entity framework will know that this mak and makeid is referring to the same thing
        // so when you use code first migrations it's not going to create an extra column for you.
    }
}