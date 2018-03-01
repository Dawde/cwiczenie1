namespace cwiczenia1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.user = new System.Windows.Forms.GroupBox();
            this.addUser = new System.Windows.Forms.Button();
            this.wiek = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorText = new System.Windows.Forms.ErrorProvider(this.components);
            this.user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorText)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Controls.Add(this.addUser);
            this.user.Controls.Add(this.wiek);
            this.user.Controls.Add(this.age);
            this.user.Controls.Add(this.surname);
            this.user.Controls.Add(this.label1);
            this.user.Controls.Add(this.nameText);
            this.user.Controls.Add(this.imie);
            this.user.Location = new System.Drawing.Point(13, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(204, 146);
            this.user.TabIndex = 0;
            this.user.TabStop = false;
            this.user.Text = "Użytkownik";
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(114, 106);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 23);
            this.addUser.TabIndex = 6;
            this.addUser.Text = "Dodaj";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // wiek
            // 
            this.wiek.AutoSize = true;
            this.wiek.Location = new System.Drawing.Point(119, 81);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(32, 13);
            this.wiek.TabIndex = 5;
            this.wiek.Text = "Wiek";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(157, 79);
            this.age.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.age.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(33, 20);
            this.age.TabIndex = 4;
            this.age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(90, 53);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwisko";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(90, 27);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 1;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(58, 30);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(26, 13);
            this.imie.TabIndex = 0;
            this.imie.Text = "Imię";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(223, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(415, 407);
            this.listBox1.TabIndex = 7;
            // 
            // errorText
            // 
            this.errorText.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.user);
            this.Name = "Form1";
            this.Text = "Form1";
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox user;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label wiek;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorText;
    }
}

