namespace SpecialAssignment
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
            this.customerName = new System.Windows.Forms.TextBox();
            this.customerPhone = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pepperoni = new System.Windows.Forms.CheckBox();
            this.bacon = new System.Windows.Forms.CheckBox();
            this.mushroom = new System.Windows.Forms.CheckBox();
            this.onion = new System.Windows.Forms.CheckBox();
            this.greenPepper = new System.Windows.Forms.CheckBox();
            this.pineapple = new System.Windows.Forms.CheckBox();
            this.olive = new System.Windows.Forms.CheckBox();
            this.chicken = new System.Windows.Forms.CheckBox();
            this.cheese = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crustPanel = new System.Windows.Forms.Panel();
            this.crust = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadsticksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delivery = new System.Windows.Forms.RadioButton();
            this.carryOut = new System.Windows.Forms.RadioButton();
            this.sizePanel = new System.Windows.Forms.Panel();
            this.sizeL = new System.Windows.Forms.RadioButton();
            this.sizeM = new System.Windows.Forms.RadioButton();
            this.sizeS = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ham = new System.Windows.Forms.CheckBox();
            this.pizza = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.crustPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sizePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(68, 30);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 0;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // customerPhone
            // 
            this.customerPhone.Location = new System.Drawing.Point(238, 30);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(100, 20);
            this.customerPhone.TabIndex = 1;
            this.customerPhone.TextChanged += new System.EventHandler(this.customerPhone_TextChanged);
            // 
            // customerAddress
            // 
            this.customerAddress.Location = new System.Drawing.Point(421, 30);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(100, 20);
            this.customerAddress.TabIndex = 2;
            this.customerAddress.TextChanged += new System.EventHandler(this.customerAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toppings";
            // 
            // pepperoni
            // 
            this.pepperoni.AutoSize = true;
            this.pepperoni.Location = new System.Drawing.Point(30, 75);
            this.pepperoni.Name = "pepperoni";
            this.pepperoni.Size = new System.Drawing.Size(74, 17);
            this.pepperoni.TabIndex = 3;
            this.pepperoni.Text = "Pepperoni";
            this.pepperoni.UseVisualStyleBackColor = true;
            this.pepperoni.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bacon
            // 
            this.bacon.AutoSize = true;
            this.bacon.Location = new System.Drawing.Point(30, 98);
            this.bacon.Name = "bacon";
            this.bacon.Size = new System.Drawing.Size(57, 17);
            this.bacon.TabIndex = 4;
            this.bacon.Text = "Bacon";
            this.bacon.UseVisualStyleBackColor = true;
            this.bacon.CheckedChanged += new System.EventHandler(this.bacon_CheckedChanged);
            // 
            // mushroom
            // 
            this.mushroom.AutoSize = true;
            this.mushroom.Location = new System.Drawing.Point(30, 121);
            this.mushroom.Name = "mushroom";
            this.mushroom.Size = new System.Drawing.Size(75, 17);
            this.mushroom.TabIndex = 5;
            this.mushroom.Text = "Mushroom";
            this.mushroom.UseVisualStyleBackColor = true;
            this.mushroom.CheckedChanged += new System.EventHandler(this.mushroom_CheckedChanged);
            // 
            // onion
            // 
            this.onion.AutoSize = true;
            this.onion.Location = new System.Drawing.Point(30, 144);
            this.onion.Name = "onion";
            this.onion.Size = new System.Drawing.Size(54, 17);
            this.onion.TabIndex = 6;
            this.onion.Text = "Onion";
            this.onion.UseVisualStyleBackColor = true;
            this.onion.CheckedChanged += new System.EventHandler(this.onion_CheckedChanged);
            // 
            // greenPepper
            // 
            this.greenPepper.AutoSize = true;
            this.greenPepper.Location = new System.Drawing.Point(30, 188);
            this.greenPepper.Name = "greenPepper";
            this.greenPepper.Size = new System.Drawing.Size(92, 17);
            this.greenPepper.TabIndex = 8;
            this.greenPepper.Text = "Green Pepper";
            this.greenPepper.UseVisualStyleBackColor = true;
            this.greenPepper.CheckedChanged += new System.EventHandler(this.greenPepper_CheckedChanged);
            // 
            // pineapple
            // 
            this.pineapple.AutoSize = true;
            this.pineapple.Location = new System.Drawing.Point(30, 211);
            this.pineapple.Name = "pineapple";
            this.pineapple.Size = new System.Drawing.Size(73, 17);
            this.pineapple.TabIndex = 9;
            this.pineapple.Text = "Pineapple";
            this.pineapple.UseVisualStyleBackColor = true;
            this.pineapple.CheckedChanged += new System.EventHandler(this.pineapple_CheckedChanged);
            // 
            // olive
            // 
            this.olive.AutoSize = true;
            this.olive.Location = new System.Drawing.Point(30, 234);
            this.olive.Name = "olive";
            this.olive.Size = new System.Drawing.Size(50, 17);
            this.olive.TabIndex = 10;
            this.olive.Text = "Olive";
            this.olive.UseVisualStyleBackColor = true;
            this.olive.CheckedChanged += new System.EventHandler(this.olive_CheckedChanged);
            // 
            // chicken
            // 
            this.chicken.AutoSize = true;
            this.chicken.Location = new System.Drawing.Point(30, 257);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(65, 17);
            this.chicken.TabIndex = 11;
            this.chicken.Text = "Chicken";
            this.chicken.UseVisualStyleBackColor = true;
            this.chicken.CheckedChanged += new System.EventHandler(this.chicken_CheckedChanged);
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Location = new System.Drawing.Point(30, 280);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(89, 17);
            this.cheese.TabIndex = 12;
            this.cheese.Text = "Extra Cheese";
            this.cheese.UseVisualStyleBackColor = true;
            this.cheese.CheckedChanged += new System.EventHandler(this.cheese_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Crust";
            // 
            // crustPanel
            // 
            this.crustPanel.Controls.Add(this.crust);
            this.crustPanel.Location = new System.Drawing.Point(161, 75);
            this.crustPanel.Name = "crustPanel";
            this.crustPanel.Size = new System.Drawing.Size(94, 40);
            this.crustPanel.TabIndex = 13;
            this.crustPanel.Tag = "";
            // 
            // crust
            // 
            this.crust.DisplayMember = "none;cajun;garlic;";
            this.crust.FormattingEnabled = true;
            this.crust.Items.AddRange(new object[] {
            "none",
            "cajun",
            "garlic"});
            this.crust.Location = new System.Drawing.Point(0, 4);
            this.crust.Name = "crust";
            this.crust.Size = new System.Drawing.Size(91, 21);
            this.crust.TabIndex = 13;
            this.crust.ValueMember = "none;cajun;garlic;";
            this.crust.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sodaToolStripMenuItem,
            this.breadsticksToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // sodaToolStripMenuItem
            // 
            this.sodaToolStripMenuItem.Name = "sodaToolStripMenuItem";
            this.sodaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sodaToolStripMenuItem.Text = "Soda";
            this.sodaToolStripMenuItem.Click += new System.EventHandler(this.sodaToolStripMenuItem_Click);
            // 
            // breadsticksToolStripMenuItem
            // 
            this.breadsticksToolStripMenuItem.Name = "breadsticksToolStripMenuItem";
            this.breadsticksToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.breadsticksToolStripMenuItem.Text = "Breadsticks";
            this.breadsticksToolStripMenuItem.Click += new System.EventHandler(this.breadsticksToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delivery);
            this.panel1.Controls.Add(this.carryOut);
            this.panel1.Location = new System.Drawing.Point(161, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 54);
            this.panel1.TabIndex = 16;
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Checked = true;
            this.delivery.Location = new System.Drawing.Point(6, 26);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(63, 17);
            this.delivery.TabIndex = 18;
            this.delivery.TabStop = true;
            this.delivery.Text = "Delivery";
            this.delivery.UseVisualStyleBackColor = true;
            this.delivery.CheckedChanged += new System.EventHandler(this.delivery_CheckedChanged);
            // 
            // carryOut
            // 
            this.carryOut.AutoSize = true;
            this.carryOut.Location = new System.Drawing.Point(6, 3);
            this.carryOut.Name = "carryOut";
            this.carryOut.Size = new System.Drawing.Size(69, 17);
            this.carryOut.TabIndex = 17;
            this.carryOut.TabStop = true;
            this.carryOut.Text = "Carry Out";
            this.carryOut.UseVisualStyleBackColor = true;
            // 
            // sizePanel
            // 
            this.sizePanel.Controls.Add(this.sizeL);
            this.sizePanel.Controls.Add(this.sizeM);
            this.sizePanel.Controls.Add(this.sizeS);
            this.sizePanel.Location = new System.Drawing.Point(161, 135);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.Size = new System.Drawing.Size(94, 85);
            this.sizePanel.TabIndex = 14;
            // 
            // sizeL
            // 
            this.sizeL.AutoSize = true;
            this.sizeL.Checked = true;
            this.sizeL.Location = new System.Drawing.Point(6, 53);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(52, 17);
            this.sizeL.TabIndex = 16;
            this.sizeL.TabStop = true;
            this.sizeL.Text = "Large";
            this.sizeL.UseVisualStyleBackColor = true;
            this.sizeL.CheckedChanged += new System.EventHandler(this.sizeL_CheckedChanged);
            // 
            // sizeM
            // 
            this.sizeM.AutoSize = true;
            this.sizeM.Location = new System.Drawing.Point(6, 31);
            this.sizeM.Name = "sizeM";
            this.sizeM.Size = new System.Drawing.Size(62, 17);
            this.sizeM.TabIndex = 15;
            this.sizeM.TabStop = true;
            this.sizeM.Text = "Medium";
            this.sizeM.UseVisualStyleBackColor = true;
            this.sizeM.CheckedChanged += new System.EventHandler(this.sizeM_CheckedChanged);
            // 
            // sizeS
            // 
            this.sizeS.AutoSize = true;
            this.sizeS.Location = new System.Drawing.Point(6, 8);
            this.sizeS.Name = "sizeS";
            this.sizeS.Size = new System.Drawing.Size(50, 17);
            this.sizeS.TabIndex = 14;
            this.sizeS.TabStop = true;
            this.sizeS.Text = "Small";
            this.sizeS.UseVisualStyleBackColor = true;
            this.sizeS.CheckedChanged += new System.EventHandler(this.sizeS_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(373, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 186);
            this.listBox1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Your Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Size";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add Pizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(373, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Place Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ham
            // 
            this.ham.AutoSize = true;
            this.ham.Location = new System.Drawing.Point(30, 165);
            this.ham.Name = "ham";
            this.ham.Size = new System.Drawing.Size(48, 17);
            this.ham.TabIndex = 7;
            this.ham.Text = "Ham";
            this.ham.UseVisualStyleBackColor = true;
            this.ham.CheckedChanged += new System.EventHandler(this.ham_CheckedChanged);
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.Location = new System.Drawing.Point(90, 300);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(65, 13);
            this.pizza.TabIndex = 25;
            this.pizza.Text = "Pizza: $0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 362);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.ham);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sizePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crustPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cheese);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.olive);
            this.Controls.Add(this.pineapple);
            this.Controls.Add(this.greenPepper);
            this.Controls.Add(this.onion);
            this.Controls.Add(this.mushroom);
            this.Controls.Add(this.bacon);
            this.Controls.Add(this.pepperoni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerPhone);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.crustPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sizePanel.ResumeLayout(false);
            this.sizePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox customerPhone;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox pepperoni;
        private System.Windows.Forms.CheckBox bacon;
        private System.Windows.Forms.CheckBox mushroom;
        private System.Windows.Forms.CheckBox onion;
        private System.Windows.Forms.CheckBox greenPepper;
        private System.Windows.Forms.CheckBox pineapple;
        private System.Windows.Forms.CheckBox olive;
        private System.Windows.Forms.CheckBox chicken;
        private System.Windows.Forms.CheckBox cheese;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel crustPanel;
        private System.Windows.Forms.ComboBox crust;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breadsticksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton delivery;
        private System.Windows.Forms.RadioButton carryOut;
        private System.Windows.Forms.Panel sizePanel;
        private System.Windows.Forms.RadioButton sizeL;
        private System.Windows.Forms.RadioButton sizeM;
        private System.Windows.Forms.RadioButton sizeS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ham;
        private System.Windows.Forms.Label pizza;
        private System.Windows.Forms.Label label8;
    }
}

