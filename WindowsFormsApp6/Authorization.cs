using ConsoleApp4;
using mAXS_gORN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Authorization : Form
    {
        public int ind1 { get; set; }
        public int ind2{get;set;}
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Visible==false)
            {
                try
                {
                    if (textNamePersonFields.Text.Length == 0)
                    {
                        throw new Exception("Text length name person<0");
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
            
              
                try
                {
                    if(comboBox1.Items.Count!=0)
                    if (comboBox1.SelectedIndex < 0)
                    {
                        throw new Exception("Eror index name!");
                    }else
                    if(listView1.Items.Count!=0)
                    if(listView1.FocusedItem.Index<0)
                    {
                        throw new Exception("Eror index list!");
                    }
                    ind2 = listView1.FocusedItem.Index;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
  
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
        void UpdateBox()
        {
            listView1.Clear();
            DatManage datManage = new DatManage();
            ListBooks listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
            foreach (var el in listBooks.Books)
            {
                var item = listView1.Items.Add(el.Name);
                item.SubItems.Add(el.Cost.ToString());
                item.SubItems.Add(el.TypeBook.ToString());
                item.SubItems.Add(el.ChanrBook.ToString());
                item.SubItems.Add(el.Id.ToString());
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
                DatManage datManage = new DatManage();
                PersonList personList = new PersonList();
            listView1.Items.Clear();
                personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
            foreach (var el in personList.People[comboBox1.SelectedIndex].HaveBook)
            {
                var item = listView1.Items.Add(el.Name);
                item.SubItems.Add(el.Cost.ToString());
                item.SubItems.Add(el.TypeBook.ToString());
                item.SubItems.Add(el.ChanrBook.ToString());
                item.SubItems.Add(el.Id.ToString());

            }
              
            ind1 = comboBox1.SelectedIndex;
         
             
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void UniversalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (anotationfield.Text.Length == 0 || namefield.Text.Length == 0 || costfield.Text.Length == 0 || typefield.Text.Length == 0 || textBoxChnr.Text.Length == 0)
                {
                    throw new Exception("Text length <0!");
                }

                if (!int.TryParse(costfield.Text, out int text))
                {
                    throw new Exception($" {text} is not a number!");
                }

                //Add 
                PersonList personList = new PersonList();
                DatManage datManage = new DatManage();

                personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");

                personList.People[comboBox1.SelectedIndex].HaveBook.Add(new Book() { Name = namefield.Text, Anotation = anotationfield.Text, Cost = int.Parse(costfield.Text), TypeBook = typefield.Text, Id = personList.People[comboBox1.SelectedIndex].HaveBook.Count + 1, ChanrBook = textBoxChnr.Text });
                datManage.SerializeXML(personList, "PERSONS.xml");

                panel1.Visible = false;
         
              


                ////////
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
            
        }

        private void textNamePersonFields_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
