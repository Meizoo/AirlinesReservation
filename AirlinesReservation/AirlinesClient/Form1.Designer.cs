namespace AirlinesClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.chToCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFromCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.buyTicket = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reservNumber = new System.Windows.Forms.TextBox();
            this.checkReserv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 56);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pobierz potwierdzenie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(628, 87);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 26);
            this.login.TabIndex = 3;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chToCity,
            this.chFromCity,
            this.chCost,
            this.chDate});
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(12, 42);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(504, 367);
            this.ListView.TabIndex = 4;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // chToCity
            // 
            this.chToCity.Text = "To City";
            this.chToCity.Width = 96;
            // 
            // chFromCity
            // 
            this.chFromCity.Text = "From City";
            this.chFromCity.Width = 98;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.Width = 87;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 215;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Airlines";
            // 
            // buyTicket
            // 
            this.buyTicket.Location = new System.Drawing.Point(628, 119);
            this.buyTicket.Name = "buyTicket";
            this.buyTicket.Size = new System.Drawing.Size(141, 26);
            this.buyTicket.TabIndex = 6;
            this.buyTicket.Text = "Kup bilet";
            this.buyTicket.UseVisualStyleBackColor = true;
            this.buyTicket.Visible = false;
            this.buyTicket.Click += new System.EventHandler(this.buyTicket_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(416, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 20);
            this.searchText.TabIndex = 7;
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj";
            // 
            // reservNumber
            // 
            this.reservNumber.Location = new System.Drawing.Point(628, 183);
            this.reservNumber.Name = "reservNumber";
            this.reservNumber.Size = new System.Drawing.Size(141, 20);
            this.reservNumber.TabIndex = 9;
            // 
            // checkReserv
            // 
            this.checkReserv.Location = new System.Drawing.Point(628, 209);
            this.checkReserv.Name = "checkReserv";
            this.checkReserv.Size = new System.Drawing.Size(141, 26);
            this.checkReserv.TabIndex = 10;
            this.checkReserv.Text = "Sprawdź rezerwację";
            this.checkReserv.UseVisualStyleBackColor = true;
            this.checkReserv.Click += new System.EventHandler(this.checkReserv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Wprowadź numer rezerwacji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Wprowadź numer biletu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(628, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkReserv);
            this.Controls.Add(this.reservNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.buyTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chToCity;
        private System.Windows.Forms.ColumnHeader chFromCity;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Button buyTicket;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reservNumber;
        private System.Windows.Forms.Button checkReserv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

