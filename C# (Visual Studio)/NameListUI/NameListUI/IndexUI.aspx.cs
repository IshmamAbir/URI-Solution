using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NameListUI
{
    public partial class IndexUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            
            if (ViewState["nameListVS"]==null)
            {
                Person aPerson = new Person();
                aPerson.firstName = firstNameTextBox.Text;
                aPerson.middleName = middleNameTextBox.Text;
                aPerson.lastName = lastNameTextBox.Text;

                List<Person> personList = new List<Person>();
                personList.Add(aPerson);

                ViewState["nameListVS"] = personList;
            }
            else
            {
                List<Person> persons = (List<Person>) ViewState["nameListVS"];
                Person newPerson= new Person();
                newPerson.firstName = firstNameTextBox.Text;
                newPerson.middleName = middleNameTextBox.Text;
                newPerson.lastName = lastNameTextBox.Text;

                persons.Add(newPerson);
                ViewState["nameListVS"] = persons;

            }




            


        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();

            List<Person> persons = (List<Person>) ViewState["nameListVS"];

            foreach (Person person in persons)
            {
                displayListBox.Items.Add(person.firstName+" "+person.middleName+" "+person.lastName);
            }
        }
    }
}