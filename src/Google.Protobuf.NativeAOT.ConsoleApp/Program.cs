using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;

namespace Google.Protobuf.NativeAOT.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                TestNativeAOT();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void TestNativeAOT()
        {
            FileDescriptor.ForceReflectionInitialization<Person>();
            FileDescriptor.ForceReflectionInitialization<GenderType>();

            Person person = new Person
            {
                Id = 1,
                FirstName = "Allen",
                LastName = "Cai",
                Subject = "\"Google.Protobuf\" run in the NativeAOT",
                Age = 30,
                Enabled = true,
                Gender = GenderType.Male,
                CreatedTime = Timestamp.FromDateTimeOffset(DateTime.Now),
                Roles = { "admin" },
                Attributes = { { "Debug", "False" } },
                Amount = 987654321.6f,
                Height = 180.1d,
            };

            string jsonString = JsonFormatter.Default.Format(person);
            Console.WriteLine(jsonString);
        }
    }
}