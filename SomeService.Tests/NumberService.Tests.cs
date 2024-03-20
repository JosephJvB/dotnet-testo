using SomeService.Services;
using Newtonsoft.Json;

namespace SomeService.UnitTests.Services
{
    public class NumberService_AddShould
    {
        [Fact]
        public void Add_InputIs_1_5_Return6()
        {
            var service = new NumberService();

            var result = service.Add(1, 5);

            Console.WriteLine(JsonConvert.SerializeObject(new
            {
                result = result
            }));

            Assert.Equal(6, result);
        }
    }
}
