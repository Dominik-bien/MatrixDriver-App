namespace matrixSystemApp
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
            this.components = new System.ComponentModel.Container();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnScrollLeft = new System.Windows.Forms.Button();
            this.btnScrollUp = new System.Windows.Forms.Button();
            this.chkBlink = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnScrollRight = new System.Windows.Forms.Button();
            this.btnScrollDown = new System.Windows.Forms.Button();
            this.btnFade = new System.Windows.Forms.Button();
            this.btnOpening = new System.Windows.Forms.Button();
            this.btnClosing = new System.Windows.Forms.Button();
            this.btnMesh = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(163, 179);
            this.tbInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(272, 26);
            this.tbInput.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(473, 507);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Wyslij";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyslij Nazwe";
            // 
            // btnScrollLeft
            // 
            this.btnScrollLeft.Location = new System.Drawing.Point(13, 243);
            this.btnScrollLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScrollLeft.Name = "btnScrollLeft";
            this.btnScrollLeft.Size = new System.Drawing.Size(243, 35);
            this.btnScrollLeft.TabIndex = 3;
            this.btnScrollLeft.Text = "Animacja w lewo";
            this.btnScrollLeft.UseVisualStyleBackColor = true;
            this.btnScrollLeft.Click += new System.EventHandler(this.btnScrollLeft_Click);
            // 
            // btnScrollUp
            // 
            this.btnScrollUp.Location = new System.Drawing.Point(13, 308);
            this.btnScrollUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnScrollUp.Name = "btnScrollUp";
            this.btnScrollUp.Size = new System.Drawing.Size(243, 35);
            this.btnScrollUp.TabIndex = 4;
            this.btnScrollUp.Text = "Animacja w góre";
            this.btnScrollUp.UseVisualStyleBackColor = true;
            this.btnScrollUp.Click += new System.EventHandler(this.btnScrollUp_Click);
            // 
            // chkBlink
            // 
            this.chkBlink.AutoSize = true;
            this.chkBlink.Location = new System.Drawing.Point(415, 473);
            this.chkBlink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBlink.Name = "chkBlink";
            this.chkBlink.Size = new System.Drawing.Size(170, 24);
            this.chkBlink.TabIndex = 5;
            this.chkBlink.Text = "Animacja mrugania";
            this.chkBlink.UseVisualStyleBackColor = true;
            this.chkBlink.CheckedChanged += new System.EventHandler(this.chkBlink_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(8, 638);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(278, 35);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Zresetuj ustawienia";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnScrollRight
            // 
            this.btnScrollRight.Location = new System.Drawing.Point(8, 377);
            this.btnScrollRight.Name = "btnScrollRight";
            this.btnScrollRight.Size = new System.Drawing.Size(248, 31);
            this.btnScrollRight.TabIndex = 7;
            this.btnScrollRight.Text = "Animacja w prawo";
            this.btnScrollRight.UseVisualStyleBackColor = true;
            this.btnScrollRight.Click += new System.EventHandler(this.btnScrollRight_Click);
            // 
            // btnScrollDown
            // 
            this.btnScrollDown.Location = new System.Drawing.Point(12, 436);
            this.btnScrollDown.Name = "btnScrollDown";
            this.btnScrollDown.Size = new System.Drawing.Size(244, 31);
            this.btnScrollDown.TabIndex = 8;
            this.btnScrollDown.Text = "Animacja w dół";
            this.btnScrollDown.UseVisualStyleBackColor = true;
            this.btnScrollDown.Click += new System.EventHandler(this.btnScrollDown_Click);
            // 
            // btnFade
            // 
            this.btnFade.Location = new System.Drawing.Point(12, 493);
            this.btnFade.Name = "btnFade";
            this.btnFade.Size = new System.Drawing.Size(244, 32);
            this.btnFade.TabIndex = 9;
            this.btnFade.Text = "Animacja przejscia";
            this.btnFade.UseVisualStyleBackColor = true;
            this.btnFade.Click += new System.EventHandler(this.btnFade_Click);
            // 
            // btnOpening
            // 
            this.btnOpening.Location = new System.Drawing.Point(347, 243);
            this.btnOpening.Name = "btnOpening";
            this.btnOpening.Size = new System.Drawing.Size(226, 35);
            this.btnOpening.TabIndex = 10;
            this.btnOpening.Text = "Animacja Otwierania";
            this.btnOpening.UseVisualStyleBackColor = true;
            this.btnOpening.Click += new System.EventHandler(this.btnOpening_Click);
            // 
            // btnClosing
            // 
            this.btnClosing.Location = new System.Drawing.Point(347, 308);
            this.btnClosing.Name = "btnClosing";
            this.btnClosing.Size = new System.Drawing.Size(226, 35);
            this.btnClosing.TabIndex = 11;
            this.btnClosing.Text = "Animacja Zamknięcia";
            this.btnClosing.UseVisualStyleBackColor = true;
            this.btnClosing.Click += new System.EventHandler(this.btnClosing_Click);
            // 
            // btnMesh
            // 
            this.btnMesh.Location = new System.Drawing.Point(347, 377);
            this.btnMesh.Name = "btnMesh";
            this.btnMesh.Size = new System.Drawing.Size(226, 31);
            this.btnMesh.TabIndex = 12;
            this.btnMesh.Text = "Animacja Mesh";
            this.btnMesh.UseVisualStyleBackColor = true;
            this.btnMesh.Click += new System.EventHandler(this.btnMesh_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(357, 44);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(229, 28);
            this.cbPorts.TabIndex = 13;
            this.cbPorts.Text = "Wybierz port COM";
            this.cbPorts.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(507, 79);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 33);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(357, 78);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(132, 34);
            this.btnRefreshPorts.TabIndex = 15;
            this.btnRefreshPorts.Text = "Wczytaj porty";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 692);
            this.Controls.Add(this.btnRefreshPorts);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.btnMesh);
            this.Controls.Add(this.btnClosing);
            this.Controls.Add(this.btnOpening);
            this.Controls.Add(this.btnFade);
            this.Controls.Add(this.btnScrollDown);
            this.Controls.Add(this.btnScrollRight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkBlink);
            this.Controls.Add(this.btnScrollUp);
            this.Controls.Add(this.btnScrollLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Zarządzanie matrycą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnScrollLeft;
        private System.Windows.Forms.Button btnScrollUp;
        private System.Windows.Forms.CheckBox chkBlink;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnScrollRight;
        private System.Windows.Forms.Button btnScrollDown;
        private System.Windows.Forms.Button btnFade;
        private System.Windows.Forms.Button btnOpening;
        private System.Windows.Forms.Button btnClosing;
        private System.Windows.Forms.Button btnMesh;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRefreshPorts;
    }
}

