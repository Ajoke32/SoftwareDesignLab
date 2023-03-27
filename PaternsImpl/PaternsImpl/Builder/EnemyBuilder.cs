using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Builder
{
    internal class EnemyBuilder : IBuilder
    {
        private EnemyExample _life = new EnemyExample();

        private void _reset()
        {
            _life = new EnemyExample();
        }

        public EnemyBuilder()
        {
            _reset();
        }
        public EnemyExample GetLife()
        {
            EnemyExample life = _life;
            _reset();
            return life;
        }
        public IBuilder AddWeapon(string weapon)
        {
            _life.SetWeapon(weapon);
            return this;
        }

        public IBuilder AddArmor(int points)
        {
            _life.SetArmorPoints(points);
            return this;
        }

        public IBuilder AddHairColor(string color)
        {
            _life.HairColor = color;
            return this;
        }

        public IBuilder AddClothes(string clothesName)
        {
            _life.SetInventory(clothesName);
            return this;
        }

        public IBuilder AddDamage(int damage)
        {
            _life.SetDamage(damage);
            return this;
        }

        public IBuilder AddLifeTime(int lifetime)
        {
            _life.SetLifeTime(lifetime);
            return this;
        }
    }
}
