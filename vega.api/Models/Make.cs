using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.api.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }

        public Make()
        {
            Models = new Collection<Model>();
            // whenever you have a collection property in the class you should initialize it in the constructor of that class
            // Because we don't want somewhere else in the code you create a Make Object and then you have to type make.models = new collection<Model>();
            // we don't want to repeat this code everywhere
            // Initialization of this property is the responsibility of this class ,not anywhere else in the code
            // Also this will prevent you from getting a null reference exception because if you don't initialize it here
            // and forget to initialize it somewhere else in the code you're going to get a null reference exception

            // Now instead of Icollection and collection you could also use IList and the list class
            // the difference between a list and a collection is that the list gives you the ability to access objects in a collection using an index

            // but in this case when we get make and all its models from the database it's very unlikely that we want to acces a model by its index inside the make object
            // we just want to serialize it and return it to the client

        }
    }
}