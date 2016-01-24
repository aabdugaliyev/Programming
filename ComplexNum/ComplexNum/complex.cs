using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    class complex
    {
        public int a, b;
        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public complex Add(complex c)
        {
            int sum = 0;

            if (this.b % c.b == 0 && this.b > c.b)
            {
                sum = this.b;
            }
            if (c.b % this.b == 0 && c.b > this.b)
            {
                sum = c.b;
            }
            if (this.b % c.b == 0 || c.b % this.b == 0)
            {
                sum = this.b * c.b;
            }

            if (this.b % c.b != 0 && this.b > c.b)
            {
                int t = this.b * c.b;
                for (int i = 0; i < t; i++)
                {
                    if (i % this.b == 0 && i % c.b == 0)
                    {
                        sum = i;
                    }
                    else
                    {
                        sum = t;
                    }
                }
            }
            if (c.b % this.b != 0 && c.b > this.b)
            {
                int t = this.b * c.b;
                for (int i = 0; i < t; i++)
                {
                    if (i % this.b == 0 && i % c.b == 0)
                    {
                        sum = i;
                    }
                    else
                    {
                        sum = t;
                    }
                }
            }
            if (this.b == c.b || c.b == this.b)
            {
                sum = this.b;
            }
            int upsum;
            upsum = (this.a * (sum / this.b)) + (c.a * (sum / c.b));
            complex res = new complex(upsum, sum);

            for (int i = 2; i <= (res.a * res.b); i++)
            {
                if (res.a % i == 0 && res.b % i == 0)
                {
                    res.a = res.a / i;
                    res.b = res.b / i;
                    i = 2;
                }
            }
            return res;
        }


        public override string ToString()
        {
            return a + "/" + b;
        }

        public static complex change(string s)
        {
            int custom = s.IndexOf("/");
            string podstring1 = s.Substring(0, custom);
            string podstring2 = s.Substring(custom + 1);
            int pod1 = int.Parse(podstring1);
            int pod2 = int.Parse(podstring2);
            complex podcomplex = new complex(pod1, pod2);
            return podcomplex;
        }
        public static complex operator +(complex c1, complex c2)
        {
            complex c3 = c1.Add(c2);
            return c3;
        }


    }
}
