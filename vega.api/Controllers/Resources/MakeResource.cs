using System.Collections.Generic;

using vega.api.Models;
using vega.api.Controllers.Resources;
using System.Collections.ObjectModel;

namespace vega.api.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ModelResource> Models { get; set; }

        public MakeResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}