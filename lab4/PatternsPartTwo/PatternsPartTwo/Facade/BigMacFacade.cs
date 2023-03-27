using PatternsPartTwo.Facade.Dishes;
using PatternsPartTwo.Facade.ServItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Facade
{
    internal class BigMacFacade
    {
        private CheeseBurger _cheeseBurger;

        private ChikenBurger _chikenBureger;

        private DoubleBurger _doubleBurger;

        private Potatoes _potatoes;

        private Packing _packingService;

        private Napkings _naps;

        private Price _price;

        public BigMacFacade()
        {
            _cheeseBurger = new CheeseBurger();
            _chikenBureger =  new ChikenBurger();
            _doubleBurger = new DoubleBurger();
            _potatoes = new Potatoes();
            _packingService = new Packing();
            _naps = new Napkings();
            _price = new Price();
        }

        public void AllInclusive()
        {
            _packingService.StartPacking("green");
            Console.WriteLine($"{_cheeseBurger.Name}\n{_chikenBureger.Name}\n{_doubleBurger.Name}\n{_potatoes.Name}\n" +
                $"price:{_price.ComputeDiscount(_price.ComputePrice(4), _price.GetDiscount(4))}$, napks count:{_naps.GetForBigPortion()}");
            _packingService.Message = "(: See you later :)";
            _packingService.EndPacking("blue");
        }

        public void PotatoCheese()
        {
            _packingService.StartPacking("blue");
            Console.WriteLine($"{_potatoes.Name}\n{_cheeseBurger.Name},naps count:{_naps.ComputeForPeople(2)},price {_price.ComputePrice(2)}");
            _packingService.Message = "Have a nice day!";
            _packingService.EndPacking("green");
        }

        public void DoubleCheese()
        {
            _packingService.StartPacking("yellow");
            Console.WriteLine($"{_cheeseBurger.Name}\n{_doubleBurger.Name},naps count:{_naps.GetDefaultCout()},price {_price.ComputePrice(2)}");
            _packingService.Message = "Сome back for more!";
            _packingService.EndPacking("blue");
        }

    }
}
