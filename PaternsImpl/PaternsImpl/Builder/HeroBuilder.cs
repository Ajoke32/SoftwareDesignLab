using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Builder
{

    internal class HeroBuilder : IBuilder
    {
        private HeroExample _pers = new HeroExample();
        private void _reset()
        {
            _pers =  new HeroExample();
        }

        public HeroExample GetPersonality()
        {
            HeroExample pers = _pers;
            _reset();
            return pers;
        }
        public IBuilder AddWeapon(string weapon)
        {
            _pers.SetWeapon(weapon);
            return this;
        }

        public IBuilder AddArmor(int points)
        {
            _pers.SetArmorPoints(points);
            return this;
        }

        public IBuilder AddHairColor(string color)
        {
            _pers.HairColor = color;
            return this;
        }

        public IBuilder AddClothes(string clothesName)
        {
            _pers.SetInventory(clothesName);
            return this;
        }
        public IBuilder AddDamage(int damage)
        {
            _pers.SetDamage(damage);
            return this;
        }

        public IBuilder AddLifeTime(int lifetime)
        {
            _pers.SetLifeTime(lifetime);
            return this;
        }
        public HeroBuilder()
        {
            _reset();
        }
  
    }
}
