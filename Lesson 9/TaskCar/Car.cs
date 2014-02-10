using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TaskCar
{
    class Car
    {
        private string model;
        private int producedYear;
        private int mileage;
        private int volumeOfMotor;
        private int motorPower;
        private static int count;

        public Car(string model, int producedYear, int mileage, int volumeOfMotor, int motorPower)
        {
            this.model = model;
            this.ProducedYear = producedYear;
            this.mileage = mileage;
            this.VolumeOfMotor = volumeOfMotor;
            this.motorPower = motorPower;
            Car.count++;
        }


        public Car(string model)
            : this(model, 1900, 10, 1000, 30)
        {
        }

        public Car(string model, int producedYear)
            : this(model, producedYear, 10, 1000, 30)
        {
        }

        public Car(string model, int mileage, int volumeOfMotor)
            : this(model, 1900, mileage, volumeOfMotor, 30)
        {
        }

        private int ProducedYear
        {
            set 
            {
                DateTime currentDate = DateTime.Now;

                if (value < 1900)
                {
                    throw new ArgumentOutOfRangeException("The car must be prodused after 1900 year.");
                }

                if (currentDate.Year - value < 0)
                {
                    throw new ArgumentOutOfRangeException("The car can not be prodused in the future.");
                }

                this.producedYear = value; 
            }
        }

        private int VolumeOfMotor
        {
            set
            {
                if (value < 1000 || value > 5000)
                {
                    throw new ArgumentOutOfRangeException("The volume of motor car must be between 1000 and 5000.");
                }

                this.volumeOfMotor = value;
            }
        }

        public int AddMileage(int mileage)
        {
            return this.mileage += mileage;
        }

        public void PrintData()
        {
            Console.WriteLine("model = {0}", this.model);
            Console.WriteLine("producedYear = {0}", this.producedYear);
            Console.WriteLine("mileage = {0}", this.mileage);
            Console.WriteLine("volumeOfMotor = {0}", this.volumeOfMotor);
            Console.WriteLine("motorPower = {0}", this.motorPower);
        }

        public void WriteData()
        {
            try
            {
                using (StreamWriter WriteObj = File.AppendText("Car.txt"))
                {

                    WriteObj.WriteLine(this.model + "," + this.producedYear + "," + this.mileage + "," + this.volumeOfMotor + "," + this.motorPower);
                }
            }
            catch (FileNotFoundException)
            {   
                Console.WriteLine("File not found.");
            }
        }
    }
}
