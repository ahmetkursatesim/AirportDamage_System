namespace AirportDamage_S
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Damageinformation = new System.Windows.Forms.ToolStripMenuItem();
            this.Damagerecording = new System.Windows.Forms.ToolStripMenuItem();
            this.Delivery = new System.Windows.Forms.ToolStripMenuItem();
            this.ListDamage = new System.Windows.Forms.ToolStripMenuItem();
            this.airportRunwayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Repairs = new System.Windows.Forms.ToolStripMenuItem();
            this.newRecordTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.Transactions = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDamageType = new System.Windows.Forms.ToolStripMenuItem();
            this.NewRecordT = new System.Windows.Forms.ToolStripMenuItem();
            this.NewComp = new System.Windows.Forms.ToolStripMenuItem();
            this.NewaddWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Damageinformation,
            this.Repairs,
            this.Transactions,
            this.costToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // Damageinformation
            // 
            this.Damageinformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Damagerecording,
            this.Delivery,
            this.ListDamage,
            this.airportRunwayToolStripMenuItem});
            this.Damageinformation.Name = "Damageinformation";
            this.Damageinformation.Size = new System.Drawing.Size(126, 20);
            this.Damageinformation.Text = "DamageInformation";
            this.Damageinformation.Click += new System.EventHandler(this.Damageinformation_Click);
            // 
            // Damagerecording
            // 
            this.Damagerecording.Name = "Damagerecording";
            this.Damagerecording.Size = new System.Drawing.Size(178, 22);
            this.Damagerecording.Text = "Damage  Recording";
            this.Damagerecording.Click += new System.EventHandler(this.Damagerecording_Click_1);
            // 
            // Delivery
            // 
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(178, 22);
            this.Delivery.Text = "Delivery";
            this.Delivery.Click += new System.EventHandler(this.Delivery_Click);
            // 
            // ListDamage
            // 
            this.ListDamage.Name = "ListDamage";
            this.ListDamage.Size = new System.Drawing.Size(178, 22);
            this.ListDamage.Text = "ListDamageRecord";
            this.ListDamage.Click += new System.EventHandler(this.ListDamage_Click);
            // 
            // airportRunwayToolStripMenuItem
            // 
            this.airportRunwayToolStripMenuItem.Name = "airportRunwayToolStripMenuItem";
            this.airportRunwayToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.airportRunwayToolStripMenuItem.Text = "AirportRunway";
            this.airportRunwayToolStripMenuItem.Click += new System.EventHandler(this.airportRunwayToolStripMenuItem_Click);
            // 
            // Repairs
            // 
            this.Repairs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRecordTransactions});
            this.Repairs.Name = "Repairs";
            this.Repairs.Size = new System.Drawing.Size(57, 20);
            this.Repairs.Text = "Repairs";
            // 
            // newRecordTransactions
            // 
            this.newRecordTransactions.Name = "newRecordTransactions";
            this.newRecordTransactions.Size = new System.Drawing.Size(152, 22);
            this.newRecordTransactions.Text = "Make repairs";
            this.newRecordTransactions.Click += new System.EventHandler(this.newRecordTransactions_Click);
            // 
            // Transactions
            // 
            this.Transactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewDamageType,
            this.NewRecordT,
            this.NewComp,
            this.NewaddWorker,
            this.DeleteWorker});
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(85, 20);
            this.Transactions.Text = "Transactions";
            // 
            // NewDamageType
            // 
            this.NewDamageType.Name = "NewDamageType";
            this.NewDamageType.Size = new System.Drawing.Size(201, 22);
            this.NewDamageType.Text = "NewDamageType";
            this.NewDamageType.Click += new System.EventHandler(this.NewDamageType_Click);
            // 
            // NewRecordT
            // 
            this.NewRecordT.Name = "NewRecordT";
            this.NewRecordT.Size = new System.Drawing.Size(201, 22);
            this.NewRecordT.Text = "NewRecordTransactions";
            this.NewRecordT.Click += new System.EventHandler(this.NewRecordT_Click);
            // 
            // NewComp
            // 
            this.NewComp.Name = "NewComp";
            this.NewComp.Size = new System.Drawing.Size(201, 22);
            this.NewComp.Text = "NewComplaint";
            this.NewComp.Click += new System.EventHandler(this.NewComp_Click);
            // 
            // NewaddWorker
            // 
            this.NewaddWorker.Name = "NewaddWorker";
            this.NewaddWorker.Size = new System.Drawing.Size(201, 22);
            this.NewaddWorker.Text = "AddWorker";
            this.NewaddWorker.Click += new System.EventHandler(this.NewaddWorker_Click);
            // 
            // DeleteWorker
            // 
            this.DeleteWorker.Name = "DeleteWorker";
            this.DeleteWorker.Size = new System.Drawing.Size(201, 22);
            this.DeleteWorker.Text = "DeleteWorker";
            this.DeleteWorker.Click += new System.EventHandler(this.DeleteWorker_Click);
            // 
            // costToolStripMenuItem
            // 
            this.costToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.costToolStripMenuItem1});
            this.costToolStripMenuItem.Name = "costToolStripMenuItem";
            this.costToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.costToolStripMenuItem.Text = "Cost";
            // 
            // costToolStripMenuItem1
            // 
            this.costToolStripMenuItem1.Name = "costToolStripMenuItem1";
            this.costToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.costToolStripMenuItem1.Text = "Cost ";
            this.costToolStripMenuItem1.Click += new System.EventHandler(this.costToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(103, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "AirPortDamage Information System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AirportDamage_S.Properties.Resources.dhmi_logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Home";
            this.Text = "AirPortDamage Information System";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Damageinformation;
        private System.Windows.Forms.ToolStripMenuItem Damagerecording;
        private System.Windows.Forms.ToolStripMenuItem Delivery;
        private System.Windows.Forms.ToolStripMenuItem ListDamage;
        private System.Windows.Forms.ToolStripMenuItem Repairs;
        private System.Windows.Forms.ToolStripMenuItem newRecordTransactions;
        private System.Windows.Forms.ToolStripMenuItem Transactions;
        private System.Windows.Forms.ToolStripMenuItem NewDamageType;
        private System.Windows.Forms.ToolStripMenuItem NewRecordT;
        private System.Windows.Forms.ToolStripMenuItem NewComp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem NewaddWorker;
        private System.Windows.Forms.ToolStripMenuItem DeleteWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem airportRunwayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem costToolStripMenuItem1;
    }
}

