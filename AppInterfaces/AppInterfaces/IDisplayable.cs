//Interface - classes inheriting from the interface must have an implementation of the interfaces methods, fields
//override - to implement the version of the method declared in this class rather than the method declared in the base class
//virtual - the method CAN be implemented, it doesn't have to be

using System;

namespace AppInterfaces
{
    interface IDisplayable
    {
        void Display();
    }

}