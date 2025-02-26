using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace BasicJSONHandling
{
    class ValidateJSONStructure
    {
        static void Main(string[] args)
        {
            string jsonSchema = @"{
                'type': 'object',
                'properties': {
                    'name': {'type': 'string'},
                    'age': {'type': 'integer'}
                },
                'required': ['name', 'age']
            }";

            string jsonData = @"{
                'name': 'John Doe',
                'age': 30
            }";

            JSchema schema = JSchema.Parse(jsonSchema);
            JObject jsonObject = JObject.Parse(jsonData);

            bool isValid = jsonObject.IsValid(schema, out IList<string> errorMessages);

            if (isValid)
            {
                Console.WriteLine("JSON is valid.");
            }
            else
            {
                Console.WriteLine("JSON is invalid. Errors:");
                foreach (string error in errorMessages)
                {
                    Console.WriteLine(error);
                }
            }
        }
    }
}