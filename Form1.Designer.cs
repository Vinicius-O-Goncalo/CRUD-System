namespace Finance_Project
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
            gbxFinance = new GroupBox();
            textBox3 = new TextBox();
            lbCredit = new Label();
            lbDebit = new Label();
            lbValue = new Label();
            textBox4 = new TextBox();
            txtValue = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            btnOpen = new Button();
            btnSave = new Button();
            lbName = new Label();
            textBox1 = new TextBox();
            lbDescription = new Label();
            gbxFinance.SuspendLayout();
            SuspendLayout();
            // 
            // gbxFinance
            // 
            gbxFinance.Controls.Add(lbDescription);
            gbxFinance.Controls.Add(textBox3);
            gbxFinance.Controls.Add(lbCredit);
            gbxFinance.Controls.Add(lbDebit);
            gbxFinance.Controls.Add(lbValue);
            gbxFinance.Controls.Add(textBox4);
            gbxFinance.Controls.Add(txtValue);
            gbxFinance.Controls.Add(textBox2);
            gbxFinance.Controls.Add(btnAdd);
            gbxFinance.Controls.Add(btnOpen);
            gbxFinance.Controls.Add(btnSave);
            gbxFinance.Controls.Add(lbName);
            gbxFinance.Controls.Add(textBox1);
            gbxFinance.Location = new Point(239, 40);
            gbxFinance.Name = "gbxFinance";
            gbxFinance.Size = new Size(594, 460);
            gbxFinance.TabIndex = 0;
            gbxFinance.TabStop = false;
            gbxFinance.Text = "Fianace";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(215, 255);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 87);
            textBox3.TabIndex = 13;
            // 
            // lbCredit
            // 
            lbCredit.AutoSize = true;
            lbCredit.Location = new Point(376, 45);
            lbCredit.Name = "lbCredit";
            lbCredit.Size = new Size(45, 16);
            lbCredit.TabIndex = 12;
            lbCredit.Text = "Crédito";
            // 
            // lbDebit
            // 
            lbDebit.AutoSize = true;
            lbDebit.Location = new Point(379, 137);
            lbDebit.Name = "lbDebit";
            lbDebit.Size = new Size(42, 16);
            lbDebit.TabIndex = 11;
            lbDebit.Text = "Débito";
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(162, 137);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(33, 16);
            lbValue.TabIndex = 9;
            lbValue.Text = "Valor";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(338, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(129, 23);
            textBox4.TabIndex = 7;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(119, 167);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(129, 23);
            txtValue.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(338, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 23);
            textBox2.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(440, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(269, 380);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Abrir";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(162, 45);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 16);
            lbName.TabIndex = 1;
            lbName.Text = "Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 0;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(269, 225);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(58, 16);
            lbDescription.TabIndex = 14;
            lbDescription.Text = "Descrição";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 589);
            Controls.Add(gbxFinance);
            Name = "Form1";
            Text = " ";
            gbxFinance.ResumeLayout(false);
            gbxFinance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxFinance;
        private Button btnSave;
        private Label lbName;
        private TextBox textBox1;
        private Label lbValue;
        private TextBox textBox4;
        private TextBox txtValue;
        private TextBox textBox2;
        private Button btnAdd;
        private Button btnOpen;
        private Label lbDebit;
        private Label lbCredit;
        private TextBox textBox3;
        private Label lbDescription;
    }
}
