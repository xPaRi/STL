namespace EggBotPlotter
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
            this.label2 = new System.Windows.Forms.Label();
            this.texHostname = new System.Windows.Forms.TextBox();
            this.texPort = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.texCommandList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOpenLast = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.bOpen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.butPenDown = new System.Windows.Forms.Button();
            this.butTurnRight = new System.Windows.Forms.Button();
            this.butPenUp = new System.Windows.Forms.Button();
            this.butTurnLeft = new System.Windows.Forms.Button();
            this.butDown = new System.Windows.Forms.Button();
            this.butUp = new System.Windows.Forms.Button();
            this.texStep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.texCommunication = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.texInitString = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texStep)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Hostname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Port:";
            // 
            // texHostname
            // 
            this.texHostname.Location = new System.Drawing.Point(75, 19);
            this.texHostname.Name = "texHostname";
            this.texHostname.Size = new System.Drawing.Size(100, 20);
            this.texHostname.TabIndex = 2;
            this.texHostname.Text = "192.168.2.44";
            // 
            // texPort
            // 
            this.texPort.Location = new System.Drawing.Point(240, 19);
            this.texPort.Name = "texPort";
            this.texPort.Size = new System.Drawing.Size(50, 20);
            this.texPort.TabIndex = 3;
            this.texPort.Text = "80";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texInitString);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.texPort);
            this.groupBox1.Controls.Add(this.texHostname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.texCommandList);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Command list";
            // 
            // texCommandList
            // 
            this.texCommandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texCommandList.Location = new System.Drawing.Point(3, 16);
            this.texCommandList.Multiline = true;
            this.texCommandList.Name = "texCommandList";
            this.texCommandList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texCommandList.Size = new System.Drawing.Size(431, 113);
            this.texCommandList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butOpenLast);
            this.panel1.Controls.Add(this.butSend);
            this.panel1.Controls.Add(this.bOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 38);
            this.panel1.TabIndex = 1;
            // 
            // butOpenLast
            // 
            this.butOpenLast.Location = new System.Drawing.Point(92, 8);
            this.butOpenLast.Name = "butOpenLast";
            this.butOpenLast.Size = new System.Drawing.Size(75, 23);
            this.butOpenLast.TabIndex = 2;
            this.butOpenLast.Text = "Open &last";
            this.butOpenLast.UseVisualStyleBackColor = true;
            this.butOpenLast.Click += new System.EventHandler(this.butOpenLast_Click);
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(189, 8);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 1;
            this.butSend.Text = "&Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(11, 8);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "&Open…";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.butPenDown);
            this.panel3.Controls.Add(this.butTurnRight);
            this.panel3.Controls.Add(this.butPenUp);
            this.panel3.Controls.Add(this.butTurnLeft);
            this.panel3.Controls.Add(this.butDown);
            this.panel3.Controls.Add(this.butUp);
            this.panel3.Controls.Add(this.texStep);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(434, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 151);
            this.panel3.TabIndex = 2;
            // 
            // butPenDown
            // 
            this.butPenDown.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butPenDown.Location = new System.Drawing.Point(49, 69);
            this.butPenDown.Name = "butPenDown";
            this.butPenDown.Size = new System.Drawing.Size(33, 21);
            this.butPenDown.TabIndex = 7;
            this.butPenDown.Text = "q";
            this.butPenDown.UseVisualStyleBackColor = true;
            this.butPenDown.Click += new System.EventHandler(this.butPenDown_Click);
            // 
            // butTurnRight
            // 
            this.butTurnRight.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butTurnRight.Location = new System.Drawing.Point(88, 52);
            this.butTurnRight.Name = "butTurnRight";
            this.butTurnRight.Size = new System.Drawing.Size(33, 33);
            this.butTurnRight.TabIndex = 6;
            this.butTurnRight.Text = "P";
            this.butTurnRight.UseVisualStyleBackColor = true;
            this.butTurnRight.Click += new System.EventHandler(this.butTurnRight_Click);
            // 
            // butPenUp
            // 
            this.butPenUp.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butPenUp.Location = new System.Drawing.Point(49, 47);
            this.butPenUp.Name = "butPenUp";
            this.butPenUp.Size = new System.Drawing.Size(33, 21);
            this.butPenUp.TabIndex = 5;
            this.butPenUp.Text = "r";
            this.butPenUp.UseVisualStyleBackColor = true;
            this.butPenUp.Click += new System.EventHandler(this.butPenUp_Click);
            // 
            // butTurnLeft
            // 
            this.butTurnLeft.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butTurnLeft.Location = new System.Drawing.Point(10, 52);
            this.butTurnLeft.Name = "butTurnLeft";
            this.butTurnLeft.Size = new System.Drawing.Size(33, 33);
            this.butTurnLeft.TabIndex = 4;
            this.butTurnLeft.Text = "Q";
            this.butTurnLeft.UseVisualStyleBackColor = true;
            this.butTurnLeft.Click += new System.EventHandler(this.butTurnLeft_Click);
            // 
            // butDown
            // 
            this.butDown.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butDown.Location = new System.Drawing.Point(49, 96);
            this.butDown.Name = "butDown";
            this.butDown.Size = new System.Drawing.Size(33, 33);
            this.butDown.TabIndex = 3;
            this.butDown.Text = "Ô";
            this.butDown.UseVisualStyleBackColor = true;
            this.butDown.Click += new System.EventHandler(this.butDown_Click);
            // 
            // butUp
            // 
            this.butUp.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.butUp.Location = new System.Drawing.Point(49, 8);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(33, 33);
            this.butUp.TabIndex = 2;
            this.butUp.Text = "Ó";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // texStep
            // 
            this.texStep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.texStep.Location = new System.Drawing.Point(138, 124);
            this.texStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.texStep.Name = "texStep";
            this.texStep.Size = new System.Drawing.Size(53, 20);
            this.texStep.TabIndex = 1;
            this.texStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.texStep.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Step:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.texCommunication);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 340);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Communications";
            // 
            // texCommunication
            // 
            this.texCommunication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.texCommunication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texCommunication.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.texCommunication.ForeColor = System.Drawing.Color.Silver;
            this.texCommunication.Location = new System.Drawing.Point(3, 16);
            this.texCommunication.Multiline = true;
            this.texCommunication.Name = "texCommunication";
            this.texCommunication.ReadOnly = true;
            this.texCommunication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.texCommunication.Size = new System.Drawing.Size(631, 283);
            this.texCommunication.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.butClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 38);
            this.panel2.TabIndex = 2;
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(9, 6);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 0;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Init string:";
            // 
            // texInitString
            // 
            this.texInitString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texInitString.Location = new System.Drawing.Point(362, 18);
            this.texInitString.Name = "texInitString";
            this.texInitString.Size = new System.Drawing.Size(263, 20);
            this.texInitString.TabIndex = 5;
            this.texInitString.Text = "cy20;pa0,0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 564);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texStep)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texHostname;
        private System.Windows.Forms.TextBox texPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox texCommandList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox texCommunication;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butOpenLast;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button butTurnRight;
        private System.Windows.Forms.Button butPenUp;
        private System.Windows.Forms.Button butTurnLeft;
        private System.Windows.Forms.Button butDown;
        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.NumericUpDown texStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butPenDown;
        private System.Windows.Forms.TextBox texInitString;
        private System.Windows.Forms.Label label4;
    }
}

