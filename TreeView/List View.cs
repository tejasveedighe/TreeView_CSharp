using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class List_View : Form
    {
        public List_View()
        {
            InitializeComponent();
        }

        private List<Person> GetPeopleList()
        {
            var people = new List<Person>();
            people.Add(new Person { FirstName = "Tejasvee", LastName = "Dighe", DOB = DateTime.Now.AddYears(-22) });

            people.Add(new Person { FirstName = "Rahul", LastName = "Dighe", DOB = DateTime.Now.AddYears(-45) });
            people.Add(new Person { FirstName = "Sam", LastName = "Manekshaw", DOB = DateTime.Now.AddYears(-17) });
            people.Add(new Person { FirstName = "Indira", LastName = "Gandhi", DOB = DateTime.Now.AddYears(-102) });
            people.Add(new Person { FirstName = "Bipin", LastName = "Rawat", DOB = DateTime.Now.AddYears(-56) });
            people.Add(new Person { FirstName = "Karan", LastName = "Shergill", DOB = DateTime.Now.AddYears(-25) });
            people.Add(new Person { FirstName = "Shub", LastName = "Gill", DOB = DateTime.Now.AddYears(-22) });

            return people;
        }

        private void List_View_Load(object sender, EventArgs e)
        {
            var people = GetPeopleList();

            foreach (var person in people)
            {
                var row = new string[] { person.FirstName, person.LastName, person.DOB.ToShortDateString() };
                var lvi = new ListViewItem(row);

                lvi.Tag = person;
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var person = listView1.SelectedItems[0].Tag as Person;
                foreach (var item in listView1.SelectedItems)
                {
                    Console.WriteLine(item);
                }
                if (person != null)
                {

                    var details = string.Format("{0} {1} {2} born on {3}", person.Id, person.FirstName, person.LastName, person.DOB.ToString("dd/MM/yyyy"));

                    MessageBox.Show(details, "Person Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
