namespace TopElevenTrainingCalculator
{
    partial class MainForm
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
            this.gb_PlayerSkills = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Results = new System.Windows.Forms.DataGridView();
            this.Drill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Skill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.c_TotalSkills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_PlayerSkills
            // 
            this.gb_PlayerSkills.Location = new System.Drawing.Point(12, 12);
            this.gb_PlayerSkills.Name = "gb_PlayerSkills";
            this.gb_PlayerSkills.Size = new System.Drawing.Size(121, 518);
            this.gb_PlayerSkills.TabIndex = 0;
            this.gb_PlayerSkills.TabStop = false;
            this.gb_PlayerSkills.Text = "Player Key Skills";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Results);
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 547);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vysledok";
            // 
            // dgv_Results
            // 
            this.dgv_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drill,
            this.c_Skill,
            this.c_TotalSkills,
            this.c_Position});
            this.dgv_Results.Location = new System.Drawing.Point(6, 19);
            this.dgv_Results.Name = "dgv_Results";
            this.dgv_Results.Size = new System.Drawing.Size(573, 522);
            this.dgv_Results.TabIndex = 0;
            // 
            // Drill
            // 
            this.Drill.HeaderText = "Drill";
            this.Drill.Name = "Drill";
            this.Drill.Width = 200;
            // 
            // c_Skill
            // 
            this.c_Skill.HeaderText = "Skill count";
            this.c_Skill.Name = "c_Skill";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c_TotalSkills
            // 
            this.c_TotalSkills.HeaderText = "Total Skills";
            this.c_TotalSkills.Name = "c_TotalSkills";
            // 
            // c_Position
            // 
            this.c_Position.HeaderText = "Position";
            this.c_Position.Name = "c_Position";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_PlayerSkills);
            this.Name = "MainForm";
            this.Text = "Top Eleven Training Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_PlayerSkills;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drill;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Skill;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_TotalSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Position;
    }
}

