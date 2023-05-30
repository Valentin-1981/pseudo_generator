using System;

namespace consoletestproject
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            DateTime time = DateTime.Now;
            String time_string = time.ToString();
            Console.WriteLine(time_string);
            long offset = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            String offset_string = offset.ToString();
            Console.WriteLine(offset);
            Console.WriteLine(offset_string);
            int length = offset_string.Length;
            Console.WriteLine(length);
            String sub_str = offset_string.Substring(7);
            Console.WriteLine(sub_str);
            Int32 randomize_timer = Convert.ToInt32(sub_str);
            int[] rand = new int[7];
            for(int schet2 = 0; schet2 < 7; schet2++)
            {
                rand[schet2] = randomize_timer * (schet2 + 2);
            }
            /*Int32 rand_2 = randomize_timer * 2;
            Int32 rand_3 = randomize_timer * 3;
            Int32 rand_4 = randomize_timer * 4;
            Int32 rand_5 = randomize_timer * 5;
            Int32 rand_6 = randomize_timer * 6;
            Int32 rand_7 = randomize_timer * 7;
            Int32 rand_8 = randomize_timer * 8;*/
            int x = 0;
            //Console.WriteLine(rand_2);

            for(int schet = 0; schet < 7; schet++)
            {
                x = Rand_func(rand[schet]);
                sub_str += x.ToString();
            }


            Console.WriteLine("sum:");
            Console.WriteLine(x);
            Console.WriteLine(sub_str);


        }

        public static int Rand_func(int random)
        {
            string str = random.ToString();
            int length = str.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                String digit = str[i].ToString();
                Console.WriteLine(digit);
                int digit_int = Convert.ToInt32(digit);

                Console.WriteLine(digit_int);
                sum += digit_int;
            }
         
            /*if(sum == 10) { sum = 0; return sum; }
            if(sum == 11) { sum = 1; return sum; }
            int sum_length = sum.ToString().Length;
            while(sum.ToString().Length >= 2)
            {
                for (int i = 0; i < sum_length; i++)
                {
                    
                    // nb
                                       

                    String digit_sum = sum.ToString();
                    String digit_sum_i = digit_sum[i].ToString();
                    Console.WriteLine(digit_sum_i);
                    int digit_int_sum = Convert.ToInt32(digit_sum_i);

                    Console.WriteLine(digit_int_sum);
                    sum += digit_int_sum;
                }
            }*/

            return sum;
        }
    }
}
