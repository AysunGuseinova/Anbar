using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace anbar
{
    class Class1
    {

        public static void Pr2(double X,string ad,string q,OleDbConnection CON)
        {
                CON.Open();
                OleDbCommand emr = new OleDbCommand("update pro_a set qiymet="+X.ToString() + " , Vahid='"+ad+"' where barkod like '"+q+"'", CON);
                emr.ExecuteNonQuery();
                CON.Close();

                
            }





        public static string AAA(string T)
        {
            int Res = 0;
            bool id = false; //id  false - American   id true -European


            for (int i = 0; i < T.Length; i++)
                if (T[i] == '/') { Res++; break; }
            if (Res == 0) id = true;
            else id = false;

            if (id == false)
            {
                for (int i = 0; i < T.Length; i++)
                    if (T[i] == '/')
                    {
                        T = T.Replace('/', '.');
                    }

                int k1 = 0, k2 = 0;
                for (int i = 0; i < T.Length; i++)
                    if (T[i] == '.') { k1 = i; break; }

                string ay = T.Substring(0, k1);

                T = T.Remove(0, k1 + 1);
                //MessageBox.Show("Sonra : "+T);
                for (int i = 0; i < T.Length; i++)
                    if (T[i] == '.') k2 = i;
                string gun = T.Substring(0, k2);

                //MessageBox.Show(gun);

                if (ay.Length == 1) ay = "0" + ay;
                if (gun.Length == 1) gun = "0" + ay;
                T = gun + "." + ay + "." + DateTime.Now.Year.ToString();

            }
            return T;
        }
    }
}
