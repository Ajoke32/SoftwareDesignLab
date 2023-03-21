using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Builder
{
    internal interface IBuilder
    {
        public IBuilder AddWeapon(string weapon);

        public IBuilder AddArmor(int points);

        public IBuilder AddHairColor(string color);

        public IBuilder AddClothes(string clothesName);

        public IBuilder AddDamage(int damage);

        public IBuilder AddLifeTime(int lifetime);

    }
}
