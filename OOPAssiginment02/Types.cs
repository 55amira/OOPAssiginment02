﻿using OOPAssiginment02.inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssiginment02
{
    internal class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeA");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}"); 
        }
    }

    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        public override void Fun02()
        {
            Console.WriteLine($" A : {A}  B : {B}");
        }
    }

    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeC");
        }

        public override void Fun02()
        {
            Console.WriteLine($" A : {A}  B : {B}  C : {C} ");
        }
    }

    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeD");
        }

        public virtual new void Fun02()
        {
            Console.WriteLine($" A : {A}  B : {B}  C : {C} D {D}");
        }
    }

    internal class TypeE : TypeD
    {
        public int E { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeE");
        }

        public override void Fun02()
        {
            Console.WriteLine($" A : {A} , B : {B}  , C : {C} , D {D} , E {E}");
        }
    }

}



