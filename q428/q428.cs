/****************************
** q428.cs
** Employee Management 3
** Patrick Xie, 4/28/2011,
****************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace q428
{
    public partial class q428 : Form
    {
        public q428()
        {
            InitializeComponent();
        }
        /*confirm/update button to add or update employee information*/
        private void confirmHireButton_Click(object sender, EventArgs e)
        {
            switch (classDropDown.SelectedItem.ToString())
            {
                case "Employee":
                    //(same for all cases) checks if button is for update and if something is selected
                    if (confirmHireButton.Text == "Update" && listBoxOne.SelectedIndex >= 0)
                    {
                        //(same for all cases) selectedIndex is the index of the item selected in the listBoxOne
                        int selectedIndex = listBoxOne.Items.IndexOf(listBoxOne.SelectedItem);
                        listBoxOne.Items.RemoveAt(selectedIndex);//removes then adds at same position
                        listBoxOne.Items.Insert(selectedIndex, new Employee(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text)));
                    }
                    //(same for all cases) checks if button is adding a new object and making sure textbox are not blank
                    if (confirmHireButton.Text == "Confirm" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && salaryTextBox.Text != "")
                    {
                        listBoxOne.Items.Add(new Employee(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text)));
                        confirmHireButton.Text = "Update";
                    }
                    break;
                case "Manager":
                    if (confirmHireButton.Text == "Update" && listBoxOne.SelectedIndex >= 0)
                    {
                        int selectedIndex = listBoxOne.Items.IndexOf(listBoxOne.SelectedItem);
                        listBoxOne.Items.RemoveAt(selectedIndex);
                        listBoxOne.Items.Insert(selectedIndex, new Manager(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), extraInfoTextBox.Text));
                    }
                    if (confirmHireButton.Text == "Confirm" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && salaryTextBox.Text != "" && extraInfoTextBox.Text != "")
                    {
                        listBoxOne.Items.Add(new Manager(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), extraInfoTextBox.Text));
                        confirmHireButton.Text = "Update";
                    }
                    break;
                case "Peon":
                    if (confirmHireButton.Text == "Update" && listBoxOne.SelectedIndex >= 0)
                    {
                        int selectedIndex = listBoxOne.Items.IndexOf(listBoxOne.SelectedItem);
                        listBoxOne.Items.RemoveAt(selectedIndex);
                        listBoxOne.Items.Insert(selectedIndex, new Peon(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), int.Parse(extraInfoTextBox.Text)));
                    }
                    if (confirmHireButton.Text == "Confirm" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && salaryTextBox.Text != "" && extraInfoTextBox.Text != "")
                    {
                        listBoxOne.Items.Add(new Peon(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), int.Parse(extraInfoTextBox.Text)));
                        confirmHireButton.Text = "Update";
                    }
                    break;
                case "Trainer":
                    if (confirmHireButton.Text == "Update" && listBoxOne.SelectedIndex >= 0)
                    {
                        int selectedIndex = listBoxOne.Items.IndexOf(listBoxOne.SelectedItem);
                        listBoxOne.Items.RemoveAt(selectedIndex);
                        listBoxOne.Items.Insert(selectedIndex, new Trainer(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), extraInfoTextBox.Text));
                    }
                    if (confirmHireButton.Text == "Confirm" && firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && salaryTextBox.Text != "" && extraInfoTextBox.Text != "")
                    {
                        listBoxOne.Items.Add(new Trainer(firstNameTextBox.Text, lastNameTextBox.Text, int.Parse(salaryTextBox.Text), extraInfoTextBox.Text));
                        confirmHireButton.Text = "Update";
                    }
                    break;
                default:
                    break;
            }
        }

        private void listBoxOne_Click(object sender, EventArgs e)
        {
            //makes sure that what you click in the listbox is one of the objects
            if(listBoxOne.SelectedIndex >= 0)
            {
                //checks what type of object is selected. then have bool to see if name equals to
                if (listBoxOne.SelectedItem.GetType().Name.Equals("Employee"))
                {
                    //(same for all cases) displays info of current selected object
                    Employee selected = (Employee)listBoxOne.SelectedItem;
                    classDropDown.SelectedItem = "Employee";
                    firstNameTextBox.Text = selected.getFirstName();
                    lastNameTextBox.Text = selected.getLastName();
                    salaryTextBox.Text = selected.getSalary().ToString();
                }
                else if (listBoxOne.SelectedItem.GetType().Name.Equals("Manager"))
                {
                    Manager selected = (Manager)listBoxOne.SelectedItem;
                    classDropDown.SelectedItem = "Manager";
                    firstNameTextBox.Text = selected.getFirstName();
                    lastNameTextBox.Text = selected.getLastName();
                    salaryTextBox.Text = selected.getSalary().ToString();
                    extraInfoTextBox.Text = selected.getStore();

                }
                else if (listBoxOne.SelectedItem.GetType().Name.Equals("Peon"))
                {
                    Peon selected = (Peon)listBoxOne.SelectedItem;
                    classDropDown.SelectedItem = "Peon";
                    firstNameTextBox.Text = selected.getFirstName();
                    lastNameTextBox.Text = selected.getLastName();
                    salaryTextBox.Text = selected.getSalary().ToString();
                    extraInfoTextBox.Text = selected.getHours().ToString();
                }
                else if (listBoxOne.SelectedItem.GetType().Name.Equals("Trainer"))
                {
                    Trainer selected = (Trainer)listBoxOne.SelectedItem;
                    classDropDown.SelectedItem = "Trainer";
                    firstNameTextBox.Text = selected.getFirstName();
                    lastNameTextBox.Text = selected.getLastName();
                    salaryTextBox.Text = selected.getSalary().ToString();
                    extraInfoTextBox.Text = selected.getSubject();
                }
                confirmHireButton.Text = "Update";
            }
        }

        private void classDropDown_TextChanged(object sender, EventArgs e)
        {
            //anytime the combo/drop down box is a different text,
            //shows or hides extra labels/textbox
            switch (classDropDown.SelectedItem.ToString())
            {
                case "Employee":
                    extraInfoTextBox.Hide();
                    label6.Hide();
                    break;
                case "Manager":
                    extraInfoTextBox.Show();
                    label6.Text = "Store Name:";
                    label6.Show();
                    break;
                case "Peon":
                    extraInfoTextBox.Show();
                    label6.Text = "Hours:";
                    label6.Show();
                    break;
                case "Trainer":
                    extraInfoTextBox.Show();
                    label6.Text = "Subject Taught:";
                    label6.Show();
                    break;
                default:
                    extraInfoTextBox.Hide();
                    label6.Hide();
                    break;
            }
        }
        /*when hiring a new employee, clears all text boxes and set button to add*/
        private void hireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            salaryTextBox.Clear();
            extraInfoTextBox.Clear();
            confirmHireButton.Text = "Confirm";
        }
        /*removes selectedd object and clears all textboxes*/
        private void fireEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxOne.SelectedItem != null || listBoxOne.SelectedIndex != -1)
            {
                listBoxOne.Items.RemoveAt(listBoxOne.SelectedIndex);
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                salaryTextBox.Clear();
                extraInfoTextBox.Clear();
            }
        }
    }
}