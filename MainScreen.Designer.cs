namespace Fasting_Application
{
    partial class MainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.ONE = new System.Windows.Forms.CheckBox();
            this.TWO = new System.Windows.Forms.CheckBox();
            this.THREE = new System.Windows.Forms.CheckBox();
            this.STARTFASTING = new System.Windows.Forms.Button();
            this.END_FASTING = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PercentLabel = new System.Windows.Forms.Label();
            this.Fasted_hours = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Chart_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fasting Prototype:";
            // 
            // ONE
            // 
            this.ONE.AutoSize = true;
            this.ONE.Checked = true;
            this.ONE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.ONE.Location = new System.Drawing.Point(148, 76);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(72, 22);
            this.ONE.TabIndex = 2;
            this.ONE.Text = "OMAD";
            this.ONE.UseVisualStyleBackColor = true;
            this.ONE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // TWO
            // 
            this.TWO.AutoSize = true;
            this.TWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TWO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.TWO.Location = new System.Drawing.Point(241, 76);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(55, 22);
            this.TWO.TabIndex = 3;
            this.TWO.Text = "16/8";
            this.TWO.UseVisualStyleBackColor = true;
            this.TWO.Click += new System.EventHandler(this.TWO_Click);
            // 
            // THREE
            // 
            this.THREE.AutoSize = true;
            this.THREE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.THREE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THREE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.THREE.Location = new System.Drawing.Point(318, 74);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(55, 22);
            this.THREE.TabIndex = 4;
            this.THREE.Text = "20/4";
            this.THREE.UseVisualStyleBackColor = true;
            this.THREE.Click += new System.EventHandler(this.THREE_Click);
            // 
            // STARTFASTING
            // 
            this.STARTFASTING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STARTFASTING.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STARTFASTING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.STARTFASTING.Location = new System.Drawing.Point(21, 318);
            this.STARTFASTING.Name = "STARTFASTING";
            this.STARTFASTING.Size = new System.Drawing.Size(110, 33);
            this.STARTFASTING.TabIndex = 6;
            this.STARTFASTING.Text = "Start Fasting";
            this.STARTFASTING.UseVisualStyleBackColor = true;
            this.STARTFASTING.Click += new System.EventHandler(this.STARTFASTING_Click);
            // 
            // END_FASTING
            // 
            this.END_FASTING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.END_FASTING.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.END_FASTING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.END_FASTING.Location = new System.Drawing.Point(162, 318);
            this.END_FASTING.Name = "END_FASTING";
            this.END_FASTING.Size = new System.Drawing.Size(116, 33);
            this.END_FASTING.TabIndex = 7;
            this.END_FASTING.Text = "End Fasting";
            this.END_FASTING.UseVisualStyleBackColor = true;
            this.END_FASTING.Click += new System.EventHandler(this.END_FASTING_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PercentLabel
            // 
            this.PercentLabel.AutoSize = true;
            this.PercentLabel.BackColor = System.Drawing.Color.Transparent;
            this.PercentLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(25)))), ((int)(((byte)(64)))));
            this.PercentLabel.Location = new System.Drawing.Point(85, 187);
            this.PercentLabel.Name = "PercentLabel";
            this.PercentLabel.Size = new System.Drawing.Size(46, 27);
            this.PercentLabel.TabIndex = 8;
            this.PercentLabel.Text = "0%";
            // 
            // Fasted_hours
            // 
            this.Fasted_hours.AutoSize = true;
            this.Fasted_hours.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fasted_hours.ForeColor = System.Drawing.Color.White;
            this.Fasted_hours.Location = new System.Drawing.Point(232, 9);
            this.Fasted_hours.Name = "Fasted_hours";
            this.Fasted_hours.Size = new System.Drawing.Size(177, 27);
            this.Fasted_hours.TabIndex = 0;
            this.Fasted_hours.Text = "0 Hours Fasted";
            this.Fasted_hours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.TitleBar.Controls.Add(this.Fasted_hours);
            this.TitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(800, 40);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Chart_panel
            // 
            this.Chart_panel.BackColor = System.Drawing.Color.Transparent;
            this.Chart_panel.Location = new System.Drawing.Point(336, 111);
            this.Chart_panel.Name = "Chart_panel";
            this.Chart_panel.Size = new System.Drawing.Size(333, 357);
            this.Chart_panel.TabIndex = 9;
            this.Chart_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Chart_panel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(649, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "OMAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(548, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Warrior";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(483, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "IF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(408, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Any";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Chart_panel);
            this.Controls.Add(this.PercentLabel);
            this.Controls.Add(this.END_FASTING);
            this.Controls.Add(this.STARTFASTING);
            this.Controls.Add(this.THREE);
            this.Controls.Add(this.TWO);
            this.Controls.Add(this.ONE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ONE;
        private System.Windows.Forms.CheckBox TWO;
        private System.Windows.Forms.CheckBox THREE;
        private System.Windows.Forms.Button STARTFASTING;
        private System.Windows.Forms.Button END_FASTING;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label PercentLabel;
        private System.Windows.Forms.Label Fasted_hours;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel Chart_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}