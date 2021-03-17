namespace IT499_Project
{
    partial class form1
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.workOrderLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.workOrderBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.agentLabel = new System.Windows.Forms.Label();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.estimatedTimeLabel = new System.Windows.Forms.Label();
            this.actualTimeLabel = new System.Windows.Forms.Label();
            this.estimatedCostLabel = new System.Windows.Forms.Label();
            this.actualCostLabel = new System.Windows.Forms.Label();
            this.followupDateLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.followupDetailsLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.RichTextBox();
            this.followupDetailsBox = new System.Windows.Forms.RichTextBox();
            this.resolutionBox = new System.Windows.Forms.RichTextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.agentBox = new System.Windows.Forms.TextBox();
            this.technicianBox = new System.Windows.Forms.TextBox();
            this.startDateBox = new System.Windows.Forms.TextBox();
            this.followupDateBox = new System.Windows.Forms.TextBox();
            this.estimatedTimeBox = new System.Windows.Forms.TextBox();
            this.actualTimeBox = new System.Windows.Forms.TextBox();
            this.estimateCostBox = new System.Windows.Forms.TextBox();
            this.actualCostBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.newCustomerButton = new System.Windows.Forms.Button();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(93, 26);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(93, 67);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(16, 26);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(16, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(227, 48);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Location = new System.Drawing.Point(326, 48);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // workOrderLabel
            // 
            this.workOrderLabel.AutoSize = true;
            this.workOrderLabel.Location = new System.Drawing.Point(16, 192);
            this.workOrderLabel.Name = "workOrderLabel";
            this.workOrderLabel.Size = new System.Drawing.Size(105, 13);
            this.workOrderLabel.TabIndex = 6;
            this.workOrderLabel.Text = "Work Order Number:";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(16, 218);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(85, 13);
            this.customerLabel.TabIndex = 8;
            this.customerLabel.Text = "Customer Name:";
            // 
            // workOrderBox
            // 
            this.workOrderBox.Enabled = false;
            this.workOrderBox.Location = new System.Drawing.Point(172, 192);
            this.workOrderBox.Name = "workOrderBox";
            this.workOrderBox.Size = new System.Drawing.Size(213, 20);
            this.workOrderBox.TabIndex = 9;
            // 
            // customerBox
            // 
            this.customerBox.Enabled = false;
            this.customerBox.Location = new System.Drawing.Point(172, 218);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(213, 20);
            this.customerBox.TabIndex = 10;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(16, 244);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(95, 13);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Customer Address:";
            // 
            // agentLabel
            // 
            this.agentLabel.AutoSize = true;
            this.agentLabel.Location = new System.Drawing.Point(16, 270);
            this.agentLabel.Name = "agentLabel";
            this.agentLabel.Size = new System.Drawing.Size(84, 13);
            this.agentLabel.TabIndex = 12;
            this.agentLabel.Text = "Agent Assigned:";
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(16, 296);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(109, 13);
            this.technicianLabel.TabIndex = 13;
            this.technicianLabel.Text = "Technician Assigned:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(16, 348);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 14;
            this.startDateLabel.Text = "Start Date:";
            // 
            // estimatedTimeLabel
            // 
            this.estimatedTimeLabel.AutoSize = true;
            this.estimatedTimeLabel.Location = new System.Drawing.Point(16, 374);
            this.estimatedTimeLabel.Name = "estimatedTimeLabel";
            this.estimatedTimeLabel.Size = new System.Drawing.Size(137, 13);
            this.estimatedTimeLabel.TabIndex = 15;
            this.estimatedTimeLabel.Text = "Estimated Completion Time:";
            // 
            // actualTimeLabel
            // 
            this.actualTimeLabel.AutoSize = true;
            this.actualTimeLabel.Location = new System.Drawing.Point(16, 400);
            this.actualTimeLabel.Name = "actualTimeLabel";
            this.actualTimeLabel.Size = new System.Drawing.Size(121, 13);
            this.actualTimeLabel.TabIndex = 16;
            this.actualTimeLabel.Text = "Actual Completion Time:";;
            // 
            // estimatedCostLabel
            // 
            this.estimatedCostLabel.AutoSize = true;
            this.estimatedCostLabel.Location = new System.Drawing.Point(16, 426);
            this.estimatedCostLabel.Name = "estimatedCostLabel";
            this.estimatedCostLabel.Size = new System.Drawing.Size(80, 13);
            this.estimatedCostLabel.TabIndex = 17;
            this.estimatedCostLabel.Text = "Estimated Cost:";
            // 
            // actualCostLabel
            // 
            this.actualCostLabel.AutoSize = true;
            this.actualCostLabel.Location = new System.Drawing.Point(16, 452);
            this.actualCostLabel.Name = "actualCostLabel";
            this.actualCostLabel.Size = new System.Drawing.Size(64, 13);
            this.actualCostLabel.TabIndex = 18;
            this.actualCostLabel.Text = "Actual Cost:";
            // 
            // followupDateLabel
            // 
            this.followupDateLabel.AutoSize = true;
            this.followupDateLabel.Location = new System.Drawing.Point(16, 478);
            this.followupDateLabel.Name = "followupDateLabel";
            this.followupDateLabel.Size = new System.Drawing.Size(83, 13);
            this.followupDateLabel.TabIndex = 19;
            this.followupDateLabel.Text = "Follow-Up Date:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(16, 504);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(88, 13);
            this.ratingLabel.TabIndex = 20;
            this.ratingLabel.Text = "Customer Rating:";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(400, 183);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(42, 13);
            this.detailsLabel.TabIndex = 21;
            this.detailsLabel.Text = "Details:";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(400, 321);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(60, 13);
            this.resolutionLabel.TabIndex = 22;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // followupDetailsLabel
            // 
            this.followupDetailsLabel.AutoSize = true;
            this.followupDetailsLabel.Location = new System.Drawing.Point(400, 464);
            this.followupDetailsLabel.Name = "followupDetailsLabel";
            this.followupDetailsLabel.Size = new System.Drawing.Size(92, 13);
            this.followupDetailsLabel.TabIndex = 23;
            this.followupDetailsLabel.Text = "Follow-Up Details:";
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(165, 608);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(107, 23);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update Information";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(391, 608);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add Work Order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(612, 608);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete Work Order";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(227, 133);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(24, 23);
            this.nextButton.TabIndex = 27;
            this.nextButton.Text = "+";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(104, 133);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(24, 23);
            this.previousButton.TabIndex = 28;
            this.previousButton.Text = "-";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.Enabled = false;
            this.detailsBox.Location = new System.Drawing.Point(498, 180);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(390, 129);
            this.detailsBox.TabIndex = 29;
            this.detailsBox.Text = "";
            // 
            // followupDetailsBox
            // 
            this.followupDetailsBox.Enabled = false;
            this.followupDetailsBox.Location = new System.Drawing.Point(498, 461);
            this.followupDetailsBox.Name = "followupDetailsBox";
            this.followupDetailsBox.Size = new System.Drawing.Size(390, 129);
            this.followupDetailsBox.TabIndex = 30;
            this.followupDetailsBox.Text = "";
            // 
            // resolutionBox
            // 
            this.resolutionBox.Enabled = false;
            this.resolutionBox.Location = new System.Drawing.Point(498, 318);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(390, 129);
            this.resolutionBox.TabIndex = 31;
            this.resolutionBox.Text = "";
            // 
            // addressBox
            // 
            this.addressBox.Enabled = false;
            this.addressBox.Location = new System.Drawing.Point(172, 244);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(213, 20);
            this.addressBox.TabIndex = 32;
            // 
            // agentBox
            // 
            this.agentBox.Enabled = false;
            this.agentBox.Location = new System.Drawing.Point(172, 270);
            this.agentBox.Name = "agentBox";
            this.agentBox.Size = new System.Drawing.Size(213, 20);
            this.agentBox.TabIndex = 33;
            // 
            // technicianBox
            // 
            this.technicianBox.Enabled = false;
            this.technicianBox.Location = new System.Drawing.Point(172, 296);
            this.technicianBox.Name = "technicianBox";
            this.technicianBox.Size = new System.Drawing.Size(213, 20);
            this.technicianBox.TabIndex = 34;
            // 
            // startDateBox
            // 
            this.startDateBox.Enabled = false;
            this.startDateBox.Location = new System.Drawing.Point(172, 348);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(100, 20);
            this.startDateBox.TabIndex = 35;
            // 
            // followupDateBox
            // 
            this.followupDateBox.Enabled = false;
            this.followupDateBox.Location = new System.Drawing.Point(172, 478);
            this.followupDateBox.Name = "followupDateBox";
            this.followupDateBox.Size = new System.Drawing.Size(100, 20);
            this.followupDateBox.TabIndex = 36;;
            // 
            // estimatedTimeBox
            // 
            this.estimatedTimeBox.Enabled = false;
            this.estimatedTimeBox.Location = new System.Drawing.Point(172, 374);
            this.estimatedTimeBox.Name = "estimatedTimeBox";
            this.estimatedTimeBox.Size = new System.Drawing.Size(100, 20);
            this.estimatedTimeBox.TabIndex = 37;
            // 
            // actualTimeBox
            // 
            this.actualTimeBox.Enabled = false;
            this.actualTimeBox.Location = new System.Drawing.Point(172, 400);
            this.actualTimeBox.Name = "actualTimeBox";
            this.actualTimeBox.Size = new System.Drawing.Size(100, 20);
            this.actualTimeBox.TabIndex = 38;
            // 
            // estimateCostBox
            // 
            this.estimateCostBox.Enabled = false;
            this.estimateCostBox.Location = new System.Drawing.Point(172, 426);
            this.estimateCostBox.Name = "estimateCostBox";
            this.estimateCostBox.Size = new System.Drawing.Size(100, 20);
            this.estimateCostBox.TabIndex = 39;
            // 
            // actualCostBox
            // 
            this.actualCostBox.Enabled = false;
            this.actualCostBox.Location = new System.Drawing.Point(172, 452);
            this.actualCostBox.Name = "actualCostBox";
            this.actualCostBox.Size = new System.Drawing.Size(100, 20);
            this.actualCostBox.TabIndex = 40;
            // 
            // ratingBox
            // 
            this.ratingBox.Enabled = false;
            this.ratingBox.Location = new System.Drawing.Point(172, 504);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(100, 20);
            this.ratingBox.TabIndex = 41;
            // 
            // selectButton
            // 
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(278, 608);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(107, 23);
            this.selectButton.TabIndex = 42;
            this.selectButton.Text = "Select Work Order";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // newCustomerButton
            // 
            this.newCustomerButton.Enabled = false;
            this.newCustomerButton.Location = new System.Drawing.Point(499, 608);
            this.newCustomerButton.Name = "newCustomerButton";
            this.newCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.newCustomerButton.TabIndex = 43;
            this.newCustomerButton.Text = "Add New Customer";
            this.newCustomerButton.UseVisualStyleBackColor = true;
            this.newCustomerButton.Click += new System.EventHandler(this.newCustomerButton_Click);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(16, 322);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(89, 13);
            this.rateLabel.TabIndex = 44;
            this.rateLabel.Text = "Technician Rate:";
            // 
            // rateBox
            // 
            this.rateBox.Enabled = false;
            this.rateBox.Location = new System.Drawing.Point(172, 322);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(100, 20);
            this.rateBox.TabIndex = 45;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 737);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.newCustomerButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.actualCostBox);
            this.Controls.Add(this.estimateCostBox);
            this.Controls.Add(this.actualTimeBox);
            this.Controls.Add(this.estimatedTimeBox);
            this.Controls.Add(this.followupDateBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.technicianBox);
            this.Controls.Add(this.agentBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.resolutionBox);
            this.Controls.Add(this.followupDetailsBox);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.followupDetailsLabel);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.detailsLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.followupDateLabel);
            this.Controls.Add(this.actualCostLabel);
            this.Controls.Add(this.estimatedCostLabel);
            this.Controls.Add(this.actualTimeLabel);
            this.Controls.Add(this.estimatedTimeLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.agentLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.workOrderBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.workOrderLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "form1";
            this.Text = "Form1";;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label workOrderLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox workOrderBox;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label agentLabel;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label estimatedTimeLabel;
        private System.Windows.Forms.Label actualTimeLabel;
        private System.Windows.Forms.Label estimatedCostLabel;
        private System.Windows.Forms.Label actualCostLabel;
        private System.Windows.Forms.Label followupDateLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Label followupDetailsLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.RichTextBox detailsBox;
        private System.Windows.Forms.RichTextBox followupDetailsBox;
        private System.Windows.Forms.RichTextBox resolutionBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox agentBox;
        private System.Windows.Forms.TextBox technicianBox;
        private System.Windows.Forms.TextBox startDateBox;
        private System.Windows.Forms.TextBox followupDateBox;
        private System.Windows.Forms.TextBox estimatedTimeBox;
        private System.Windows.Forms.TextBox actualTimeBox;
        private System.Windows.Forms.TextBox estimateCostBox;
        private System.Windows.Forms.TextBox actualCostBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button newCustomerButton;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox rateBox;
    }
}

