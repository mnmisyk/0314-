using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类与对象
{
  public  class Person
    {
        private string _name;
        public string name
        {
            //输出属性的时候，会执行get方法
            get {
                if(_name!="abc"&& _name !="cba")
                    {
                    return "CNM";
                    }

                return _name;
            }
            //给属性赋值，首先执行set
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }

            set {
                  if(value<0 || value>100)
                  {
                      value = 0;
                   }
                _age = value;
                 }
        }
        public void CHLSS()
        {
            Console.WriteLine("my name is {0},and my age is {1}",this.name,this.Age);
        }
    }
}
