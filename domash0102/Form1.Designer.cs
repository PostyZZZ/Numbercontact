namespace domash0102
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton = new Button();
            deleteButton = new Button();
            phoneNumberTextBox = new TextBox();
            nameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            editButton = new Button();
            searchTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.Navy;
            addButton.BackgroundImageLayout = ImageLayout.None;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addButton.ForeColor = SystemColors.ControlLightLight;
            addButton.Location = new Point(345, 144);
            addButton.Name = "addButton";
            addButton.Size = new Size(130, 39);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Navy;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Location = new Point(345, 189);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(130, 39);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Cursor = Cursors.IBeam;
            phoneNumberTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            phoneNumberTextBox.Location = new Point(345, 114);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(130, 24);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Cursor = Cursors.IBeam;
            nameTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            nameTextBox.Location = new Point(345, 86);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(130, 24);
            nameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(303, 91);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(287, 116);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 6;
            label2.Text = "Номер";
            label2.Click += label2_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.Navy;
            editButton.Cursor = Cursors.Hand;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            editButton.ForeColor = SystemColors.ControlLightLight;
            editButton.Location = new Point(345, 234);
            editButton.Name = "editButton";
            editButton.Size = new Size(130, 41);
            editButton.TabIndex = 8;
            editButton.Text = "Изменить данные";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Cursor = Cursors.IBeam;
            searchTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            searchTextBox.Location = new Point(71, 86);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(112, 24);
            searchTextBox.TabIndex = 9;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 10;
            label3.Text = "Поиск";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(144, 9);
            label4.Name = "label4";
            label4.Size = new Size(210, 45);
            label4.TabIndex = 11;
            label4.Text = "КОНТАКТЫ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(269, 159);
            dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(487, 282);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(searchTextBox);
            Controls.Add(editButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button deleteButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox phoneNumberTextBox;
        private TextBox nameTextBox;
        private Label label1;
        private Label label2;
        private Button editButton;
        private TextBox searchTextBox;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}
