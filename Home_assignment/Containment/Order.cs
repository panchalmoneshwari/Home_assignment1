using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Containment
{
    class Order
    {
        int order_id;
        string order_date;
        Customer c = new Customer();
        Item i = new Item();

        public Order()
        {

        }

        public Order(int order_id, string order_date, Customer c, Item i)
        {
            this.Order_id = order_id;
            this.Order_date = order_date;
            this.C = c;
            this.I = i;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public string Order_date { get => order_date; set => order_date = value; }
        public Customer C { get => c; set => c = value; }
        public Item I { get => i; set => i = value; }
    }
    class Customer
    {
        int customer_id;
        string customer_name;
        Adress a = new Adress();

        public Customer()
        {

        }

        public Customer(int customer_id, string customer_name, Adress a)
        {
            this.Customer_id = customer_id;
            this.Customer_name = customer_name;
            this.A = a;
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        internal Adress A { get => a; set => a = value; }
    }
    class Adress
    {
        string street, city;
        long mobile_no;

        public Adress()
        {

        }

        public Adress(string street, string city, long mobile_no)
        {
            this.Street = street;
            this.City = city;
            this.Mobile_no = mobile_no;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public long Mobile_no { get => mobile_no; set => mobile_no = value; }
    }
    class Item
    {
        string item_name;
        int quantity,cost;
        
        public Item()
        {

        }

        public Item(string item_name, int quantity, int cost)
        {
            this.Item_name = item_name;
            this.Quantity = quantity;
            this.Cost = cost;
        }

        public string Item_name { get => item_name; set => item_name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Cost { get => cost; set => cost = value; }
    }
    class Order_info
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.Order_date = "10-04-2022";
            Console.WriteLine("Order date="+o.Order_date);
            o.Order_id = 1234;
            Console.WriteLine("Order ID="+o.Order_id);
            o.C.Customer_id = 2121;
            Console.WriteLine("Customre ID="+o.C.Customer_id);
            o.C.Customer_name = "krishnapriya";
            Console.WriteLine("customer_name=" + o.C.Customer_name);
            o.C.A.Street = "xyz road";
            Console.WriteLine("Street name=" + o.C.A.Street);
            o.C.A.City = "Pune";
            Console.WriteLine("City name" + o.C.A.City);
            o.C.A.Mobile_no = 9876543212;
            Console.WriteLine("Mobile_no " + o.C.A.Mobile_no);
            o.I.Item_name = "Vej_thali";
            Console.WriteLine("Item_name=" + o.I.Item_name);
            o.I.Quantity = 1;
            Console.WriteLine("Quantity =" + o.I.Quantity);
            o.I.Cost = 120;
            Console.WriteLine("Bill="+o.I.Cost);

            Console.ReadLine();



        }

    }
}
