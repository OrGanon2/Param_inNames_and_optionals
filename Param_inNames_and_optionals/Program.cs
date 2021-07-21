using System;

namespace Param_inNames_and_optionals
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ref and out


            #endregion

            #region params and in names and optional args
            #region first
            Console.WriteLine(caculate(5, 2, 3));
            #endregion

            #region second
            ABC(5,3,3);
            #endregion
            #region third
            ABC(a:1,c:10);
            #endregion

            #region fourth
            Console.WriteLine(function_D(3));


            #endregion
            #region fifth
            Phones p1 = new Phones();
            Phones p2 = new Phones(screensize : 7, model: "oneplus");
            Phones p3 = new Phones(camera_Pixels: 67, battery: "Lipo");
            Phones p4 = new Phones(screensize: 7, model: "oneplus nord", camera_Pixels: 62);

            #endregion

            #endregion


        }
        #region params and in names and optionals args
        #region first
        public static int caculate(params int [] nums)
        {
            int sum_num = 0;
            int mid_num = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 1; k <= i+1; k++)
                {
                    mid_num = nums[i] * mid_num;
                }
                sum_num += mid_num;
                mid_num = 1;
            }
            return sum_num;
        }

        #endregion

        #region second
        public static void ABC (int a,int b = 1,int c = -1)
        {
            Console.WriteLine(a * b * c);
        }
        #endregion
        #region third
        public static int function_D(in int num)
        {
            int multiply = num * 3;
            return multiply;
        }
        #endregion


        #endregion

       



    }
    #region fifth
    class Phones
    {
        int Screen_Size;
        string Model;
        string Battery;
        int Camera_pixels;

        public Phones(int screensize = 6, string model = "samsung", string battery = "lion", int camera_Pixels = 50)
        {
            Screen_Size = screensize;
            Model = model;
            Battery = battery;
            Camera_pixels = camera_Pixels;
        }
    }

    #endregion
}
