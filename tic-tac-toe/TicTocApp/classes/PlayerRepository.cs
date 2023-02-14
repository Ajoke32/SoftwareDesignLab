using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class PlayerRepository
    {
        private readonly Store _store;

        public PlayerRepository(Store store)
        {
            _store = store;
        }

        public void AddPlayer(Player player)
        {
            _store.Players.Add(player);
        }

        public Player? GetPlayerById(int id)
        {
            return _store.Players.FirstOrDefault(p => p.Id == id);
        }

        public Player? GetNextPlayerAfterId(int id)
        {
            return _store.Players.FirstOrDefault(p => p.Id != id);
        }

        public List<Player> GetAllPlayers()
        {
            return _store.Players;
        }

        public void Reverse()
        {
            _store.Players.Reverse();
        }
    }
}
