using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace StudentJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Samuel Alexander",
                RoolNumber = 1234,
                Class = 2022,
                Subjects = new List<string>
                {
                    "Bussiness Writing 101",
                    "Statistics 101",
                    "filosophy 101",
                    "Physics 101"
                }
            };


            string json = JsonConvert.SerializeObject(student);
            string path = @"C:\Users\aies2\Desktop\student.json";

            if (File.Exists(path))
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

            ReadFromJsonFile(path);

        }

        public static void ReadFromJsonFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                var student = JsonConvert.DeserializeObject<Student>(json);               
            }
            
        }
    }
}
