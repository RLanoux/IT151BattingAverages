namespace IT151BattingAverages
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
            this.txtAtBats = new System.Windows.Forms.TextBox();
            this.txtBaseHits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAddStats = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAtBats
            // 
            this.txtAtBats.Location = new System.Drawing.Point(125, 30);
            this.txtAtBats.Name = "txtAtBats";
            this.txtAtBats.Size = new System.Drawing.Size(123, 20);
            this.txtAtBats.TabIndex = 0;
            // 
            // txtBaseHits
            // 
            this.txtBaseHits.Location = new System.Drawing.Point(125, 56);
            this.txtBaseHits.Name = "txtBaseHits";
            this.txtBaseHits.Size = new System.Drawing.Size(123, 20);
            this.txtBaseHits.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of At Bats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Base Hits:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 153);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(440, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(39, 17);
            this.tslStatus.Text = "Ready";
            // 
            // btnAddStats
            // 
            this.btnAddStats.Location = new System.Drawing.Point(15, 82);
            this.btnAddStats.Name = "btnAddStats";
            this.btnAddStats.Size = new System.Drawing.Size(104, 45);
            this.btnAddStats.TabIndex = 5;
            this.btnAddStats.Text = "Add Values";
            this.btnAddStats.UseVisualStyleBackColor = true;
            this.btnAddStats.Click += new System.EventHandler(this.btnAddStats_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(125, 82);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(123, 45);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate Averages";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Location = new System.Drawing.Point(12, 9);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(51, 13);
            this.lblGameInfo.TabIndex = 7;
            this.lblGameInfo.Text = "Game #1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 175);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAddStats);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBaseHits);
            this.Controls.Add(this.txtAtBats);
            this.Name = "Form1";
            this.Text = "Batting Average Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtBats;
        private System.Windows.Forms.TextBox txtBaseHits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Button btnAddStats;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblGameInfo;
    }
}

