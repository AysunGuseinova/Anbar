using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace anbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string AD;


        public void goster(string w)
        {
            con.Open();
            da = new OleDbDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[1].Width = dataGridView1.Columns[0].Width + 50;
            con.Close();


            DataColumn Meb = new DataColumn();
            Meb.DataType = System.Type.GetType("System.Decimal");
            Meb.ColumnName="Mebleg";
            Meb.Expression = "qiymet*miqdar";
            ds.Tables[0].Columns.Add(Meb);



            DataColumn Vergi= new DataColumn();
            Vergi.DataType = System.Type.GetType("System.Decimal");
            Vergi.ColumnName = "Vergi";
            Vergi.Expression = "qiymet*miqdar*0.18";
            ds.Tables[0].Columns.Add(Vergi);

            
            
        }


        public int say(string w)
        {
            con.Open();
            da=new OleDbDataAdapter(w,con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            return (ds.Tables[0].Columns.Count);
        }


        public
            OleDbConnection con= new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Seymur\\Desktop\\Base_1\\d1.mdb");
        OleDbCommand com;
        OleDbDataAdapter da;
        string barkod, mal,Tarix;
        double qiy, vergi, meb, miq;
        int k;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd1DataSet.pro_a' table. You can move, or remove it, as needed.
           // this.pro_aTableAdapter.Fill(this.d1DataSet.pro_a);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView1.Width = this.Width - dataGridView1.Left - 35;
            
            goster("Select* from pro_a");

        }

        private void malinHereketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (button1.Text == "Giris") 
            {
                con.Open();
                groupBox1.Visible = true;
                com = new OleDbCommand("Insert into pro_a(Barkod,mal,Tarix,qiymet,miqdar)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();
            }

           if (button1.Text == "Cixis")
            {
                int Miq = 0;
                con.Open();
                groupBox1.Visible = true;
               
               OleDbDataAdapter da = new OleDbDataAdapter("select* from  pro_a  where barkod like '" + textBox1.Text + "'", con);
               DataSet ds = new DataSet();
               da.Fill(ds); 
               con.Close();

                Miq = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                if (Miq >= Convert.ToInt32(textBox5.Text))
                {
                    // MessageBox.Show(Miq.ToString());
                    con.Open();
                    groupBox1.Visible = true;
                    Miq -= Convert.ToInt32(textBox5.Text);
                    com = new OleDbCommand("update  pro_a set miqdar = " + Miq + " where barkod like '" + textBox1.Text + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                else MessageBox.Show("O qeder mal yoxdur!");
            }

 
            goster("Select* from pro_a");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

          
        }

        private void girisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button1.Text = "Giris";
            groupBox2.Visible = false;
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            button1.Text = "Cixis";
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }

        private void barkodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goster("Select* from pro_a where Barkod like '" + textBox8.Text+ "'");
            textBox8.Clear();
            
        }

        private void tarixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goster("Select* from pro_a where Tarix like '" + textBox8.Text+ "'");
            textBox8.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            goster("Select* from pro_a ");

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 8) || (e.KeyChar >= '0' && e.KeyChar <= '9'))
                textBox1.ReadOnly = false;
            else textBox1.ReadOnly = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox1.TextLength == 0) MessageBox.Show("Empty");
                else textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar == 8))
                textBox2.ReadOnly = false;
            else textBox2.ReadOnly = true;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox2.TextLength == 0) MessageBox.Show("Empty");
                else textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')|| (e.KeyChar == '.') || (e.KeyChar == 8))
               textBox3.ReadOnly = false;
          else textBox3.ReadOnly = true;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyValue == 13)
            {
                if (textBox3.TextLength == 0) MessageBox.Show("Empty");
                else textBox4.Focus();

            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9')|| (e.KeyChar == '.') || (e.KeyChar == 8))
                textBox4.ReadOnly = false;
            else textBox4.ReadOnly = true;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox4.TextLength == 0) MessageBox.Show("Empty");
                else textBox5.Focus();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == '.') || (e.KeyChar == 8))
                textBox5.ReadOnly = false;
            else textBox5.ReadOnly = true;
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (textBox5.TextLength == 0) MessageBox.Show("Empty");
                else textBox6.Focus();

            }
        }

        private void fromBaseToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo F = new System.IO.FileInfo(Application.StartupPath + "\\proyekt.txt");
            System.IO.StreamWriter sw;
            con.Open();
            string S = "";
            OleDbDataAdapter da = new OleDbDataAdapter("Select* from pro_a", con);
            DataSet ds= new DataSet();
            da.Fill(ds);
            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (F.Exists) sw = F.AppendText();
                else sw=F.CreateText();
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    S = S + ds.Tables[0].Rows[i].ItemArray[j].ToString() + "-";
                }
                sw.WriteLine(S);
                S = "";
                sw.Close();

            }
        }

        private void fromFileToBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string S = "", R = "", P = "";
            int i = -1;
            string[]mas;
            int N = say("Select* from pro_a");
            mas = new string[N + 1];
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                System.IO.FileInfo F = new System.IO.FileInfo(openFileDialog1.FileName);
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName,System.Text.Encoding.GetEncoding(1251));
                while (((S = sr.ReadLine()) != null) || ((S=sr.ReadLine())!=""))
                {
                    if (S != "")
                    {
                        i = -1;
                        for (int k = 0; k < S.Length; k++)
                            if (S[k] != '-') R += S[k];
                            else { i++; mas[i] = R; R = ""; }
                        for (k = 0; k < N; k++)
                            if (k < N - 1) P += mas[k] + "','";
                            else P += mas[k];
                       // MessageBox.Show("Insert into pro_a(Barkod,mal,Tarix,qiymet,miqdar)values('" + P + "')");
                        con.Open();
                        com = new OleDbCommand("Insert into pro_a(Barkod,mal,Tarix,qiymet,miqdar)values('" + P + "')", con);
                        com.ExecuteNonQuery();
                        con.Close();
                        P = "";
                    }
                } sr.Close();
                goster("Select* from pro_a");

              
            }

        }

        private void uSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            AD = "USD";
            string t =Class1.AAA(DateTime.Now.ToShortDateString());
            con.Open();
            da =new OleDbDataAdapter("select* from Exch where ad like 'USD' and Tarix like '"+t+"'",con);
           DataSet   ds = new DataSet();
            da.Fill(ds);
            con.Close();


     textBox9.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
      textBox10.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                string Q = dataGridView1[0, i].Value.ToString();
                double x = Convert.ToDouble(dataGridView1[3, i].Value.ToString());
                if (radioButton2.Checked)
                    x /= Convert.ToDouble(textBox10.Text);

                if (radioButton1.Checked)
                {
                    AD = "AZN";
                    x *= Convert.ToDouble(textBox9.Text);
                }


                Class1.Pr2(x, AD,Q, con);
            }
                goster("select* from pro_a");

            
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void eUROToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            textBox9.Text = "1.9020";
            textBox10.Text = "1.9030";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new OleDbCommand("delete from pro_a",con);
            com.ExecuteNonQuery();
            con.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
           con.Open();
           com = new OleDbCommand("select sum(qiymet) from pro_a",con);//AVG  Min  Max  Count
           double  X = Convert.ToDouble(com.ExecuteScalar());
           con.Close(); MessageBox.Show(X.ToString());
        }

  
    }
}
