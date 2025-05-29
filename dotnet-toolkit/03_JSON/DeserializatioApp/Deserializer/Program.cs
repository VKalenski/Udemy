using System.Text.Json;


using HttpClient client = new()
{
    BaseAddress = new Uri("https://localhost:7146")
};


var response = await client.GetAsync("weatherforecast");

if(response.IsSuccessStatusCode)
{
    var jsonString = await response.Content.ReadAsStringAsync();

    using (JsonDocument jsonDocument = JsonDocument.Parse(jsonString))
    {
        JsonElement root = jsonDocument.RootElement;

        Console.WriteLine(root.ValueKind);

        foreach(var temp in root.EnumerateArray())
        {
            Console.WriteLine(temp.GetProperty("summary").ToString());
        }
    }
}
else
{
    Console.WriteLine($"Whoops ! Error: {response.StatusCode}" );
}