using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIRSTPROJECT
{
    class EmpAddress
    {
        public int _House_no;
        public string _City;
        public string _District;
        public int _PinCode;

        public EmpAddress(int Hno,string city,string district,int pincode)
        {
            this._House_no = Hno;
            this._City = city;
            this._District = district;
            this._PinCode = pincode;
        }
    }
    class Employeee
    {
        public int _Id;
        public string _Name;
        public string _Desigination;
        public EmpAddress _Address; //HAS-A Relationship

        public Employeee(int id,string name,string desigination,EmpAddress address)
        {
            this._Id = id;
            this._Name = name;
            this._Desigination = desigination;
            this._Address = address;
        }
        public void display()
        {
            Console.WriteLine("Employeee ID - "+this._Id);
            Console.WriteLine("Name - "+this._Name);
            Console.WriteLine("Desigination - " + this._Desigination);
            Console.WriteLine("Address - " + _Address._House_no +" "+_Address._City+" "+_Address._District+" "+_Address._PinCode);
        }
    }
     class Aggregation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee details______");
            Console.WriteLine("Enter Employee Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter Desigination");
            string desigination=Console.ReadLine();
            Console.WriteLine("Enter House No");
            int hno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter City");
            string city=Console.ReadLine();
            Console.WriteLine("Enter District");
            string district=Console.ReadLine();
            Console.WriteLine("Enter Pincode");
            int pincode=Convert.ToInt32(Console.ReadLine());
            EmpAddress empadd = new EmpAddress(hno,city,district,pincode);
            Employeee emp1 = new Employeee(id,name,desigination,empadd);
            Console.WriteLine();
            Console.WriteLine(".....................................................");
            Console.WriteLine("Employee Details are : ");
            emp1.display();

        }
    }
}
