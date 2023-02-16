using System.Collections.Generic;

namespace ASP_project
{
    public class Services
    {

            public Services()
            {

            }
            public int Sum(int x, int y)
            {
                return x + y;
            }
            public int grade(List<string> g)
            {
                if (g.Equals("Female"))
                {
                    return g.Count * 10;
                }

                return 5 * g.Count;


            }

            public string concatenate(List<string> g)
            {
                string s = "";

                for (var i = 0; i < g.Count; i++)

                {
                    s += g[i].ToString() + "I";

                }
                return s;
            }
            public bool validateEmail(string e1,string e2)
            {
                if (e1.Equals(e2))
                {
                    return true;
                }
                return false;

            }

        }
    }

