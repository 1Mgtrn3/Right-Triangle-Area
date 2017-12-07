using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangleLib
{

    
    public class triangle
    {
        private double FirstSide;
        private double SecondSide;
        private double ThirdSide;

        public triangle(double first, double second, double third )
        {
            FirstSide = first;
            SecondSide = second;
            ThirdSide = third;
        }

        public double FirstSide1 { get => FirstSide; set => FirstSide = value; }
        public double SecondSide1 { get => SecondSide; set => SecondSide = value; }
        public double ThirdSide1 { get => ThirdSide; set => ThirdSide = value; }

        public double GetArea(){
            
                var p = (FirstSide + SecondSide + ThirdSide) * 0.5; 
                return Math.Sqrt(p * (p - FirstSide) * (p - SecondSide) * (p - ThirdSide));
            
        }

    }
}
