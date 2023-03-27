using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsImpl.Builder
{
    internal class BuilderDirector
    {
        private IBuilder _builder;

        public BuilderDirector SetBuilder(IBuilder builder)
        {
            _builder= builder;
            return this;
        }

        public BuilderDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public HeroExample GetHeroBasicSet()
        {
            HeroBuilder heroBuilder = (HeroBuilder)_builder;
            heroBuilder.AddArmor(100)
                .AddClothes("pants, Naruto cape, glasses from the Matrix")
                .AddWeapon("laser sword")
                .AddHairColor("black").AddLifeTime(90).AddDamage(20);

            return heroBuilder.GetPersonality();
        }

        public EnemyExample GetEnemyBasicSet()
        {
            EnemyBuilder enemyBulider =  (EnemyBuilder) _builder;
           
            enemyBulider.AddWeapon("gans, rockets, evniroment, animals")
                .AddArmor(1000000000)
                .AddHairColor("Not exist")
                .AddClothes("gren trees, blue heavens").AddLifeTime(1000000000).AddDamage(100);
            return enemyBulider.GetLife();
        }
    }
}
