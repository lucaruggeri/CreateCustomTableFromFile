namespace CreateCustomTableFromFile
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
            this.objFileButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.objCreate = new System.Windows.Forms.Button();
            this.objMessage = new System.Windows.Forms.Label();
            this.objList = new System.Windows.Forms.ListBox();
            this.objQuery = new System.Windows.Forms.TextBox();
            this.objSeparatorCheck = new System.Windows.Forms.CheckBox();
            this.objSeparator = new System.Windows.Forms.TextBox();
            this.objTableName = new System.Windows.Forms.TextBox();
            this.objTableNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // objFileButton
            // 
            this.objFileButton.Location = new System.Drawing.Point(655, 59);
            this.objFileButton.Name = "objFileButton";
            this.objFileButton.Size = new System.Drawing.Size(75, 23);
            this.objFileButton.TabIndex = 0;
            this.objFileButton.Text = "Load file";
            this.objFileButton.UseVisualStyleBackColor = true;
            this.objFileButton.Click += new System.EventHandler(this.objFileButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 20);
            this.textBox1.TabIndex = 1;
            // 
            // objCreate
            // 
            this.objCreate.Location = new System.Drawing.Point(655, 129);
            this.objCreate.Name = "objCreate";
            this.objCreate.Size = new System.Drawing.Size(75, 23);
            this.objCreate.TabIndex = 2;
            this.objCreate.Text = "Create query";
            this.objCreate.UseVisualStyleBackColor = true;
            this.objCreate.Click += new System.EventHandler(this.objCreate_Click);
            // 
            // objMessage
            // 
            this.objMessage.AutoSize = true;
            this.objMessage.Location = new System.Drawing.Point(12, 101);
            this.objMessage.Name = "objMessage";
            this.objMessage.Size = new System.Drawing.Size(28, 13);
            this.objMessage.TabIndex = 3;
            this.objMessage.Text = "XXX";
            // 
            // objList
            // 
            this.objList.FormattingEnabled = true;
            this.objList.Location = new System.Drawing.Point(15, 116);
            this.objList.Name = "objList";
            this.objList.Size = new System.Drawing.Size(353, 407);
            this.objList.TabIndex = 4;
            // 
            // objQuery
            // 
            this.objQuery.Location = new System.Drawing.Point(374, 159);
            this.objQuery.Multiline = true;
            this.objQuery.Name = "objQuery";
            this.objQuery.Size = new System.Drawing.Size(356, 365);
            this.objQuery.TabIndex = 6;
            // 
            // objSeparatorCheck
            // 
            this.objSeparatorCheck.AutoSize = true;
            this.objSeparatorCheck.Location = new System.Drawing.Point(12, 29);
            this.objSeparatorCheck.Name = "objSeparatorCheck";
            this.objSeparatorCheck.Size = new System.Drawing.Size(154, 17);
            this.objSeparatorCheck.TabIndex = 7;
            this.objSeparatorCheck.Text = "Separator is the charachter";
            this.objSeparatorCheck.UseVisualStyleBackColor = true;
            this.objSeparatorCheck.CheckedChanged += new System.EventHandler(this.objSeparatorCheck_CheckedChanged);
            // 
            // objSeparator
            // 
            this.objSeparator.Location = new System.Drawing.Point(172, 29);
            this.objSeparator.Name = "objSeparator";
            this.objSeparator.Size = new System.Drawing.Size(45, 20);
            this.objSeparator.TabIndex = 8;
            // 
            // objTableName
            // 
            this.objTableName.Location = new System.Drawing.Point(374, 132);
            this.objTableName.Name = "objTableName";
            this.objTableName.Size = new System.Drawing.Size(100, 20);
            this.objTableName.TabIndex = 9;
            // 
            // objTableNameLabel
            // 
            this.objTableNameLabel.AutoSize = true;
            this.objTableNameLabel.Location = new System.Drawing.Point(375, 116);
            this.objTableNameLabel.Name = "objTableNameLabel";
            this.objTableNameLabel.Size = new System.Drawing.Size(63, 13);
            this.objTableNameLabel.TabIndex = 10;
            this.objTableNameLabel.Text = "Table name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 536);
            this.Controls.Add(this.objTableNameLabel);
            this.Controls.Add(this.objTableName);
            this.Controls.Add(this.objSeparator);
            this.Controls.Add(this.objSeparatorCheck);
            this.Controls.Add(this.objQuery);
            this.Controls.Add(this.objList);
            this.Controls.Add(this.objMessage);
            this.Controls.Add(this.objCreate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.objFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button objFileButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button objCreate;
        private System.Windows.Forms.Label objMessage;
        private System.Windows.Forms.ListBox objList;
        private System.Windows.Forms.TextBox objQuery;
        private System.Windows.Forms.CheckBox objSeparatorCheck;
        private System.Windows.Forms.TextBox objSeparator;
        private System.Windows.Forms.TextBox objTableName;
        private System.Windows.Forms.Label objTableNameLabel;
    }
}

