using mohammed.ninja.data.Contract;
using mohammed.ninja.services.Contract;
using mohammed.ninja.models;

namespace mohammed.ninja.services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository exampleRepository;

        public ExampleService(IExampleRepository exampleRepository)
        {
            this.exampleRepository = exampleRepository;
        }

        public void CreatePhone()
        {
            exampleRepository.Insert(new Person()
            {
                Name = "",
            });
        }
    }
}
