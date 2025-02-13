﻿using System;

namespace TestMistake
{
   interface IControl
    {
        void Paint();
    }
    interface ISurface
    {
        void Paint();
    }
    class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method. 
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
    class Test
    {
        static void Main()
        {
            SampleClass sc = new SampleClass();

            IControl ctrl = sc;
            ISurface srfc = sc;

            // The following lines all call the same method.
            sc.Paint();
            ctrl.Paint();
            srfc.Paint();
        }
    }
}
