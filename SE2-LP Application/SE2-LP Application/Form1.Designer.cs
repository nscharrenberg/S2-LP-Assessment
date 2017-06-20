namespace SE2_LP_Application
{
    partial class mainFrm
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
            this.mainLbl = new System.Windows.Forms.Label();
            this.addFactionBtn = new System.Windows.Forms.Button();
            this.addCandidateBtn = new System.Windows.Forms.Button();
            this.electionList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLbl.Location = new System.Drawing.Point(200, 9);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(309, 55);
            this.mainLbl.TabIndex = 0;
            this.mainLbl.Text = "Hoofdpagina";
            // 
            // addFactionBtn
            // 
            this.addFactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFactionBtn.Location = new System.Drawing.Point(120, 81);
            this.addFactionBtn.Name = "addFactionBtn";
            this.addFactionBtn.Size = new System.Drawing.Size(213, 73);
            this.addFactionBtn.TabIndex = 1;
            this.addFactionBtn.Text = "Partij Toevoegen";
            this.addFactionBtn.UseVisualStyleBackColor = true;
            this.addFactionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addCandidateBtn
            // 
            this.addCandidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCandidateBtn.Location = new System.Drawing.Point(365, 81);
            this.addCandidateBtn.Name = "addCandidateBtn";
            this.addCandidateBtn.Size = new System.Drawing.Size(213, 73);
            this.addCandidateBtn.TabIndex = 2;
            this.addCandidateBtn.Text = "Lijsttrekker Toevoegen";
            this.addCandidateBtn.UseVisualStyleBackColor = true;
            // 
            // electionList
            // 
            this.electionList.CheckOnClick = true;
            this.electionList.FormattingEnabled = true;
            this.electionList.Location = new System.Drawing.Point(120, 160);
            this.electionList.MultiColumn = true;
            this.electionList.Name = "electionList";
            this.electionList.Size = new System.Drawing.Size(458, 289);
            this.electionList.TabIndex = 3;
            this.electionList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.electionList_ItemCheck);
            this.electionList.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.electionList_Format);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(120, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(458, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open deze Verkiezing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.electionList);
            this.Controls.Add(this.addCandidateBtn);
            this.Controls.Add(this.addFactionBtn);
            this.Controls.Add(this.mainLbl);
            this.Name = "mainFrm";
            this.Text = "Homepagina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLbl;
        private System.Windows.Forms.Button addFactionBtn;
        private System.Windows.Forms.Button addCandidateBtn;
        private System.Windows.Forms.CheckedListBox electionList;
        private System.Windows.Forms.Button button1;
    }
}

