using System;
using Newtonsoft.Json;

namespace Messenger_C {
    class Program {
        static void Main(string[] args) {

            Messenger message = new Messenger("mashasyanuk", "Good morning", DateTime.Now);
            string output = JsonConvert.SerializeObject(message);
            Console.WriteLine(output);
            Messenger deserialize = JsonConvert.DeserializeObject<Messenger>(output);
            Console.WriteLine(deserialize);

//            Console.WriteLine("Let's do it!");
 //           Console.WriteLine(message);

        }
    }

}