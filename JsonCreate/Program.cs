using Newtonsoft.Json;
using System;
using System.IO;

namespace JsonCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            Enployee employee = new Enployee {
            FirstName ="Sam",
            LastName ="Connon",
            EmployeeId = 123456,
            Designation = "bed tester"
            };
            

            string json = JsonConvert.SerializeObject(employee);
            string path = @"C:\Users\aies2\Desktop\employee.json";

            if(File.Exists(path))
            {
                File.Delete(path);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(json.ToString());
                    writer.Close();
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(json.ToString());
                    writer.Close();
                }
            }
            Console.ReadLine();


        }
    }
}
