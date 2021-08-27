using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Model
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(int id, string name,string address, int age)
        {
            this.Id = id; this.Name = name; this.Adress = address; this.Age = age;
           
        }
    }

  
}
