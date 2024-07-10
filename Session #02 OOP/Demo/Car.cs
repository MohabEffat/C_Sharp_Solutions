using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Car
    {
        // Attribute
        // Property
        // Method
        // Event
        public int Id { get; set; }
        public string Model { get; set; }
        public int CurrentSpeed { get; set; }
        public Car()
        {
            
        }
        public Car(int id, string model, int currentSpeed)
        {
            Id = id;
            Model = model;
            CurrentSpeed = currentSpeed;
        }
        public Car(int id, string model) : this (id, model, 300)
        {
            //Id = id;
            //Model = model;
        }
        public Car(int id) : this(id , "BYD")
        {
            //Id = id;
        }
    }
}
