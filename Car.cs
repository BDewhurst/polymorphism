using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism {
    class Car {
        public string Color {get; set;}
        public int HP {get; set;}

        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void SetCarIdInfo(int idNum, string owner) {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo() {
         Console.WriteLine($"The car has the ID of {carIDInfo.IDNum} and is owned by {carIDInfo.Owner}");
        }
        public Car(string color, int hp) {

            this.Color = color;
            this.HP = hp;

        }

        public void ShowDetails() {
            Console.WriteLine($"The colour of the car is {Color} and the HP is {HP}");
        }

        public virtual void Repair() {
            Console.WriteLine("The car was repaired!");
        }
    }
}