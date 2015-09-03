using System.Collections.Generic;
using mohammed.ninja.models;

namespace mohammed.ninja.data
{
    
    public partial class ApplicationContext
    {
        public ApplicationContext()
        {
            
        }

        public virtual List<Person> People { get; set; }
    }
}
