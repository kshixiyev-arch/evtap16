namespace ev_tapsirigi16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picSolAdam = new PictureBox();
            picSagAdam = new PictureBox();
            picBomba = new PictureBox();
            timerOyun = new System.Windows.Forms.Timer(components);
            picBomba2 = new PictureBox();
            lblAddim = new Label();
            ((System.ComponentModel.ISupportInitialize)picSolAdam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSagAdam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBomba).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBomba2).BeginInit();
            SuspendLayout();
            // 
            // picSolAdam
            // 
            picSolAdam.BackColor = Color.Transparent;
            picSolAdam.Image = Properties.Resources.sola_qaçan;
            picSolAdam.Location = new Point(286, 336);
            picSolAdam.Name = "picSolAdam";
            picSolAdam.Size = new Size(55, 55);
            picSolAdam.SizeMode = PictureBoxSizeMode.Zoom;
            picSolAdam.TabIndex = 0;
            picSolAdam.TabStop = false;
            picSolAdam.Visible = false;
            // 
            // picSagAdam
            // 
            picSagAdam.BackColor = Color.Transparent;
            picSagAdam.Image = Properties.Resources.sağa_qaçan;
            picSagAdam.Location = new Point(286, 336);
            picSagAdam.Name = "picSagAdam";
            picSagAdam.Size = new Size(55, 55);
            picSagAdam.SizeMode = PictureBoxSizeMode.Zoom;
            picSagAdam.TabIndex = 1;
            picSagAdam.TabStop = false;
            picSagAdam.Visible = false;
            // 
            // picBomba
            // 
            picBomba.BackColor = Color.Transparent;
            picBomba.Image = Properties.Resources.bomb__1_;
            picBomba.Location = new Point(166, 12);
            picBomba.Name = "picBomba";
            picBomba.Size = new Size(55, 55);
            picBomba.SizeMode = PictureBoxSizeMode.Zoom;
            picBomba.TabIndex = 2;
            picBomba.TabStop = false;
            picBomba.Visible = false;
            // 
            // timerOyun
            // 
            timerOyun.Interval = 30;
            timerOyun.Tick += timerOyun_Tick;
            // 
            // picBomba2
            // 
            picBomba2.BackColor = Color.Transparent;
            picBomba2.Image = Properties.Resources.bomb__1_;
            picBomba2.Location = new Point(468, 12);
            picBomba2.Name = "picBomba2";
            picBomba2.Size = new Size(55, 55);
            picBomba2.SizeMode = PictureBoxSizeMode.Zoom;
            picBomba2.TabIndex = 3;
            picBomba2.TabStop = false;
            picBomba2.Visible = false;
            // 
            // lblAddim
            // 
            lblAddim.AutoSize = true;
            lblAddim.Font = new Font("Segoe UI", 12.8F, FontStyle.Bold);
            lblAddim.Location = new Point(12, 9);
            lblAddim.Name = "lblAddim";
            lblAddim.Size = new Size(107, 30);
            lblAddim.TabIndex = 4;
            lblAddim.Text = "Addım: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 403);
            Controls.Add(lblAddim);
            Controls.Add(picBomba2);
            Controls.Add(picBomba);
            Controls.Add(picSagAdam);
            Controls.Add(picSolAdam);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "`";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picSolAdam).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSagAdam).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBomba).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBomba2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picSolAdam;
        private PictureBox picSagAdam;
        private PictureBox picBomba;
        private System.Windows.Forms.Timer timerOyun;
        private PictureBox picBomba2;
        private Label lblAddim;
    }
}
