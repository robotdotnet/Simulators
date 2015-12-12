namespace DriverStationGUI
{
    partial class DriverStation
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
            this.enableButton = new System.Windows.Forms.Button();
            this.disableButton = new System.Windows.Forms.Button();
            this.teleopRadio = new System.Windows.Forms.RadioButton();
            this.autonRadio = new System.Windows.Forms.RadioButton();
            this.testRadio = new System.Windows.Forms.RadioButton();
            this.Controller4Panel = new System.Windows.Forms.Panel();
            this.Controller3Panel = new System.Windows.Forms.Panel();
            this.Controller2Panel = new System.Windows.Forms.Panel();
            this.Controller1Panel = new System.Windows.Forms.Panel();
            this.controller4 = new System.Windows.Forms.ComboBox();
            this.controller3 = new System.Windows.Forms.ComboBox();
            this.controller2 = new System.Windows.Forms.ComboBox();
            this.controller1 = new System.Windows.Forms.ComboBox();
            this.CheckButtons = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enableButton.Location = new System.Drawing.Point(24, 124);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(119, 49);
            this.enableButton.TabIndex = 0;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // disableButton
            // 
            this.disableButton.BackColor = System.Drawing.Color.Red;
            this.disableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.disableButton.Enabled = false;
            this.disableButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.disableButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.disableButton.Location = new System.Drawing.Point(24, 179);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(119, 49);
            this.disableButton.TabIndex = 0;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = false;
            this.disableButton.Click += new System.EventHandler(this.disableButton_Click);
            // 
            // teleopRadio
            // 
            this.teleopRadio.AutoSize = true;
            this.teleopRadio.Checked = true;
            this.teleopRadio.Location = new System.Drawing.Point(24, 33);
            this.teleopRadio.Name = "teleopRadio";
            this.teleopRadio.Size = new System.Drawing.Size(88, 17);
            this.teleopRadio.TabIndex = 1;
            this.teleopRadio.TabStop = true;
            this.teleopRadio.Text = "Teleoperated";
            this.teleopRadio.UseVisualStyleBackColor = true;
            this.teleopRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // autonRadio
            // 
            this.autonRadio.AutoSize = true;
            this.autonRadio.Location = new System.Drawing.Point(24, 56);
            this.autonRadio.Name = "autonRadio";
            this.autonRadio.Size = new System.Drawing.Size(84, 17);
            this.autonRadio.TabIndex = 1;
            this.autonRadio.Text = "Autonomous";
            this.autonRadio.UseVisualStyleBackColor = true;
            this.autonRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // testRadio
            // 
            this.testRadio.AutoSize = true;
            this.testRadio.Location = new System.Drawing.Point(24, 79);
            this.testRadio.Name = "testRadio";
            this.testRadio.Size = new System.Drawing.Size(46, 17);
            this.testRadio.TabIndex = 1;
            this.testRadio.Text = "Test";
            this.testRadio.UseVisualStyleBackColor = true;
            this.testRadio.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // Controller4Panel
            // 
            this.Controller4Panel.Location = new System.Drawing.Point(204, 102);
            this.Controller4Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Controller4Panel.Name = "Controller4Panel";
            this.Controller4Panel.Size = new System.Drawing.Size(28, 20);
            this.Controller4Panel.TabIndex = 25;
            // 
            // Controller3Panel
            // 
            this.Controller3Panel.Location = new System.Drawing.Point(204, 78);
            this.Controller3Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Controller3Panel.Name = "Controller3Panel";
            this.Controller3Panel.Size = new System.Drawing.Size(28, 20);
            this.Controller3Panel.TabIndex = 24;
            // 
            // Controller2Panel
            // 
            this.Controller2Panel.Location = new System.Drawing.Point(204, 53);
            this.Controller2Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Controller2Panel.Name = "Controller2Panel";
            this.Controller2Panel.Size = new System.Drawing.Size(28, 20);
            this.Controller2Panel.TabIndex = 27;
            // 
            // Controller1Panel
            // 
            this.Controller1Panel.Location = new System.Drawing.Point(204, 29);
            this.Controller1Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Controller1Panel.Name = "Controller1Panel";
            this.Controller1Panel.Size = new System.Drawing.Size(28, 20);
            this.Controller1Panel.TabIndex = 26;
            // 
            // controller4
            // 
            this.controller4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controller4.FormattingEnabled = true;
            this.controller4.Items.AddRange(new object[] {
            "Xbox 1",
            "Xbox 2",
            "Xbox 3",
            "Xbox 4",
            "DirectX 1",
            "DirectX 2",
            "DirectX 3",
            "DirectX 4"});
            this.controller4.Location = new System.Drawing.Point(237, 102);
            this.controller4.Margin = new System.Windows.Forms.Padding(2);
            this.controller4.Name = "controller4";
            this.controller4.Size = new System.Drawing.Size(92, 21);
            this.controller4.TabIndex = 21;
            this.controller4.SelectedIndexChanged += new System.EventHandler(this.Controller_SelectedIndexChanged);
            // 
            // controller3
            // 
            this.controller3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controller3.FormattingEnabled = true;
            this.controller3.Items.AddRange(new object[] {
            "Xbox 1",
            "Xbox 2",
            "Xbox 3",
            "Xbox 4",
            "DirectX 1",
            "DirectX 2",
            "DirectX 3",
            "DirectX 4"});
            this.controller3.Location = new System.Drawing.Point(237, 78);
            this.controller3.Margin = new System.Windows.Forms.Padding(2);
            this.controller3.Name = "controller3";
            this.controller3.Size = new System.Drawing.Size(92, 21);
            this.controller3.TabIndex = 20;
            this.controller3.SelectedIndexChanged += new System.EventHandler(this.Controller_SelectedIndexChanged);
            // 
            // controller2
            // 
            this.controller2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controller2.FormattingEnabled = true;
            this.controller2.Items.AddRange(new object[] {
            "Xbox 1",
            "Xbox 2",
            "Xbox 3",
            "Xbox 4",
            "DirectX 1",
            "DirectX 2",
            "DirectX 3",
            "DirectX 4"});
            this.controller2.Location = new System.Drawing.Point(237, 53);
            this.controller2.Margin = new System.Windows.Forms.Padding(2);
            this.controller2.Name = "controller2";
            this.controller2.Size = new System.Drawing.Size(92, 21);
            this.controller2.TabIndex = 23;
            this.controller2.SelectedIndexChanged += new System.EventHandler(this.Controller_SelectedIndexChanged);
            // 
            // controller1
            // 
            this.controller1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controller1.FormattingEnabled = true;
            this.controller1.Items.AddRange(new object[] {
            "Xbox 1",
            "Xbox 2",
            "Xbox 3",
            "Xbox 4",
            "DirectX 1",
            "DirectX 2",
            "DirectX 3",
            "DirectX 4"});
            this.controller1.Location = new System.Drawing.Point(237, 29);
            this.controller1.Margin = new System.Windows.Forms.Padding(2);
            this.controller1.Name = "controller1";
            this.controller1.Size = new System.Drawing.Size(92, 21);
            this.controller1.TabIndex = 22;
            this.controller1.SelectedIndexChanged += new System.EventHandler(this.Controller_SelectedIndexChanged);
            // 
            // CheckButtons
            // 
            this.CheckButtons.AutoSize = true;
            this.CheckButtons.Location = new System.Drawing.Point(284, 142);
            this.CheckButtons.Margin = new System.Windows.Forms.Padding(2);
            this.CheckButtons.Name = "CheckButtons";
            this.CheckButtons.Size = new System.Drawing.Size(15, 14);
            this.CheckButtons.TabIndex = 28;
            this.CheckButtons.UseVisualStyleBackColor = true;
            // 
            // DriverStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 254);
            this.Controls.Add(this.CheckButtons);
            this.Controls.Add(this.Controller4Panel);
            this.Controls.Add(this.Controller3Panel);
            this.Controls.Add(this.Controller2Panel);
            this.Controls.Add(this.Controller1Panel);
            this.Controls.Add(this.controller4);
            this.Controls.Add(this.controller3);
            this.Controls.Add(this.controller2);
            this.Controls.Add(this.controller1);
            this.Controls.Add(this.testRadio);
            this.Controls.Add(this.autonRadio);
            this.Controls.Add(this.teleopRadio);
            this.Controls.Add(this.disableButton);
            this.Controls.Add(this.enableButton);
            this.Name = "DriverStation";
            this.Text = "Driver Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Button disableButton;
        private System.Windows.Forms.RadioButton teleopRadio;
        private System.Windows.Forms.RadioButton autonRadio;
        private System.Windows.Forms.RadioButton testRadio;
        private System.Windows.Forms.Panel Controller4Panel;
        private System.Windows.Forms.Panel Controller3Panel;
        private System.Windows.Forms.Panel Controller2Panel;
        private System.Windows.Forms.Panel Controller1Panel;
        private System.Windows.Forms.ComboBox controller4;
        private System.Windows.Forms.ComboBox controller3;
        private System.Windows.Forms.ComboBox controller2;
        private System.Windows.Forms.ComboBox controller1;
        private System.Windows.Forms.CheckBox CheckButtons;
    }
}

