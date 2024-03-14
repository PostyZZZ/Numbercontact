using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;



namespace domash0102
{
    public partial class Form1 : Form
    {
        private ContactManager contactManager = new ContactManager();

        public Form1()
        {
            InitializeComponent();

            UpdateContactList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string phoneNumber = phoneNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, введите имя и номер телефона контакта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contactManager.AddContact(name, phoneNumber);
            UpdateContactList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedContactId = (int)dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;
                contactManager.DeleteContact(selectedContactId);
                UpdateContactList();
            }
        }
        private void UpdateContactList()
        {
            List<Contact> contacts = contactManager.GetContacts();
            dataGridView1.DataSource = contacts;
            dataGridView1.Columns["Id"].Visible = false; 
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["PhoneNumber"].HeaderText = "Номер телефона";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int selectedContactId = (int)dataGridView1.Rows[selectedRowIndex].Cells["Id"].Value;
                Contact selectedContact = contactManager.GetContactById(selectedContactId);
                using (Edit editForm = new Edit(selectedContact))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        Contact editedContact = editForm.GetEditedContact();
                        contactManager.UpdateContact(editedContact);
                        UpdateContactList();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.ToLower();
            List<Contact> filteredContacts = contactManager.GetContacts()
                .Where(contact => contact.Name.ToLower().Contains(searchText) || contact.PhoneNumber.ToLower().Contains(searchText))
                .ToList();

            dataGridView1.DataSource = filteredContacts;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}