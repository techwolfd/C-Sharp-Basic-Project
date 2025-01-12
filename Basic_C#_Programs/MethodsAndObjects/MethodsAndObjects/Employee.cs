﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // inherit of class person and interface IQuittable
    public class Employee : Person , IQuittable
    {

        //public List<Employee> empleados { get; set; }
        //public Employee()
        //{
        //    empleados = new List<Employee>();
        //}
        public int ID { get; set; }
        public string similar { get; set; }
        //override void sayname
        public override void SayName()
        {
            Console.WriteLine($"Name is:[ {FirstName } {LastName}]");

            base.SayName();
        }

        //method quit of interface IQuittable print name only
        public void Quit()
        {

            Console.WriteLine($"Name only quit emplo:[ {FirstName }]");
          
        }

        public static Employee operator ==(Employee employee1, Employee employee2)
        {


            if (employee1.ID ==employee2.ID)
            {
                Console.WriteLine("es igual");
                employee1.similar = " es igual al otro empleado";
            }

            return employee1;
            ////instance of 2 employees
            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();

            ////ids= number
            //employee1.ID = 01;
            //employee2.ID = 01;

            ////employee1.employee = new List<Employee>();

            ////comparacion de los dos objetos sobre carga
            //employee1 = employee1 == employee2;

            ////print of object employee.similar
            //Console.WriteLine("esto " + employee1.similar);
        }
        public static Employee operator !=(Employee employee1, Employee employee2)
        {

            if (employee1.ID != employee2.ID)
            {
                Console.WriteLine("no es igual");
                employee1.similar = " es igual al otro empleado";
            }
            return employee1;
        }

    }
    
}
