using System.Collections.Generic;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!
    //Очевидно порушення принципу єдиної відповідальності, оскільки наявний god object
    //Треба розділити класи по принципу єдиної відповідальності
    //Наявне порушення принципу інверсії залежності

    /*class Item
    {

    }

    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {...}
        public void GetItems() {...}
        public void GetItemCount() {...}
        public void AddItem(Item item) {...}
        public void DeleteItem(Item item) {...}

        public void PrintOrder() {...}
        public void ShowOrder() {...}

        public void Load() {...}
        public void Save() {...}
        public void Update() {...}
        public void Delete() {...}
    }*/

    interface IItem
    { 
    
    }

    class Item : IItem
    {

    }

    class Order
    {
        private List<IItem> itemList;

        internal List<IItem> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }
    }

    class OrderItemInfo //Отримання інформації про товари у замовленні
    {
        public void CalculateTotalSum(Order order) {/*...*/}

        public void GetItems(Order order) {/*...*/}

        public void GetItemCount(Order order) {/*...*/}
    }

    class OrderItemManager //Робота з товаром
    {
        public void AddItem(IItem item, Order order) {/*...*/}

        public void DeleteItem(IItem item, Order order) {/*...*/}
    }

    class GeneralOrderInfo //Повна інформація про замовлення
    {
        public void PrintOrder(Order order) {/*...*/}

        public void ShowOrder(Order order) {/*...*/}
    }

    class OrderRepository //Робота з базою даних замовлень
    {
        public void Load(Order order) {/*...*/}

        public void Save(Order order) {/*...*/}

        public void Update(Order order) {/*...*/}

        public void Delete(Order order) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
