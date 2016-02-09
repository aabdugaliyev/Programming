using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigInteger
{
    class Bint
    {
        public int k;
        public int[] num = new int[100];
        public int j = 0;
        int len = 0;
        public Bint(string s)
        {
            this.len = s.Length;
            for (int i = len - 1, k = 0; i >= 0; i--, k++)
            {
                num[i] = s[k] - '0';
            }    
        }
        
        public static Bint operator +(Bint b1, Bint b2)
        {
            int k = 0;
            Bint b = new Bint("");
            for (int i = 0; i < Math.Max(b1.len, b2.len); i++)
            {
                /*b.num1[i] = b1.num1[i] + b2.num1[i] + k;
                k = b.num1[i] / 10;
                b.num1[i] = b.num1[i] % 10;*/
                b.num[i] = b1.num[i] + b2.num[i];


                if ((b.num[i] + k) > 9)
                {
                    k = b.num[i] / 10;
                    b.num[i] = b.num[i] % 10;
                }
                if ((b.num[i] + k) < 10)
                {
                    b.num[i] = b.num[i] + k;
                    k = 0;
                }
            }
            return b;
        }

        string str;
        public string to_string(Bint b){
            for (int i = 0; i < b.num.Length; i++)
            {
                //string str = string.Parse();
                
                str = str += Bint.b.num[i];          
            }
                return str;
        }
        
        
        
        
        
        
        //Bint sum = new Bint(b);
        public override string ToString()
        {
            return ;
        }
        

    }
}
