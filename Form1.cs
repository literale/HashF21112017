using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashF21112017
{
    public partial class Form1 : Form
    {
        MyHash myHash = new MyHash(301);
        int w0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            int W = dataGridView1.Width;
            w0 = W;
            dataGridView1.Columns.Add("Номер", "Номер");
            dataGridView1.Columns["Номер"].Width = W / 8;
            dataGridView1.Columns["Номер"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add( "Телефон", "Телефон");
            dataGridView1.Columns["Телефон"].Width = W / 4;
            dataGridView1.Columns["Телефон"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns["Фамилия"].Width = 5*W / 8;
            dataGridView1.AllowUserToAddRows = false;
            btnAdd.Visible = false;
            btnDel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void ShowHash()
        {
            for (int i = 0; i<myHash.sizeTable; i++)
                if(myHash.h[i].listInfo.Count>0)
                {
                    dataGridView1[1, i].Value = myHash.h[i].listInfo[0].phone;
                    dataGridView1[2, i].Value = myHash.h[i].listInfo[0].fio;
                    if (myHash.h[i].listInfo.Count >1)
                    {
                        for (int j = 1; j < myHash.h[i].listInfo.Count; j++)
                        {

                            dataGridView1.Columns.Add("Телефон", "Телефон");
                            dataGridView1.Columns["Телефон"].Width = w0 / 4;
                            dataGridView1.Columns["Телефон"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView1.Columns.Add("Фамилия", "Фамилия");
                            dataGridView1.Columns["Фамилия"].Width = 5 * w0 / 8;
                            

                                dataGridView1[j*2+1, i].Value = myHash.h[i].listInfo[0].phone;
                                dataGridView1[j*2+2, i].Value = myHash.h[i].listInfo[0].fio;
                        }
                    }
                }
        }
        void FillHashTable()
        {

            FileStream file = new FileStream("phoneBook.txt", FileMode.Open);
            StreamReader strReader = new StreamReader(file);
            dataGridView1.RowCount = myHash.sizeTable;
            string fio, phone;
            for (int i = 0; i < myHash.sizeTable; i++)
                dataGridView1[0, i].Value = Convert.ToString(i);
            while( ( (fio=strReader.ReadLine()) !=null) && ((phone = strReader.ReadLine())!=null) )
                {
                myHash.AddHash(fio, phone);
            }
            strReader.Close();
        }
        void FileCreate()
        {
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string phone, fio = tbFio.Text;
            if (fio == "")
                lbComment.Text = "Введите имя и фамилию абонента";
            else
            {
                int adrlist = myHash.FindHash(fio, out phone);
                int adr = myHash.hashKey(phone);
                if (adr > -1)
                {
                    tbPhone.Text = phone;
                    dataGridView1.Rows[adr].Selected = true;
                    if(adrlist == 0)
                    dataGridView1.FirstDisplayedCell = dataGridView1[0, adr];
                    if (adrlist == 1)
                        dataGridView1.FirstDisplayedCell = dataGridView1[3, adr];
                    if (adrlist >1)
                        dataGridView1.FirstDisplayedCell = dataGridView1[adrlist*2+1, adr];
                    lbComment.Text = "";
                }
                else
                    lbComment.Text = "Абонент не найден";

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbFio.Text!=""&&tbPhone.Text!="")
            {
                int adr = myHash.AddHash(tbFio.Text, tbPhone.Text);
                
                int adrlist;
                
                for (adrlist = 0; adrlist<myHash.h[adr].listInfo.Count; adrlist++ )
                {
                    if (myHash.h[adr].listInfo[adrlist].phone == tbPhone.Text)
                    {
                        break;
                    }
                }
              //  int adrlist = myHash.FindHash(tbFio.Text, out phone);
                lbComment.Text = "Абонент " + tbFio.Text.ToString() + " добавлен";
                if (adrlist == 0)
                {
                    dataGridView1[2, adr].Value = tbFio.Text.ToString();
                    dataGridView1[1, adr].Value = tbPhone.Text.ToString();
                    dataGridView1.Rows[adr].Selected = true;
                    dataGridView1.FirstDisplayedCell = dataGridView1[0, adr];
                }

                if (adrlist > 0)
                {
                    if (adrlist > count)
                    {
                        dataGridView1.Columns.Add("Телефон", "Телефон");
                        dataGridView1.Columns["Телефон"].Width = w0 / 4;
                        dataGridView1.Columns["Телефон"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns.Add("Фамилия", "Фамилия");
                        dataGridView1.Columns["Фамилия"].Width = 5 * w0 / 8;
                        count++;
                    }
                    dataGridView1[adrlist*2+2, adr].Value = tbFio.Text.ToString();
                    dataGridView1[adrlist*2+1, adr].Value = tbPhone.Text.ToString();
                    dataGridView1.Rows[adr].Selected = true;
                    dataGridView1.FirstDisplayedCell = dataGridView1[adrlist - 1, adr];
                }

                tbPhone.Text = tbFio.Text = "";
            }
            else
            {
                lbComment.Text = "Введите данные абонента";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int adrlist;
            int adr;
            if(tbFio.Text!="")
            {
                adrlist = myHash.DelHash(tbFio.Text);
                string phone;
                myHash.FindHash(tbFio.Text, out phone);
                adr = myHash.hashKey(phone);
                if (adr != -1)
                {
                    if (adrlist == 0)
                    {
                        dataGridView1[2, adr].Value = tbFio.Text.ToString();
                        dataGridView1[1, adr].Value = tbPhone.Text.ToString();
                        dataGridView1.Rows[adr].Selected = true;
                        dataGridView1.FirstDisplayedCell = dataGridView1[0, adr];
                    }

                    if (adrlist > 0)
                    {
                        dataGridView1[adrlist * 2 + 2, adr].Value = tbFio.Text.ToString();
                        dataGridView1[adrlist * 2 + 1, adr].Value = tbPhone.Text.ToString();
                        dataGridView1.Rows[adr].Selected = true;
                        dataGridView1.FirstDisplayedCell = dataGridView1[adrlist - 1, adr];
                    }
                    lbComment.Text = "Абонент удален";
                }
                else
                    lbComment.Text = "Введите Фамилию и Имя Абонента";
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            FillHashTable();
            ShowHash();
            btnFill.Visible = false;
            btnAdd.Visible = true;
            btnDel.Visible = true;
            btnFind.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("phoneBook.txt", FileMode.Create, FileAccess.Write);
            StreamWriter strWriter = new StreamWriter(file);
            for(int i = 0; i<myHash.sizeTable; i++)
            {
                if (myHash.h[i].listInfo.Count > 0)
                {
                    for (int j = 0; j < myHash.h[i].listInfo.Count; j++)
                    {
                        strWriter.WriteLine(myHash.h[i].listInfo[j].fio);
                        strWriter.WriteLine(myHash.h[i].listInfo[j].phone);
                    }
                }
            }
            strWriter.Close();
        }
    }
}
