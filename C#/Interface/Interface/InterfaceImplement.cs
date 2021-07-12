using System;

class InterfaceImplementer : IMyInterface {
    public void MethodToImplement() {
        Console.WriteLine("MethodToImplement() called.");
    }

    static void Main() {
        InterfaceImplementer iImp = new InterfaceImplementer();
        iImp.MethodToImplement();
    }
}