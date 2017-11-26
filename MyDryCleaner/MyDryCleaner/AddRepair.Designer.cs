namespace AirportDamage_S
{
    partial class AddRepair
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxDamageA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionsA = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TasksA = new System.Windows.Forms.ListView();
            this.btnAddTransactions = new System.Windows.Forms.Button();
            this.DeleteTrans = new System.Windows.Forms.Button();
            this.ActionA = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DamageAbout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBxDamageA
            // 
            this.cmbBxDamageA.FormattingEnabled = true;
            this.cmbBxDamageA.Location = new System.Drawing.Point(100, 49);
            this.cmbBxDamageA.Name = "cmbBxDamageA";
            this.cmbBxDamageA.Size = new System.Drawing.Size(219, 21);
            this.cmbBxDamageA.TabIndex = 1;
            this.cmbBxDamageA.SelectedIndexChanged += new System.EventHandler(this.cmbBxDamageA_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transactions";
            // 
            // TransactionsA
            // 
            this.TransactionsA.FormattingEnabled = true;
            this.TransactionsA.Location = new System.Drawing.Point(100, 97);
            this.TransactionsA.Name = "TransactionsA";
            this.TransactionsA.Size = new System.Drawing.Size(219, 21);
            this.TransactionsA.TabIndex = 3;
            this.TransactionsA.SelectedIndexChanged += new System.EventHandler(this.TransactionsA_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasks Performed";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TasksA
            // 
            this.TasksA.Location = new System.Drawing.Point(338, 185);
            this.TasksA.Name = "TasksA";
            this.TasksA.Size = new System.Drawing.Size(271, 165);
            this.TasksA.TabIndex = 5;
            this.TasksA.UseCompatibleStateImageBehavior = false;
            this.TasksA.View = System.Windows.Forms.View.List;
            this.TasksA.SelectedIndexChanged += new System.EventHandler(this.TasksA_SelectedIndexChanged);
            // 
            // btnAddTransactions
            // 
            this.btnAddTransactions.Location = new System.Drawing.Point(409, 76);
            this.btnAddTransactions.Name = "btnAddTransactions";
            this.btnAddTransactions.Size = new System.Drawing.Size(161, 23);
            this.btnAddTransactions.TabIndex = 6;
            this.btnAddTransactions.Text = "Add Transactions";
            this.btnAddTransactions.UseVisualStyleBackColor = true;
            this.btnAddTransactions.Click += new System.EventHandler(this.btnAddTransactions_Click);
            // 
            // DeleteTrans
            // 
            this.DeleteTrans.Location = new System.Drawing.Point(494, 356);
            this.DeleteTrans.Name = "DeleteTrans";
            this.DeleteTrans.Size = new System.Drawing.Size(114, 33);
            this.DeleteTrans.TabIndex = 7;
            this.DeleteTrans.Text = "DeleteTransactions";
            this.DeleteTrans.UseVisualStyleBackColor = true;
            this.DeleteTrans.Click += new System.EventHandler(this.DeleteTrans_Click);
            // 
            // ActionA
            // 
            this.ActionA.Location = new System.Drawing.Point(34, 185);
            this.ActionA.Name = "ActionA";
            this.ActionA.Size = new System.Drawing.Size(271, 165);
            this.ActionA.TabIndex = 8;
            this.ActionA.UseCompatibleStateImageBehavior = false;
            this.ActionA.View = System.Windows.Forms.View.List;
            this.ActionA.SelectedIndexChanged += new System.EventHandler(this.ActionA_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Actions to be taken";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(409, 105);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(161, 23);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "FinishTransactions";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(409, 50);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 11;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // AddRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 408);
            this.Controls.Add(this.date);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ActionA);
            this.Controls.Add(this.DeleteTrans);
            this.Controls.Add(this.btnAddTransactions);
            this.Controls.Add(this.TasksA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransactionsA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBxDamageA);
            this.Controls.Add(this.label1);
            this.Name = "AddRepair";
            this.Text = "AddRepair";
            this.Load += new System.EventHandler(this.TransactionsB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxDamageA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransactionsA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView TasksA;
        private System.Windows.Forms.Button btnAddTransactions;
        private System.Windows.Forms.Button DeleteTrans;
        private System.Windows.Forms.ListView ActionA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}