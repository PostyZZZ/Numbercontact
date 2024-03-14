using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace domash0102
{
    public partial class Edit : Form
    {
        private Contact contact;

        public Edit(Contact contactToEdit)
        {
            InitializeComponent();
            this.contact = contactToEdit;
            nameTextBox.Text = contact.Name;
            phoneNumberTextBox.Text = contact.PhoneNumber;
        }

        public Contact GetEditedContact()
        {
            contact.Name = nameTextBox.Text;
            contact.PhoneNumber = phoneNumberTextBox.Text;
            return contact;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string phoneNumber = phoneNumberTextBox.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Пожалуйста, введите имя и номер телефона контакта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            this.DialogResult = DialogResult.OK; 
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
