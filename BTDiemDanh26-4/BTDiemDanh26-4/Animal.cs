using System;
using System.Collections.Generic;
using System.Text;

namespace BTDiemDanh26_4
{
    public abstract class Animal
    {
        public abstract void eat();
        public abstract void makeSound();
    }
    class Cat : Animal
    {
        public override void eat() { }
        public override void makeSound() { }
        public void run() { }
    }
    class Brid : Animal
    {
        public override void eat() {}
        public override void makeSound() {}
        public void fly() {}
    }
}
