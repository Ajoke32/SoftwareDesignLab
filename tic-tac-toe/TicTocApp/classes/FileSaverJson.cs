using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using System.Reflection;

namespace TicTocApp.classes
{
    public class FileSaverJson
    {
        public string Path { get; set; } = Directory.GetCurrentDirectory() + "/GameState.json";

        protected object SaveObject;
        public FileSaverJson(object SaveObj)
        {
            SaveObject = SaveObj;
        }
        public bool SaveFile()
        {
            var savedata = JsonSerializer.Serialize(SaveObject, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(Path, savedata);
            Console.WriteLine("Game saved!");
            return true;
        }

        public bool LoadFile()
        {
            if(!File.Exists(Path))
            {
                return false;
            }
            string data = File.ReadAllText(Path);
            var result = JsonSerializer.Deserialize<Game>(data);
            if (result == null)
            {
                return false;
            }
            foreach (var prop in result.GetType().GetProperties())
            {
                var info = SaveObject.GetType().GetProperty(prop.Name);
                if (info != null)
                {
                    info.SetValue(SaveObject, prop.GetValue(result));
                }
            }
            return true;
        }

        public Game? GetFile()
        {
            string data = File.ReadAllText(Path);
            return JsonSerializer.Deserialize<Game>(data);
        }

        public bool AppendInfo(object data)
        {
            var savedata = JsonSerializer.Serialize(data);
            File.AppendAllText(Path, savedata);
            return true;
        }

    }
}
