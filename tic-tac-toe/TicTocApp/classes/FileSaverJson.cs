using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using System.Reflection;
using TicTocApp.interfaces;

namespace TicTocApp.classes
{
    internal class FileSaverJson
    {
        public string Path { get; set; } = Directory.GetCurrentDirectory() + "/GameState.json";

        private  IGameState _gameState;

        public FileSaverJson(GameStateFactory stateFactory)
        {
            _gameState = stateFactory.GetGameState();
        }
        public bool SaveFile()
        {
            var savedata = JsonSerializer.Serialize(_gameState, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(Path, savedata);
            Console.WriteLine("Game saved!");
            return true;
        }

        public bool LoadFile()
        {
            if (!File.Exists(Path))
            {
                return false;
            }
            string data = File.ReadAllText(Path);
            var result = JsonSerializer.Deserialize<GameState>(data);
            if (result == null)
            {
                return false;
            }

            var resultProps = result.GetType().GetProperties();

            var gameStateProps = _gameState.GetType().GetProperties();

            foreach (var prop in resultProps)
            {
                var info = gameStateProps.FirstOrDefault(p => p.Name == prop.Name);
                if (info != null)
                {
                    info.SetValue(_gameState, prop.GetValue(result));
                }
            }

            return true;
        }
    }
}
