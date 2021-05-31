/* AdminCon 3.0 Command Line Interface Edition - 源代码 - GraphicalInterface.Designer.cs
 * 主要功能：Winform窗体设计文件。
 * 适用.NET版本：.NET Core 3.x 或 .NET Framework 4.x
 * (c) 2017-2021 Project Amadeus. All rights reserved.*/
namespace AdminCon_CLI_dotnetEdition.Classes.UI
{
    partial class GraphicalInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicalInterface));
            this.KILL_BUTTON = new System.Windows.Forms.Button();
            this.ProcessOps_TextBox = new System.Windows.Forms.TextBox();
            this.Process_Ops_Label = new System.Windows.Forms.Label();
            this.getpid_Button = new System.Windows.Forms.Button();
            this.runProcess_Button = new System.Windows.Forms.Button();
            this.disk_ops_Label = new System.Windows.Forms.Label();
            this.LogicalDrive1_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive8_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive7_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive6_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive5_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive4_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive3_RadioButton = new System.Windows.Forms.RadioButton();
            this.LogicalDrive2_RadioButton = new System.Windows.Forms.RadioButton();
            this.drives_ini_button = new System.Windows.Forms.Button();
            this.defrag_partition_button = new System.Windows.Forms.Button();
            this.format_partition_button = new System.Windows.Forms.Button();
            this.OpenDrive_button = new System.Windows.Forms.Button();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // KILL_BUTTON
            // 
            this.KILL_BUTTON.BackColor = System.Drawing.Color.Transparent;
            this.KILL_BUTTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KILL_BUTTON.ForeColor = System.Drawing.Color.Black;
            this.KILL_BUTTON.Location = new System.Drawing.Point(12, 69);
            this.KILL_BUTTON.Name = "KILL_BUTTON";
            this.KILL_BUTTON.Size = new System.Drawing.Size(95, 40);
            this.KILL_BUTTON.TabIndex = 0;
            this.KILL_BUTTON.Text = "Kill Process:";
            this.KILL_BUTTON.UseVisualStyleBackColor = false;
            this.KILL_BUTTON.Click += new System.EventHandler(this.KILL_BUTTON_Click);
            // 
            // ProcessOps_TextBox
            // 
            this.ProcessOps_TextBox.Location = new System.Drawing.Point(12, 43);
            this.ProcessOps_TextBox.Name = "ProcessOps_TextBox";
            this.ProcessOps_TextBox.Size = new System.Drawing.Size(329, 20);
            this.ProcessOps_TextBox.TabIndex = 1;
            // 
            // Process_Ops_Label
            // 
            this.Process_Ops_Label.AutoSize = true;
            this.Process_Ops_Label.BackColor = System.Drawing.Color.Transparent;
            this.Process_Ops_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Process_Ops_Label.ForeColor = System.Drawing.Color.Black;
            this.Process_Ops_Label.Location = new System.Drawing.Point(9, 9);
            this.Process_Ops_Label.Name = "Process_Ops_Label";
            this.Process_Ops_Label.Size = new System.Drawing.Size(178, 16);
            this.Process_Ops_Label.TabIndex = 2;
            this.Process_Ops_Label.Text = "Process Operation Modules:";
            // 
            // getpid_Button
            // 
            this.getpid_Button.BackColor = System.Drawing.Color.Transparent;
            this.getpid_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getpid_Button.ForeColor = System.Drawing.Color.Black;
            this.getpid_Button.Location = new System.Drawing.Point(113, 69);
            this.getpid_Button.Name = "getpid_Button";
            this.getpid_Button.Size = new System.Drawing.Size(111, 40);
            this.getpid_Button.TabIndex = 3;
            this.getpid_Button.Text = "Get Process ID:";
            this.getpid_Button.UseVisualStyleBackColor = false;
            this.getpid_Button.Click += new System.EventHandler(this.getpid_Button_Click);
            // 
            // runProcess_Button
            // 
            this.runProcess_Button.BackColor = System.Drawing.Color.Transparent;
            this.runProcess_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runProcess_Button.ForeColor = System.Drawing.Color.Black;
            this.runProcess_Button.Location = new System.Drawing.Point(230, 69);
            this.runProcess_Button.Name = "runProcess_Button";
            this.runProcess_Button.Size = new System.Drawing.Size(111, 40);
            this.runProcess_Button.TabIndex = 4;
            this.runProcess_Button.Text = "Run Process:";
            this.runProcess_Button.UseVisualStyleBackColor = false;
            this.runProcess_Button.Click += new System.EventHandler(this.runProcess_Button_Click);
            // 
            // disk_ops_Label
            // 
            this.disk_ops_Label.AutoSize = true;
            this.disk_ops_Label.BackColor = System.Drawing.Color.Transparent;
            this.disk_ops_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disk_ops_Label.ForeColor = System.Drawing.Color.Black;
            this.disk_ops_Label.Location = new System.Drawing.Point(9, 169);
            this.disk_ops_Label.Name = "disk_ops_Label";
            this.disk_ops_Label.Size = new System.Drawing.Size(155, 16);
            this.disk_ops_Label.TabIndex = 5;
            this.disk_ops_Label.Text = "Disk Operation Modules:";
            // 
            // LogicalDrive1_RadioButton
            // 
            this.LogicalDrive1_RadioButton.AutoSize = true;
            this.LogicalDrive1_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive1_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive1_RadioButton.Location = new System.Drawing.Point(12, 208);
            this.LogicalDrive1_RadioButton.Name = "LogicalDrive1_RadioButton";
            this.LogicalDrive1_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive1_RadioButton.TabIndex = 6;
            this.LogicalDrive1_RadioButton.TabStop = true;
            this.LogicalDrive1_RadioButton.Text = "Logical Drive 1";
            this.LogicalDrive1_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive8_RadioButton
            // 
            this.LogicalDrive8_RadioButton.AutoSize = true;
            this.LogicalDrive8_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive8_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive8_RadioButton.Location = new System.Drawing.Point(128, 315);
            this.LogicalDrive8_RadioButton.Name = "LogicalDrive8_RadioButton";
            this.LogicalDrive8_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive8_RadioButton.TabIndex = 7;
            this.LogicalDrive8_RadioButton.TabStop = true;
            this.LogicalDrive8_RadioButton.Text = "Logical Drive 8";
            this.LogicalDrive8_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive7_RadioButton
            // 
            this.LogicalDrive7_RadioButton.AutoSize = true;
            this.LogicalDrive7_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive7_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive7_RadioButton.Location = new System.Drawing.Point(12, 315);
            this.LogicalDrive7_RadioButton.Name = "LogicalDrive7_RadioButton";
            this.LogicalDrive7_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive7_RadioButton.TabIndex = 8;
            this.LogicalDrive7_RadioButton.TabStop = true;
            this.LogicalDrive7_RadioButton.Text = "Logical Drive 7";
            this.LogicalDrive7_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive6_RadioButton
            // 
            this.LogicalDrive6_RadioButton.AutoSize = true;
            this.LogicalDrive6_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive6_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive6_RadioButton.Location = new System.Drawing.Point(245, 262);
            this.LogicalDrive6_RadioButton.Name = "LogicalDrive6_RadioButton";
            this.LogicalDrive6_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive6_RadioButton.TabIndex = 9;
            this.LogicalDrive6_RadioButton.TabStop = true;
            this.LogicalDrive6_RadioButton.Text = "Logical Drive 6";
            this.LogicalDrive6_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive5_RadioButton
            // 
            this.LogicalDrive5_RadioButton.AutoSize = true;
            this.LogicalDrive5_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive5_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive5_RadioButton.Location = new System.Drawing.Point(128, 262);
            this.LogicalDrive5_RadioButton.Name = "LogicalDrive5_RadioButton";
            this.LogicalDrive5_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive5_RadioButton.TabIndex = 10;
            this.LogicalDrive5_RadioButton.TabStop = true;
            this.LogicalDrive5_RadioButton.Text = "Logical Drive 5";
            this.LogicalDrive5_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive4_RadioButton
            // 
            this.LogicalDrive4_RadioButton.AutoSize = true;
            this.LogicalDrive4_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive4_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive4_RadioButton.Location = new System.Drawing.Point(12, 262);
            this.LogicalDrive4_RadioButton.Name = "LogicalDrive4_RadioButton";
            this.LogicalDrive4_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive4_RadioButton.TabIndex = 11;
            this.LogicalDrive4_RadioButton.TabStop = true;
            this.LogicalDrive4_RadioButton.Text = "Logical Drive 4";
            this.LogicalDrive4_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive3_RadioButton
            // 
            this.LogicalDrive3_RadioButton.AutoSize = true;
            this.LogicalDrive3_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive3_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive3_RadioButton.Location = new System.Drawing.Point(245, 208);
            this.LogicalDrive3_RadioButton.Name = "LogicalDrive3_RadioButton";
            this.LogicalDrive3_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive3_RadioButton.TabIndex = 12;
            this.LogicalDrive3_RadioButton.TabStop = true;
            this.LogicalDrive3_RadioButton.Text = "Logical Drive 3";
            this.LogicalDrive3_RadioButton.UseVisualStyleBackColor = false;
            // 
            // LogicalDrive2_RadioButton
            // 
            this.LogicalDrive2_RadioButton.AutoSize = true;
            this.LogicalDrive2_RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.LogicalDrive2_RadioButton.ForeColor = System.Drawing.Color.Black;
            this.LogicalDrive2_RadioButton.Location = new System.Drawing.Point(128, 208);
            this.LogicalDrive2_RadioButton.Name = "LogicalDrive2_RadioButton";
            this.LogicalDrive2_RadioButton.Size = new System.Drawing.Size(96, 17);
            this.LogicalDrive2_RadioButton.TabIndex = 13;
            this.LogicalDrive2_RadioButton.TabStop = true;
            this.LogicalDrive2_RadioButton.Text = "Logical Drive 2";
            this.LogicalDrive2_RadioButton.UseVisualStyleBackColor = false;
            // 
            // drives_ini_button
            // 
            this.drives_ini_button.BackColor = System.Drawing.Color.Transparent;
            this.drives_ini_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drives_ini_button.ForeColor = System.Drawing.Color.Black;
            this.drives_ini_button.Location = new System.Drawing.Point(245, 292);
            this.drives_ini_button.Name = "drives_ini_button";
            this.drives_ini_button.Size = new System.Drawing.Size(96, 40);
            this.drives_ini_button.TabIndex = 14;
            this.drives_ini_button.Text = "Update Logical Drives:";
            this.drives_ini_button.UseVisualStyleBackColor = false;
            this.drives_ini_button.Click += new System.EventHandler(this.drives_ini_button_Click);
            // 
            // defrag_partition_button
            // 
            this.defrag_partition_button.BackColor = System.Drawing.Color.Transparent;
            this.defrag_partition_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defrag_partition_button.ForeColor = System.Drawing.Color.Black;
            this.defrag_partition_button.Location = new System.Drawing.Point(129, 362);
            this.defrag_partition_button.Name = "defrag_partition_button";
            this.defrag_partition_button.Size = new System.Drawing.Size(95, 40);
            this.defrag_partition_button.TabIndex = 15;
            this.defrag_partition_button.Text = "Defrag";
            this.defrag_partition_button.UseVisualStyleBackColor = false;
            this.defrag_partition_button.Click += new System.EventHandler(this.defrag_partition_button_Click);
            // 
            // format_partition_button
            // 
            this.format_partition_button.BackColor = System.Drawing.Color.Transparent;
            this.format_partition_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.format_partition_button.ForeColor = System.Drawing.Color.Black;
            this.format_partition_button.Location = new System.Drawing.Point(12, 362);
            this.format_partition_button.Name = "format_partition_button";
            this.format_partition_button.Size = new System.Drawing.Size(95, 40);
            this.format_partition_button.TabIndex = 16;
            this.format_partition_button.Text = "Format";
            this.format_partition_button.UseVisualStyleBackColor = false;
            this.format_partition_button.Click += new System.EventHandler(this.format_partition_button_Click);
            // 
            // OpenDrive_button
            // 
            this.OpenDrive_button.BackColor = System.Drawing.Color.Transparent;
            this.OpenDrive_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDrive_button.ForeColor = System.Drawing.Color.Black;
            this.OpenDrive_button.Location = new System.Drawing.Point(246, 362);
            this.OpenDrive_button.Name = "OpenDrive_button";
            this.OpenDrive_button.Size = new System.Drawing.Size(95, 40);
            this.OpenDrive_button.TabIndex = 17;
            this.OpenDrive_button.Text = "Browse";
            this.OpenDrive_button.UseVisualStyleBackColor = false;
            this.OpenDrive_button.Click += new System.EventHandler(this.OpenDrive_button_Click);
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoRichTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRichTextBox.ForeColor = System.Drawing.Color.White;
            this.InfoRichTextBox.Location = new System.Drawing.Point(361, 12);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.ReadOnly = true;
            this.InfoRichTextBox.Size = new System.Drawing.Size(400, 429);
            this.InfoRichTextBox.TabIndex = 18;
            this.InfoRichTextBox.Text = "";
            this.InfoRichTextBox.TextChanged += new System.EventHandler(this.InfoRichTextBox_TextChanged);
            // 
            // GraphicalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::AdminCon_CLI_dotnetEdition.Properties.Resources.UI_Background;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.InfoRichTextBox);
            this.Controls.Add(this.OpenDrive_button);
            this.Controls.Add(this.format_partition_button);
            this.Controls.Add(this.defrag_partition_button);
            this.Controls.Add(this.drives_ini_button);
            this.Controls.Add(this.LogicalDrive2_RadioButton);
            this.Controls.Add(this.LogicalDrive3_RadioButton);
            this.Controls.Add(this.LogicalDrive4_RadioButton);
            this.Controls.Add(this.LogicalDrive5_RadioButton);
            this.Controls.Add(this.LogicalDrive6_RadioButton);
            this.Controls.Add(this.LogicalDrive7_RadioButton);
            this.Controls.Add(this.LogicalDrive8_RadioButton);
            this.Controls.Add(this.LogicalDrive1_RadioButton);
            this.Controls.Add(this.disk_ops_Label);
            this.Controls.Add(this.runProcess_Button);
            this.Controls.Add(this.getpid_Button);
            this.Controls.Add(this.Process_Ops_Label);
            this.Controls.Add(this.ProcessOps_TextBox);
            this.Controls.Add(this.KILL_BUTTON);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicalInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCon 3.0 - Graphical Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KILL_BUTTON;
        private System.Windows.Forms.TextBox ProcessOps_TextBox;
        private System.Windows.Forms.Label Process_Ops_Label;
        private System.Windows.Forms.Button getpid_Button;
        private System.Windows.Forms.Button runProcess_Button;
        private System.Windows.Forms.Label disk_ops_Label;
        private System.Windows.Forms.RadioButton LogicalDrive1_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive8_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive7_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive6_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive5_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive4_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive3_RadioButton;
        private System.Windows.Forms.RadioButton LogicalDrive2_RadioButton;
        private System.Windows.Forms.Button drives_ini_button;
        private System.Windows.Forms.Button defrag_partition_button;
        private System.Windows.Forms.Button format_partition_button;
        private System.Windows.Forms.Button OpenDrive_button;
        private System.Windows.Forms.RichTextBox InfoRichTextBox;
    }
}