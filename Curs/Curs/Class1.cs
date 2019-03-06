using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs
{
    class Class1
    {
        static public string Operatia_XOR(string peremen1, string peremen3)
        {
            int z = Convert.ToInt32(peremen1) ^ Convert.ToInt32(peremen3);
            return Convert.ToString(z);
        }
        static public string Operatia_OR(string peremen1, string peremen3)
        {
            int z = Convert.ToInt32(peremen1) | Convert.ToInt32(peremen3);
            return Convert.ToString(z);
        }
        static public string Operatia_AND(string peremen1, string peremen3)
        {
            int z = Convert.ToInt32(peremen1) & Convert.ToInt32(peremen3);
            return Convert.ToString(z);
        }
        static public string Operatia(string peremen1, string peremen2, string peremen3)
        {
            int ERROR = 0;
            string result = "";
            if (peremen1 != "" & peremen2 != "" & peremen3 != "")
            {
                for (int i = 0; i < peremen1.Length; i++)
                {
                    if (peremen1[i] == '0' | peremen1[i] == '1' | peremen1[i] == '2' | peremen1[i] == '3' | peremen1[i] == '4' | peremen1[i] == '5' | peremen1[i] == '6' | peremen1[i] == '7' | peremen1[i] == '8' | peremen1[i] == '9' | peremen1[i] == '.')
                    {

                    }
                    else
                    {
                        ERROR++;
                    }
                }
                for (int i = 0; i < peremen2.Length; i++)
                {
                    if (peremen2[i] == '+' | peremen2[i] == '|' | peremen2[i] == '^' | peremen2[i] == '&')
                    {

                    }
                    else
                    {
                        ERROR++;
                    }
                }
                for (int i = 0; i < peremen3.Length; i++)
                {
                    if (peremen3[i] == '0' | peremen3[i] == '1' | peremen3[i] == '2' | peremen3[i] == '3' | peremen3[i] == '4' | peremen3[i] == '5' | peremen3[i] == '6' | peremen3[i] == '7' | peremen3[i] == '8' | peremen3[i] == '9' | peremen3[i] == '.')
                    {

                    }
                    else
                    {
                        ERROR++;
                    }
                }
                if (ERROR == 0)
                {
                    int x, y, z;
                    string znak = "";
                    x = Convert.ToInt32(peremen1);
                    y = Convert.ToInt32(peremen3);
                    z = 0;
                    znak = peremen2;
                    if (znak == "|") result = Operatia_OR(peremen1, peremen3);
                    else
                    if (znak == "^") result = Operatia_XOR(peremen1, peremen3);
                    else
                    if (znak == "&") result = Operatia_AND(peremen1, peremen3);
                }
                else
                {
                    MessageBox.Show("Некоректный ввод значений");
                    ERROR = 0;
                }
            }
            else
            {
                MessageBox.Show("Недопустимость пустых операндов");
            }

            return result;
        }
    }
}
