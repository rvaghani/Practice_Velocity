namespace winAppRajesh_PracticeVelocity
{
    partial class frmDashBoardView
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
            this.rtbDashBoard = new System.Windows.Forms.RichTextBox();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnEventRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDashBoard
            // 
            this.rtbDashBoard.Location = new System.Drawing.Point(3, 2);
            this.rtbDashBoard.Name = "rtbDashBoard";
            this.rtbDashBoard.Size = new System.Drawing.Size(442, 330);
            this.rtbDashBoard.TabIndex = 0;
            this.rtbDashBoard.Text = "";
            // 
            // cmbEventType
            // 
            this.cmbEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(163, 338);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(102, 24);
            this.cmbEventType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Event Type";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(271, 332);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(62, 30);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnEventRun
            // 
            this.btnEventRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventRun.Location = new System.Drawing.Point(348, 332);
            this.btnEventRun.Name = "btnEventRun";
            this.btnEventRun.Size = new System.Drawing.Size(97, 30);
            this.btnEventRun.TabIndex = 4;
            this.btnEventRun.Text = "EventRun";
            this.btnEventRun.UseVisualStyleBackColor = true;
            this.btnEventRun.Click += new System.EventHandler(this.btnEventRun_Click);
            // 
            // frmDashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 377);
            this.Controls.Add(this.btnEventRun);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEventType);
            this.Controls.Add(this.rtbDashBoard);
            this.Name = "frmDashBoardView";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmDashBoardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDashBoard;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnEventRun;
    }
}