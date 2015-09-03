using mohammed.ninja.data.Contract;
using mohammed.ninja.models;

namespace mohammed.ninja.data
{
    public class ExampleRepository : Repository<Person>, IExampleRepository
    {
        public ExampleRepository(ApplicationContext context) :
            base(context)
        {
        }
    }
}
