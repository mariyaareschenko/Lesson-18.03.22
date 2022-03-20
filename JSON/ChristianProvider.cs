using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace JSON
{
    public class ChristianProvider
    {
        public void Provide(out Christian christian_obj)
        {
            string obj_json = File.ReadAllText(@"C:\Users\asus\OneDrive\Рабочий стол\прога\2 семестр\Lesson 18.03.22\JSON\bin\Debug\christian.json");
            christian_obj = JsonSerializer.Deserialize<Christian>(obj_json);
        }
    }
}
