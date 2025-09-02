using System.IO;

public class Alumno
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }

}

class Program
{
    static HttpClient client = new HttpClient();
    static async Task Main()
    {
        string alumno = null;
        client.BaseAddress = new Uri("http://localhost:5257");
        HttpResponseMessage response = await client.GetAsync("api/alumnos");
        if (response.IsSuccessStatusCode)
        {
            alumno = await response.Content.ReadAsStringAsync();
        }
        Console.WriteLine(alumno);
        Console.ReadLine();
    }
}