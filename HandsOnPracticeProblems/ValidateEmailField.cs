using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

public class ValidateEmailField
{
    public static bool IsValidEmail(string email)
    {
        string schemaJson = @"
        {
            'type': 'string',
            'format': 'email'
        }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject emailObject = new JObject
        {
            { "email", email }
        };

        return emailObject.IsValid(schema);
    }

    public static void Main(string[] args)
    {
        string email = "example@example.com";
        bool isValid = IsValidEmail(email);
        System.Console.WriteLine($"Is the email '{email}' valid? {isValid}");
    }
}