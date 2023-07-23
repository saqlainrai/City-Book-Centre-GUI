namespace CityBookCentre.UserMenu
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTerminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.iconCross = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lendBook1 = new CityBookCentre.UserMenu.lendBook();
            this.feedback1 = new CityBookCentre.UserMenu.feedback();
            this.previousOrders1 = new CityBookCentre.UserMenu.previousOrders();
            this.cart1 = new CityBookCentre.UserMenu.cart();
            this.purchaseBook1 = new CityBookCentre.UserMenu.PurchaseBook();
            this.welcome1 = new CityBookCentre.Admin.welcome();
            this.listOfBooks1 = new CityBookCentre.Admin.ListOfBooks();
            this.addBook1 = new CityBookCentre.Admin.AddBook();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCross)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Aquamarine;
            this.panelHeader.Controls.Add(this.header);
            this.panelHeader.Location = new System.Drawing.Point(270, 122);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1031, 60);
            this.panelHeader.TabIndex = 15;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Gotham Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(440, 11);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(119, 38);
            this.header.TabIndex = 6;
            this.header.Text = "Home";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Controls.Add(this.lendBook1);
            this.panelMain.Controls.Add(this.feedback1);
            this.panelMain.Controls.Add(this.previousOrders1);
            this.panelMain.Controls.Add(this.cart1);
            this.panelMain.Controls.Add(this.purchaseBook1);
            this.panelMain.Controls.Add(this.welcome1);
            this.panelMain.Controls.Add(this.listOfBooks1);
            this.panelMain.Controls.Add(this.addBook1);
            this.panelMain.Location = new System.Drawing.Point(271, 182);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1027, 542);
            this.panelMain.TabIndex = 16;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.btnList);
            this.panelMenu.Controls.Add(this.btnReviews);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnLend);
            this.panelMenu.Controls.Add(this.btnPurchase);
            this.panelMenu.Controls.Add(this.btnCart);
            this.panelMenu.Location = new System.Drawing.Point(1, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 692);
            this.panelMenu.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.iconCross);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.ForeColor = System.Drawing.Color.Moccasin;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 30);
            this.panel1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinTabToolStripMenuItem,
            this.dockToolStripMenuItem,
            this.updateTerminalToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // pinTabToolStripMenuItem
            // 
            this.pinTabToolStripMenuItem.Name = "pinTabToolStripMenuItem";
            this.pinTabToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.pinTabToolStripMenuItem.Text = "Pin Tab";
            // 
            // dockToolStripMenuItem
            // 
            this.dockToolStripMenuItem.Name = "dockToolStripMenuItem";
            this.dockToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.dockToolStripMenuItem.Text = "Dock";
            // 
            // updateTerminalToolStripMenuItem
            // 
            this.updateTerminalToolStripMenuItem.Name = "updateTerminalToolStripMenuItem";
            this.updateTerminalToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.updateTerminalToolStripMenuItem.Text = "Update Terminal";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.getHelpToolStripMenuItem,
            this.aboutProgramToolStripMenuItem,
            this.privacyToolStripMenuItem,
            this.whatsNewToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // getHelpToolStripMenuItem
            // 
            this.getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            this.getHelpToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.getHelpToolStripMenuItem.Text = "Get Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            // 
            // privacyToolStripMenuItem
            // 
            this.privacyToolStripMenuItem.Name = "privacyToolStripMenuItem";
            this.privacyToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.privacyToolStripMenuItem.Text = "Privacy";
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.whatsNewToolStripMenuItem.Text = "What\'s New";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(271, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1031, 90);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell Extra Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "City Book Centre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseHover);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Image = global::CityBookCentre.Properties.Resources.purchased;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(0, 363);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(270, 55);
            this.btnOrders.TabIndex = 9;
            this.btnOrders.Text = "View My Previous Orders";
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CityBookCentre.Properties.Resources.icon_main;
            this.pictureBox1.Image = global::CityBookCentre.Properties.Resources.icon_main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnList
            // 
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = global::CityBookCentre.Properties.Resources.list;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnList.Location = new System.Drawing.Point(0, 150);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(270, 55);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "View List of Books";
            this.btnList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnList.UseCompatibleTextRendering = true;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.Image = global::CityBookCentre.Properties.Resources.tip;
            this.btnReviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviews.Location = new System.Drawing.Point(0, 416);
            this.btnReviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(270, 55);
            this.btnReviews.TabIndex = 5;
            this.btnReviews.Text = "Reviews/Suggestions";
            this.btnReviews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReviews.UseVisualStyleBackColor = true;
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::CityBookCentre.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 470);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnLend
            // 
            this.btnLend.FlatAppearance.BorderSize = 0;
            this.btnLend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLend.Image = global::CityBookCentre.Properties.Resources.update;
            this.btnLend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLend.Location = new System.Drawing.Point(0, 310);
            this.btnLend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(270, 55);
            this.btnLend.TabIndex = 3;
            this.btnLend.Text = "Lend a Book";
            this.btnLend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchase.Image")));
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(0, 204);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(270, 55);
            this.btnPurchase.TabIndex = 1;
            this.btnPurchase.Text = "Purchase a Book";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = global::CityBookCentre.Properties.Resources.bin;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 257);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(270, 55);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "View Your Cart";
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // iconCross
            // 
            this.iconCross.BackColor = System.Drawing.Color.Red;
            this.iconCross.Location = new System.Drawing.Point(1269, 2);
            this.iconCross.Name = "iconCross";
            this.iconCross.Size = new System.Drawing.Size(26, 26);
            this.iconCross.TabIndex = 0;
            this.iconCross.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotham Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lendBook1
            // 
            this.lendBook1.Location = new System.Drawing.Point(-1, -7);
            this.lendBook1.Name = "lendBook1";
            this.lendBook1.Size = new System.Drawing.Size(1047, 615);
            this.lendBook1.TabIndex = 7;
            // 
            // feedback1
            // 
            this.feedback1.Location = new System.Drawing.Point(127, -23);
            this.feedback1.Name = "feedback1";
            this.feedback1.Size = new System.Drawing.Size(777, 571);
            this.feedback1.TabIndex = 6;
            // 
            // previousOrders1
            // 
            this.previousOrders1.Location = new System.Drawing.Point(297, -14);
            this.previousOrders1.Name = "previousOrders1";
            this.previousOrders1.Size = new System.Drawing.Size(732, 672);
            this.previousOrders1.TabIndex = 5;
            // 
            // cart1
            // 
            this.cart1.Location = new System.Drawing.Point(-36, 3);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(1067, 524);
            this.cart1.TabIndex = 4;
            // 
            // purchaseBook1
            // 
            this.purchaseBook1.Location = new System.Drawing.Point(51, 5);
            this.purchaseBook1.Name = "purchaseBook1";
            this.purchaseBook1.Size = new System.Drawing.Size(931, 603);
            this.purchaseBook1.TabIndex = 3;
            this.purchaseBook1.Visible = false;
            // 
            // welcome1
            // 
            this.welcome1.Location = new System.Drawing.Point(49, 5);
            this.welcome1.Name = "welcome1";
            this.welcome1.Size = new System.Drawing.Size(933, 464);
            this.welcome1.TabIndex = 2;
            // 
            // listOfBooks1
            // 
            this.listOfBooks1.Location = new System.Drawing.Point(76, -23);
            this.listOfBooks1.Name = "listOfBooks1";
            this.listOfBooks1.Size = new System.Drawing.Size(897, 565);
            this.listOfBooks1.TabIndex = 1;
            this.listOfBooks1.Visible = false;
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(76, 29);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(828, 433);
            this.addBook1.TabIndex = 0;
            this.addBook1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 709);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Admin.ListOfBooks listOfBooks1;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panelMain;
        private Admin.AddBook addBook1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconCross;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTerminalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Admin.welcome welcome1;
        private PurchaseBook purchaseBook1;
        private cart cart1;
        private previousOrders previousOrders1;
        private feedback feedback1;
        private lendBook lendBook1;
        private System.Windows.Forms.Label label1;
    }
}