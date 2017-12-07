using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class TriangleChecker
    {
        private double FirstSide;
        private double SecondSide;
        private double ThirdSide;
        private int precision = 15;


        public TriangleChecker(triangle t)
        {
            FirstSide = t.FirstSide1;
            SecondSide = t.SecondSide1;
            ThirdSide = t.ThirdSide1; 
        }

        public bool IsValid()
        {
            var positive = FirstSide >= 0.0 && SecondSide >= 0.0 && ThirdSide >= 0.0;
            if (positive)
            {
                var cat1 = (FirstSide > ThirdSide ? ThirdSide : FirstSide);
                var cat2 = (SecondSide > ThirdSide ? ThirdSide : SecondSide);
                var hyp = Math.Max(Math.Max(FirstSide, SecondSide), ThirdSide);

                positive = Math.Round(cat1 * cat1 + cat2 * cat2, precision) == Math.Round(hyp * hyp, precision);
            }
            return positive;
        }



    }
}
