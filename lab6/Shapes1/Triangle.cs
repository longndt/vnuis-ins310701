﻿using Shapes1;
using System;
namespace Shapes1
{
    public class Triangle : Shape, IPointy
    {
        public Triangle()
        {
        }
        public Triangle(string name) : base(name)
        { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle.", PetName);
        }
        public int Points
        {
            get
            {
                return 3;
            }
        }
    }
}
