using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Containment
{
    class Flat
    {
        int flatno;
        string bname;
        Owner o1 = new Owner();

        public Flat()
        {

        }

        public Flat(int flatno, string bname, Owner o1)
        {
            this.Flatno = flatno;
            this.Bname = bname;
            this.O1 = o1;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Bname { get => bname; set => bname = value; }
        internal Owner O1 { get => o1; set => o1 = value; }
    }
    class Owner
    {
        long mobileno;
        string name;
        char gender;

        public Owner()
        {
        
         }

        public Owner(long mobileno, string name, char gender)
        {
            this.Mobileno = mobileno;
            this.Name = name;
            this.Gender = gender;
        }

        public long Mobileno { get => mobileno; set => mobileno = value; }
        public string Name { get => name; set => name = value; }
        public char Gender { get => gender; set => gender = value; }
    }

    class Flatinfo
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno = 2565;
            Console.WriteLine(f1.Flatno);
            f1.Bname = "xyz";
            Console.WriteLine(f1.Bname);
            f1.O1.Mobileno = 323456734;
            Console.WriteLine(f1.O1.Mobileno);
            f1.O1.Name = "asd";
            Console.WriteLine(f1.O1.Name);
            f1.O1.Gender = 'm';
            Console.WriteLine(f1.O1.Gender);
            Console.ReadLine();
        }
    }
}
