using System;
using System.Collections;
using System.Collections.Generic;

namespace OOTPiSP
{
    public class Vector : AbstractVector
    {
        public Vector() 
        {
            Vector = new List<int>();
        }

        public Vector(List<int> list)
        {
            Vector = list;
        }

        public Vector(ref Vector copy)
        {
            Vector outObj = new Vector();
            foreach (var item in copy.Vector)
                outObj.Vector.Add(item);
        }

        ~Vector()
        {
            System.Console.WriteLine("destruction");
        }
        public override void Sort()
        {
            Vector.Sort();
        }

        public static Vector operator +(Vector obj1, Vector obj2)
        {
            Vector obj = new Vector();
            obj.Vector = new List<int>();
            for (int i = 0; i < obj1.Vector.Count; i++)
                obj.Vector.Add(obj1.Vector[i]);
            for (int i = 0; i < obj2.Vector.Count; i++)
                obj.Vector.Add(obj2.Vector[i]);
            return obj;
        }
    }
}