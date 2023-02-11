using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;

namespace TicTocApp.classes
{
    public class FileSaverJson
    {
        public string Path { get; set; } = "../../../GameState.json";
        public bool SaveFile(object saveObj)
        {
            var savedata = JsonSerializer.Serialize(saveObj,new JsonSerializerOptions() { WriteIndented=true});
            File.WriteAllText(Path, savedata);
            return true;
        }

        public Game GetFile()
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
