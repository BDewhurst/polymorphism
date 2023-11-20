using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class M3:Bmw {

        public M3(string color, int hp, string model):base(color, hp, model) {
            this.Model = model;
        }
    public sealed override void Repair() {
        base.Repair();
    }
    }
}