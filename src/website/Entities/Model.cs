using System.Collections.Generic;

namespace website.Entities
{
    public class Model
    {
        public Model()
        {
            Years = new List<ModelYear>();
        }
        
        public int ModelId { get; set; }

        public int MakeId { get; set; }

        public string Name { get; set; }
        
        public virtual Make Make { get; set; }

        public virtual List<ModelYear> Years { get; set; }
    }
}
