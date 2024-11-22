using System;
using System.Collections.Generic;
//
//клас Order відповідає за надто багато функцій: роботу із замовленням, відображення замовлення, а також операції збереження/завантаження.
//Щоб виправити це порушення, ми можемо розділити відповідальності класу Order на окремі класи
namespace Solid1
{
    class Item
    {
    }

    // Відповідає за логіку управління замовленням
    class Order
    {
        private List<Item> itemList;

        public Order()
        {
            itemList = new List<Item>();
        }

        public List<Item> ItemList
        {
            get { return itemList; }
        }

        public void CalculateTotalSum() { /*...*/ }
        public void GetItems() { /*...*/ }
        public void GetItemCount() { /*...*/ }
        public void AddItem(Item item) { /*...*/ }
        public void DeleteItem(Item item) { /*...*/ }
    }

    // Відповідає за виведення замовлення
    class OrderViewer
    {
        public void PrintOrder(Order order) { /*...*/ }
        public void ShowOrder(Order order) { /*...*/ }
    }

    // Відповідає за збереження/завантаження замовлень
    class OrderRepository
    {
        public void Load(Order order) { /*...*/ }
        public void Save(Order order) { /*...*/ }
        public void Update(Order order) { /*...*/ }
        public void Delete(Order order) { /*...*/ }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
