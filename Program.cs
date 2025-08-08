using System;

class Program
{
    static void Main(string[] args)
    {
        //Inheritance and method overloading
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound();
        myDog.MakeSound();
        myCat.MakeSound();

        //Abstract Classes and Methods
        Shape myCircle = new Circle(5);
        Shape myRectangle = new Rectangle(4, 6);
        myCircle.GetArea();
        myRectangle.GetArea();

    
    }
}