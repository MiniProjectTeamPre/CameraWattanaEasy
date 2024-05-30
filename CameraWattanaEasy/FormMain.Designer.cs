namespace CameraWattanaEasy {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pn_degree = new System.Windows.Forms.Panel();
            this.pn_adjust = new System.Windows.Forms.Panel();
            this.bt_no = new System.Windows.Forms.Button();
            this.bt_yes = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.ptb_image = new System.Windows.Forms.PictureBox();
            this.ptb_camera = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tm_readFile = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pn_degree);
            this.groupBox1.Controls.Add(this.pn_adjust);
            this.groupBox1.Controls.Add(this.bt_no);
            this.groupBox1.Controls.Add(this.bt_yes);
            this.groupBox1.Controls.Add(this.bt_ok);
            this.groupBox1.Controls.Add(this.tb_message);
            this.groupBox1.Controls.Add(this.ptb_image);
            this.groupBox1.Controls.Add(this.ptb_camera);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1342, 786);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pn_degree
            // 
            this.pn_degree.BackgroundImage = global::CameraWattanaEasy.Properties.Resources.Rotate;
            this.pn_degree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_degree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_degree.Location = new System.Drawing.Point(651, 130);
            this.pn_degree.Name = "pn_degree";
            this.pn_degree.Size = new System.Drawing.Size(42, 40);
            this.pn_degree.TabIndex = 7;
            this.pn_degree.Click += new System.EventHandler(this.pn_degree_Click);
            // 
            // pn_adjust
            // 
            this.pn_adjust.BackgroundImage = global::CameraWattanaEasy.Properties.Resources.Adjust;
            this.pn_adjust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_adjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_adjust.Location = new System.Drawing.Point(651, 58);
            this.pn_adjust.Name = "pn_adjust";
            this.pn_adjust.Size = new System.Drawing.Size(42, 40);
            this.pn_adjust.TabIndex = 6;
            this.pn_adjust.Click += new System.EventHandler(this.pn_adjust_Click);
            // 
            // bt_no
            // 
            this.bt_no.BackColor = System.Drawing.Color.White;
            this.bt_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_no.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_no.Location = new System.Drawing.Point(772, 679);
            this.bt_no.Name = "bt_no";
            this.bt_no.Size = new System.Drawing.Size(187, 90);
            this.bt_no.TabIndex = 5;
            this.bt_no.Text = "No";
            this.bt_no.UseVisualStyleBackColor = false;
            this.bt_no.Click += new System.EventHandler(this.bt_no_Click);
            // 
            // bt_yes
            // 
            this.bt_yes.BackColor = System.Drawing.Color.White;
            this.bt_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_yes.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_yes.Location = new System.Drawing.Point(377, 679);
            this.bt_yes.Name = "bt_yes";
            this.bt_yes.Size = new System.Drawing.Size(187, 90);
            this.bt_yes.TabIndex = 4;
            this.bt_yes.Text = "Yes";
            this.bt_yes.UseVisualStyleBackColor = false;
            this.bt_yes.Click += new System.EventHandler(this.bt_yes_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.White;
            this.bt_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_ok.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.Location = new System.Drawing.Point(576, 679);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(187, 90);
            this.bt_ok.TabIndex = 3;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // tb_message
            // 
            this.tb_message.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.Location = new System.Drawing.Point(377, 625);
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(582, 35);
            this.tb_message.TabIndex = 2;
            this.tb_message.Text = "Message Show";
            this.tb_message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptb_image
            // 
            this.ptb_image.BackColor = System.Drawing.Color.Black;
            this.ptb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_image.Location = new System.Drawing.Point(712, 19);
            this.ptb_image.Name = "ptb_image";
            this.ptb_image.Size = new System.Drawing.Size(588, 588);
            this.ptb_image.TabIndex = 1;
            this.ptb_image.TabStop = false;
            // 
            // ptb_camera
            // 
            this.ptb_camera.BackColor = System.Drawing.Color.Black;
            this.ptb_camera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_camera.Location = new System.Drawing.Point(43, 19);
            this.ptb_camera.Name = "ptb_camera";
            this.ptb_camera.Size = new System.Drawing.Size(588, 588);
            this.ptb_camera.TabIndex = 0;
            this.ptb_camera.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1255, 801);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "V2023.01";
            // 
            // tm_readFile
            // 
            this.tm_readFile.Enabled = true;
            this.tm_readFile.Tick += new System.EventHandler(this.tm_readFile_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 840);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_camera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.PictureBox ptb_image;
        private System.Windows.Forms.PictureBox ptb_camera;
        private System.Windows.Forms.Button bt_no;
        private System.Windows.Forms.Button bt_yes;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Timer tm_readFile;
        private System.Windows.Forms.Panel pn_adjust;
        private System.Windows.Forms.Panel pn_degree;
    }
}

