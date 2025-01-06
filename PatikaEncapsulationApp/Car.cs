﻿namespace PatikaEncapsulationApp
{
    public class Car
    {
        // Fields
        private string _brand;
        private string _model;
        private string _color;
        private int _numbersOfDoor;

        // Constructors
        public Car(string brand, string model, string color, int numbersOfDoor)
        {
            _brand = brand;
            _model = model;
            _color = color;
            _numbersOfDoor = numbersOfDoor;
        }

        // Properties
        public string Brand 
        { 
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int NumbersOfDoor
        {
            get { return _numbersOfDoor; }
            set 
            {
                if (_numbersOfDoor == 2 || _numbersOfDoor == 4)
                {
                    _numbersOfDoor = value;
                }
                else
                {
                    Console.WriteLine("Bir arabanın kapı sayısı 2 veya 4 olmalıdır!");
                    _numbersOfDoor = -1;
                }
                
            }
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Brand: {Brand} / Model: {Model} / Color: {Color} / Numbers Of Door: {NumbersOfDoor}");
        }


    }
}
