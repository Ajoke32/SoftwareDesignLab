using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Builder
{
    internal class HeroExample
    {
        private string _eyes;

        public string? HairColor { get; set; }

        public string? EyesColor { get; set; }
        private int _damage { get; set; }

        private string _invetory;

        private string _bodyType;

        private int _weight;

        private int _height;

        private string _weapon;

        private int _armor;

        private int _lifetime;

        public int GetDamage()
        {
            return _damage;
        }
        public int SetDamage(int damage)
        {
            _damage = damage;
            return damage;
        }
        public int SetHeight(int height)
        {
            _height = height;
            return height;
        }
        public string SetInventory(string inventoryName)
        {
            _invetory= inventoryName;
            return inventoryName;
        }
        public string SetBodytype(string build)
        {
            _bodyType= build;
            return build;
        }
        public string SetEyes(string eyes)
        {
            _eyes = eyes;
            return eyes;
        }
        public string SetWeapon(string weapon)
        {
            _weapon = weapon;
            return weapon;
        }
        public int SetWeight(int weight)
        {
            _weight = weight;
            return _weight;
        }

        public int SetLifeTime(int lifetime)
        {
            _lifetime = lifetime;
            return lifetime;
        }

        public int SetArmorPoints(int armor)
        {
            _armor= armor;
            return armor;
        }
    }
}
