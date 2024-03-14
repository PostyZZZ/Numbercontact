namespace domash0102
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Cursor = Cursors.IBeam;
            nameTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            nameTextBox.Location = new Point(64, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(166, 24);
            nameTextBox.TabIndex = 0;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Cursor = Cursors.IBeam;
            phoneNumberTextBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            phoneNumberTextBox.Location = new Point(65, 74);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(166, 24);
            phoneNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(9, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(42, 9);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 4;
            label3.Text = "Заполните поля";
            label3.Click += label3_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Navy;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(64, 101);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(85, 33);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Navy;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            cancelButton.ForeColor = SystemColors.ControlLightLight;
            cancelButton.Location = new Point(155, 101);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(80, 33);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(247, 141);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(nameTextBox);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox phoneNumberTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Button cancelButton;
    }
}