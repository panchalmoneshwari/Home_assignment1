using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_assignment.Containment
{
    class Student
    {
        string sname;
        int rollno;
        float percent;
        Batch b1 = new Batch();
        Address a1 = new Address();

        public Student()
        {

        }

        public Student(string sname, int rollno, float percent, Batch b1, Address a1)
        {
            this.Sname = sname;
            this.Rollno = rollno;
            this.Percent = percent;
            this.B1 = b1;
            this.A1 = a1;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Rollno { get => rollno; set => rollno = value; }
        public float Percent { get => percent; set => percent = value; }
        public Batch B1 { get => b1; set => b1 = value; }
        public Address A1 { get => a1; set => a1 = value; }
    }
    class Batch
    {
        string sub;
        string batchname;

        public Batch()
        {

            }

        public Batch(string Sub, string Batchname)
        {
            this.Sub = sub;
            this.Batchname = batchname;
        }

        public string Sub { get => sub; set => sub = value; }
        public string Batchname { get => batchname; set => batchname = value; }
    }
    class Address
    {
        string street;
        int pincode;
        public Address()
        {

        }

        public Address(string street, int pincode)
        {
            this.Street = street;
            this.Pincode = pincode;
        }

        public string Street { get => street; set => street = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Studenttest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Sname = "mira";
            Console.WriteLine(s1.Sname);
            s1.Rollno = 1;
            Console.WriteLine(s1.Rollno);
            s1.Percent = 66;
            Console.WriteLine(s1.Percent);
            s1.B1.Batchname = "microsoft";
            Console.WriteLine(s1.B1.Batchname);
            s1.B1.Sub = "c#";
            Console.WriteLine(s1.B1.Sub);
            s1.A1.Street = "XYZ";
            Console.WriteLine(s1.A1.Street);
            s1.A1.Pincode = 1234;
            Console.WriteLine(s1.A1.Pincode);
            Console.ReadLine();

        }
        
    }
}
