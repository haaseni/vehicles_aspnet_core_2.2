using System.Collections.Generic;

namespace Vehicles.Web.Entities
{
    public class Make
    {
        public int MakeId { get; set; }

        public string Name { get; set; }

        public virtual List<Model> Models { get; set; }
    }
}
