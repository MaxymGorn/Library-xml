using ConsoleApp4;
using mAXS_gORN;
using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        TabPage tab = new TabPage();

        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                if (ModeBoxCombo.SelectedIndex == 0)
                {
                    MessageBox.Show("Недостаточно прав для доступа!", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControl1.SelectedTab = tabControl1.TabPages[0];
                }
                else if (ModeBoxCombo.SelectedIndex == 1)
                {
                    ChooseItem.Visible = true;
                    But1.Text = "Удалить персону";
                    But2.Text = "Добавить персону";
                }
                else
                {
                    ChooseItem.Visible = false;
                    But1.Text = "Удалить книгу";
                    But2.Text = "Добавить книгу";
                }
            }
        }

        private void tabPageMode_Click(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Cancelbutton.Tag == "Add")
            {
                try
                {
                    if (anotationfield.Text.Length == 0 || namefield.Text.Length == 0 || costfield.Text.Length == 0 || typefield.Text.Length == 0 || textBoxChnr.Text.Length==0)
                    {
                        throw new Exception("Text length <0!");
                    }

                    if (!int.TryParse(costfield.Text, out int text))
                    {
                        throw new Exception($" {text} is not a number!");
                    }
                    panel1.Visible = false;
                    PersonBoxList.Visible = true; textBoxChnr.Visible = false;labelChanr.Visible = false;
                    anotationfield.Visible = false; namefield.Visible = false; costfield.Visible = false; typefield.Visible = false;
                    labelAnotation.Visible = false; labelCost.Visible = false; labelName.Visible = false; labelType.Visible = false;
                    //Add 
                    ListBooks listBooks = new ListBooks();
                    DatManage datManage = new DatManage();

                    listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");

                    listBooks.Books.Add(new Book() { Name = namefield.Text, Anotation = anotationfield.Text, Cost = int.Parse(costfield.Text), TypeBook = typefield.Text, Id = listBooks.Books.Count + 1, ChanrBook=textBoxChnr.Text });
                    datManage.SerializeXML(listBooks, "LISTBOOKS.xml");
                    ShowMesText("Успешно добавлено!");
                    ////////
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (DeleteListBooks.Items.Count != 0)
                {
                    try
                    {
                        if (Convert.ToInt32(DeleteListBooks.Tag.ToString()) < 0)
                        {
                            throw new Exception("Eror index!");
                        }

                        //Delete 

                        ListBooks listBooks = new ListBooks();
                        DatManage datManage = new DatManage();

                        listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
                        listBooks.Books.RemoveAt(DeleteListBooks.SelectedIndex + 1);
                        datManage.SerializeXML(listBooks, "LISTBOOKS.xml");
                        ShowMesText("Успешно удалено!");

                        /////

                        DeleteListBooks.Visible = false;
                        panel1.Visible = false;


                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DeleteListBooks.Visible = false;
                    panel1.Visible = false;
                }

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ModeBoxCombo.SelectedIndex == 1)
            {

                Authorization authorization = new Authorization();
                authorization.listView1.Visible = false;
                authorization.comboBox1.Visible = false;
                if (authorization.ShowDialog() == DialogResult.OK)
                {
                    DatManage datManage = new DatManage();
                    PersonList personList = new PersonList();
                    personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");

                    
                    Person person = new Person() { Name = authorization.textNamePersonFields.Text, Id = personList.People.Count + 1, Type = ModeBoxCombo.SelectedIndex };

                   
                    if (!personList.People.Contains(person))
                        personList.People.Add(person);
                    

                   
                    datManage.SerializeXML(personList, "PERSONS.xml");
                  
                    UpdateListViev();
                    UpdateCombobox();
                }


            }
            else if(ModeBoxCombo.SelectedIndex == 2)
            {
                panel1.Visible = true;
                DeleteListBooks.Visible = false;
                Cancelbutton.Tag = "Add";
                anotationfield.Visible = true; namefield.Visible = true; costfield.Visible = true; typefield.Visible = true;
                labelAnotation.Visible = true; labelCost.Visible = true; labelName.Visible = true; labelType.Visible = true;
                PersonBoxList.Visible = false;
                textBoxChnr.Visible = true;
                labelChanr.Visible = true;
                UniversalButton.Text = "Сохранить";
                UpdateListViev();
                UpdateCombobox();
            }



        }


        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            PersonBoxList.Visible = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ModeBoxCombo.SelectedIndex == 1)
            {
                try
                {
                    if(PersonBoxList.SelectedIndex<0)
                    {
                        throw new Exception("Eror ind!");
                    }
                    PersonList personList = new PersonList();
                    DatManage datManage = new DatManage();

                    personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
                    PersonList personList1 = new PersonList(); PersonList personList2 = new PersonList(); PersonList personList3 = new PersonList();


                    foreach (var el in personList.People )
                        {
                            if(el.Type==0)
                            {

                            personList1.People.Add(el);

                            }
                            else if (el.Type == 1)
                            {
                            personList2.People.Add(el);
                            }
                            else
                        {
                            personList3.People.Add(el);
                        }
                        }
                 
                        if(ChooseItem.SelectedIndex==0)
                    {
                        personList1.People.RemoveAt(PersonBoxList.SelectedIndex);
                    }
                      else if (ChooseItem.SelectedIndex == 1)
                    {
                        personList2.People.RemoveAt(PersonBoxList.SelectedIndex);
                    }
                        else
                    {
                        personList3.People.RemoveAt(PersonBoxList.SelectedIndex);
                    }
                    personList = personList1;
                    foreach(var el in personList2.People)
                    personList.People.Add(el);

                    foreach (var el in personList3.People)
                        personList.People.Add(el);



                    datManage.SerializeXML(personList, "PERSONS.xml");
                    UpdateCombobox();
                    UpdateListViev();

                }
                catch(Exception eror)
                {
                    MessageBox.Show(eror.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
              

            }
            else if (ModeBoxCombo.SelectedIndex == 2)
            {
                anotationfield.Visible = false; namefield.Visible = false; costfield.Visible = false; typefield.Visible = false;textBoxChnr.Visible = false;
                labelAnotation.Visible = false; labelCost.Visible = false; labelName.Visible = false; labelType.Visible = false;labelChanr.Visible = false;

                PersonBoxList.Visible = false;
                panel1.Visible = true;
                Cancelbutton.Tag = "Del";
                DeleteListBooks.Visible = true;
                UniversalButton.Text = "Удалить";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModeBoxCombo.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            UpdateListViev();//оновлюємо всі можливі списки
            UpdateCombobox();
        }
        private void UpdateCombobox()
        {
                           
         
                ListBooks listBooks = new ListBooks();
                DatManage datManage = new DatManage();

                listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Все категории");
            foreach (var elem in listBooks.Books)
            {
                if (!comboBox1.Items.Contains(elem.TypeBook))
                {
                    comboBox1.Items.Add(elem.TypeBook);
                }
            }
            comboBox1.SelectedIndex = 0;
            ChooseItem.SelectedIndex = 0;

            comboxChanr.Items.Clear();
            comboxChanr.Items.Add("Все жанры");
            foreach (var elem in listBooks.Books)
            {
                if (!comboxChanr.Items.Contains(elem.ChanrBook))
                {
                    comboxChanr.Items.Add(elem.ChanrBook);
                }
            }
            comboxChanr.SelectedIndex = 0;
        }
        private void IsGrowing(ref ListBooks listBooks)//сортування
        {

            Book temp;
            for (int i = 0; i < listBooks.Books.Count - 1; i++)
            {
                for (int j = i + 1; j < listBooks.Books.Count; j++)
                {
                    if (listBooks.Books[i].Cost < listBooks.Books[j].Cost)
                    {
                        temp = listBooks.Books[i];
                        listBooks.Books[i] = listBooks.Books[j];
                        listBooks.Books[j] = temp;
                    }
                }
            }
        }
        private void IsFall(ref ListBooks listBooks)//сортування
        {

            Book temp;
            for (int i = 0; i < listBooks.Books.Count - 1; i++)
            {
                for (int j = i + 1; j < listBooks.Books.Count; j++)
                {
                    if (listBooks.Books[i].Cost > listBooks.Books[j].Cost)
                    {
                        temp = listBooks.Books[i];
                        listBooks.Books[i] = listBooks.Books[j];
                        listBooks.Books[j] = temp;
                    }
                }
            }
        }
        private void WriteListBook(Book elem)//запис в головний листвю
        {
        
                var item = listView1.Items.Add(elem.Name);
                item.SubItems.Add(Convert.ToString(elem.Cost));
                item.SubItems.Add(Convert.ToString(elem.TypeBook));
                item.SubItems.Add(Convert.ToString(elem.ChanrBook));
            
       
        }


        private void WriteListBook2(Book elem)//запис в головний листвю за фільтром жанр
        {
            if(comboxChanr.Text==elem.ChanrBook)
            {
                var item = listView1.Items.Add(elem.Name);
                item.SubItems.Add(Convert.ToString(elem.Cost));
                item.SubItems.Add(Convert.ToString(elem.TypeBook));
                item.SubItems.Add(Convert.ToString(elem.ChanrBook));
            }
     


        }

        private void UpdateListViev(string type= "Все категории", int ind_mode=0)
            {
          
                listView1.Items.Clear();
                ReaderBook.Items.Clear();
            PersonBoxList.Items.Clear();
            
         
                ListBooks listBooks = new ListBooks();
                DatManage datManage = new DatManage();

                listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
            foreach(var el in  listBooks.Books)
            {
                ReaderBook.Items.Add(el.Name);
            }
            if (ind_mode == 1)
            {

                IsGrowing(ref listBooks);
            }
            else if (ind_mode == 2)
            {

                IsFall(ref listBooks);

            }

         if(comboxChanr.SelectedIndex==0)
            foreach (var elem in listBooks.Books)
            {
                if (type == "Все категории")
                {
                    WriteListBook(elem);


                }
         
                else if (elem.TypeBook==type)
                {
                    WriteListBook(elem);

                }

            }
         else
            {
                foreach (var elem in listBooks.Books)
                {
                    if (type == "Все категории")
                    {
                        WriteListBook2(elem);


                    }

                    else if (elem.TypeBook == type)
                    {
                        WriteListBook2(elem);

                    }

                }
            }
     
            PersonList personList = new PersonList();
            personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
       

            if(ModeBoxCombo.SelectedIndex==1)
            foreach(var el in personList.People)
            {
                PersonBoxList.Items.Add(el.Name);
            }
            else
            {
                foreach(var el in listBooks.Books)
                {
                    PersonBoxList.Items.Add(el.Name);
                }
            }

        }
        private void ModeBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            panel1.Visible = false;
            PersonBoxList.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ListBooks listBooks = new ListBooks();
            DatManage datManage = new DatManage();
            DeleteListBooks.Items.Clear();

            listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
            foreach (var elem in listBooks.Books)
            {
                DeleteListBooks.Items.Add(elem.Name);

            }
        }

        private async void ShowMesText(string text)
        {
            MessgeText.Visible = true;
            MessgeText.Text = text;
            await Task.Delay(1500);
            MessgeText.Visible = false;
        }




        private void DeleteListBooks_Click(object sender, EventArgs e)
        {
            DeleteListBooks.Tag = Convert.ToString(DeleteListBooks.SelectedIndex);
        }

        private void tabPageBook_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViev();
            UpdateCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
      
                if (listView1.FocusedItem.Index <0 )
                {
                    throw new Exception("Eror!");
                }
                


                Authorization authorization = new Authorization();
                authorization.listView1.Visible = false;
                authorization.comboBox1.Visible = false;
                if (authorization.ShowDialog() == DialogResult.OK)
                {
                    DatManage datManage = new DatManage();
                    PersonList personList = new PersonList();
                    personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");

                    ListBooks listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
                    Person person = new Person() { Name = authorization.textNamePersonFields.Text, Id= personList.People.Count+1,Type=ModeBoxCombo.SelectedIndex };
                    
                    person.HaveBook.Add(listBooks.Books[listView1.FocusedItem.Index]);
                   
                        personList.People.Add(person);
                  personList.People[personList.People.Count - 1].HaveBook.Add(listBooks.Books[listView1.FocusedItem.Index]);

                    listBooks.Books.RemoveAt(listView1.FocusedItem.Index);
                    datManage.SerializeXML(personList, "PERSONS.xml");
                    datManage.SerializeXML(listBooks, "LISTBOOKS.xml");
                    UpdateListViev();
                    UpdateCombobox();
                }
            }

            catch (Exception eror)
            {
                MessageBox.Show(eror.Message, "Eror index!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViev(comboBox1.Text, comboBox2.SelectedIndex);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViev(comboBox1.Text, comboBox2.SelectedIndex);
        }

        private void tabPageReader_Click(object sender, EventArgs e)
        {

        }

    
 
        

        private void PersonBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PersonBoxList.SelectedIndex < 0)
                {
                    throw new Exception("Eror Selected!");
                }
                DatManage datManage = new DatManage();

                PersonList personBoxList = new PersonList();
                personBoxList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
                personBoxList.People.RemoveAt(PersonBoxList.SelectedIndex);
                datManage.SerializeXML(personBoxList, "PERSONS.xml");
                UpdateListViev();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            DatManage datManage = new DatManage();
            PersonList personList = new PersonList();
            personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
            ListBooks listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");

            if(personList.People.Count>0)
            {
                foreach(var el in personList.People)
                {
                    if(el.HaveBook.Count>0)
                    {
                        Authorization authorization = new Authorization();
                        authorization.comboBox1.Visible = true;
                        authorization.listView1.Visible = true;
                        authorization.label1.Text = "Выберите читателя: ";
                        authorization.TakeOrGetBtn.Text = "Сдать";

                        authorization.textNamePersonFields.Visible = false;

                        foreach (var ell in personList.People)
                        {
                            authorization.comboBox1.Items.Add(ell.Name);

                        }

                        if (authorization.ShowDialog() == DialogResult.OK)
                        {

                            Book book = personList.People[authorization.ind1].HaveBook[authorization.ind2];
                            listBooks.Books.Add(book);
                            personList.People[authorization.ind1].HaveBook.RemoveAt(authorization.ind2);

                  

                            datManage.SerializeXML(personList, "PERSONS.xml");
                            datManage.SerializeXML(listBooks, "LISTBOOKS.xml");
                            authorization.comboBox1.Visible = false;
                            authorization.listView1.Visible = false;
                        }
                        authorization.label1.Text = "Введите имя: ";
                        authorization.TakeOrGetBtn.Text = "Взять";
                        UpdateListViev();
                        UpdateCombobox();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Нет персон, которие не здалы книги!", "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    }
                }



            }
            else
            {
                MessageBox.Show("Нет персон!", "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }



        }

        private void ReaderBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ReaderBook.SelectedIndex < 0)
                {
                    throw new Exception("Eror Selected!");
                }
                DatManage datManage = new DatManage();

                ListBooks listBooks = new ListBooks();
                listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");
                InfoText.Text = listBooks.Books[ReaderBook.SelectedIndex].Anotation;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Notifications", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void ChooseItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonBoxList.Items.Clear();
            PersonList personList = new PersonList();
            DatManage datManage = new DatManage();

            personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
            foreach (var el in personList.People)
            {
                if(el.Type==ChooseItem.SelectedIndex)
                {
                    PersonBoxList.Items.Add(el.Name);
                }
             
            }

        }

        private void comboxChanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListViev(comboBox1.Text, comboBox2.SelectedIndex);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DatManage datManage = new DatManage();
            PersonList personList = new PersonList();
            personList = datManage.DeserializeXML<PersonList>("PERSONS.xml");
            ListBooks listBooks = datManage.DeserializeXML<ListBooks>("LISTBOOKS.xml");

                        Authorization authorization = new Authorization();
                        authorization.comboBox1.Visible = true;
                        authorization.listView1.Visible = true;
                        authorization.button1.Visible = true;
                        authorization.label1.Text = "Выберите читателя: ";
                        authorization.TakeOrGetBtn.Text = "Удалить";

                        authorization.textNamePersonFields.Visible = false;

                        foreach (var ell in personList.People)
                        {
                            authorization.comboBox1.Items.Add(ell.Name);

                        }

                        if (authorization.ShowDialog() == DialogResult.OK)
                        {

                           
                            personList.People[authorization.ind1].HaveBook.RemoveAt(authorization.ind2);


                            datManage.SerializeXML(personList, "PERSONS.xml");
                            datManage.SerializeXML(listBooks, "LISTBOOKS.xml");
                            authorization.comboBox1.Visible = false;
                            authorization.listView1.Visible = false;
                            authorization.button1.Visible = false;
            }
                        authorization.label1.Text = "Введите имя: ";
                        authorization.TakeOrGetBtn.Text = "Взять";
                        UpdateListViev();
                        UpdateCombobox();
  



     
        }
    }
}
