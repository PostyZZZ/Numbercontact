using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domash0102
{
    internal class ContactManager
    {
        private string connectionString = "Host=localhost;Username=postgres;Password=123;Database=nubmercontact";


        public void AddContact(string name, string phoneNumber)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO contact (name, phone_number) VALUES (@Name, @PhoneNumber)";
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("PhoneNumber", phoneNumber);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteContact(int contactId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM contact WHERE id = @ContactId";
                    cmd.Parameters.AddWithValue("ContactId", contactId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE contact SET name = @Name, phone_number = @PhoneNumber WHERE id = @Id";
                    cmd.Parameters.AddWithValue("Name", contact.Name);
                    cmd.Parameters.AddWithValue("PhoneNumber", contact.PhoneNumber);
                    cmd.Parameters.AddWithValue("Id", contact.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM contact", connection))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contact contact = new Contact
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("phone_number"))
                            };
                            contacts.Add(contact);
                        }
                    }
                }
            }
            return contacts;
        }

        public Contact GetContactById(int contactId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM contact WHERE id = @ContactId", connection))
                {
                    cmd.Parameters.AddWithValue("ContactId", contactId);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Contact contact = new Contact
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("phone_number"))
                            };
                            return contact;
                        }
                        else
                        {
                            return null; // Возвращаем null, если контакт не найден
                        }
                    }
                }
            }
        }

    }

    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}