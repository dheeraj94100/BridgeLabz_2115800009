using System;
using System.Xml;
using Newtonsoft.Json;

class JSONToXML
{
    static void Main(string[] args)
    {
        string json = @"{
            'Name': 'John',
            'Age': 30,
            'City': 'New York'
        }";

        XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(json, "Root");
        Console.WriteLine(xmlDoc.OuterXml);
    }
}