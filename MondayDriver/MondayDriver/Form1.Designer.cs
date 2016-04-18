namespace MondayDriver
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
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.Label();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drive";
            // 
            // pathTextBox
            // 
            this.pathTextBox.AutoSize = true;
            this.pathTextBox.Location = new System.Drawing.Point(85, 39);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(29, 13);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "Path";
            // 
            // drivesComboBox
            // 
            this.drivesComboBox.FormattingEnabled = true;
            this.drivesComboBox.Location = new System.Drawing.Point(186, 8);
            this.drivesComboBox.Name = "drivesComboBox";
            this.drivesComboBox.Size = new System.Drawing.Size(247, 21);
            this.drivesComboBox.TabIndex = 2;
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.Location = new System.Drawing.Point(12, 66);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(421, 186);
            this.directoryListBox.TabIndex = 3;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 264);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(121, 264);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(186, 36);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(247, 20);
            this.pathBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 305);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.directoryListBox);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pathTextBox;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox pathBox;
    }
}

