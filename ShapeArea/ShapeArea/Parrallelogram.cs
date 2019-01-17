using System;
using System.Collections.Generic;
using System.Text;

﻿

namespace Parrallelogram
    {
        class Parrallelogram
        {
            double Base;
            double Height;

            public void setBase(double Base)
            {
                this.Base = Base;
            }

            public double getBase()
            {

                return Base;
            }

            public void setHeight(double Height)
            {
                this.Height = Height;
            }

            public double getHeight()
            {

                return Height;
            }

            public void setDimensions(double Base, double Height)
            {
                this.Height = Height;
                this.Base = Base;
            }


            public void CalculateArea()
            {

                Console.WriteLine(this.Base * this.Height);
            }

        }
    }
    

   