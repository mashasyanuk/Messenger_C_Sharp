using System;
using Newtonsoft.Json;

namespace Messenger_C {
    class Program {
        static void Main(string[] args) {

            Messenger message = new Messenger("mashasyanuk", "Good morning", DateTime.Now);
            Console.WriteLine("Let's do it!");
            Console.WriteLine(message);
            string output = JsonConvert.SerializeObject(message);
            Console.WriteLine("Serialized: ");
            Console.WriteLine(output);
            Messenger deserialize = JsonConvert.DeserializeObject<Messenger>(output);
            Console.WriteLine("Deserialized: ");
            Console.WriteLine(deserialize);

        }
    }

}
