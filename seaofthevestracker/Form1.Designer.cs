namespace seaofthevestracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnStartMatch = new System.Windows.Forms.Button();
            this.TmrMatchTimer = new System.Windows.Forms.Timer(this.components);
            this.LblCurrentTimelbl = new System.Windows.Forms.Label();
            this.LblCurrentTime = new System.Windows.Forms.Label();
            this.BtnShipType = new System.Windows.Forms.Button();
            this.BtnLoss = new System.Windows.Forms.Button();
            this.BtnWin = new System.Windows.Forms.Button();
            this.BtnMatchDelete = new System.Windows.Forms.Button();
            this.BtnMatchEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.LblShipType = new System.Windows.Forms.Label();
            this.LblCurrentStreakLbl = new System.Windows.Forms.Label();
            this.NudStreak = new System.Windows.Forms.NumericUpDown();
            this.LblFaction = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnChangeFaction = new System.Windows.Forms.Button();
            this.TmrSafeTimer = new System.Windows.Forms.Timer(this.components);
            this.LblSafeTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRefreshTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStreak)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnStartMatch
            // 
            this.BtnStartMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartMatch.Location = new System.Drawing.Point(12, 203);
            this.BtnStartMatch.Name = "BtnStartMatch";
            this.BtnStartMatch.Size = new System.Drawing.Size(123, 50);
            this.BtnStartMatch.TabIndex = 1;
            this.BtnStartMatch.Text = "Start Match";
            this.BtnStartMatch.UseVisualStyleBackColor = true;
            this.BtnStartMatch.Click += new System.EventHandler(this.BtnStartMatch_Click);
            // 
            // TmrMatchTimer
            // 
            this.TmrMatchTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblCurrentTimelbl
            // 
            this.LblCurrentTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentTimelbl.Location = new System.Drawing.Point(18, 37);
            this.LblCurrentTimelbl.Name = "LblCurrentTimelbl";
            this.LblCurrentTimelbl.Size = new System.Drawing.Size(42, 23);
            this.LblCurrentTimelbl.TabIndex = 2;
            this.LblCurrentTimelbl.Text = "Time:";
            // 
            // LblCurrentTime
            // 
            this.LblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentTime.Location = new System.Drawing.Point(57, 37);
            this.LblCurrentTime.Name = "LblCurrentTime";
            this.LblCurrentTime.Size = new System.Drawing.Size(100, 23);
            this.LblCurrentTime.TabIndex = 3;
            this.LblCurrentTime.Text = "0";
            this.LblCurrentTime.Click += new System.EventHandler(this.LblCurrentTime_Click);
            // 
            // BtnShipType
            // 
            this.BtnShipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShipType.Location = new System.Drawing.Point(141, 147);
            this.BtnShipType.Name = "BtnShipType";
            this.BtnShipType.Size = new System.Drawing.Size(85, 50);
            this.BtnShipType.TabIndex = 4;
            this.BtnShipType.Text = "Change Ship";
            this.BtnShipType.UseVisualStyleBackColor = true;
            this.BtnShipType.Click += new System.EventHandler(this.BtnShipType_Click);
            // 
            // BtnLoss
            // 
            this.BtnLoss.Enabled = false;
            this.BtnLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoss.Location = new System.Drawing.Point(235, 203);
            this.BtnLoss.Name = "BtnLoss";
            this.BtnLoss.Size = new System.Drawing.Size(85, 50);
            this.BtnLoss.TabIndex = 5;
            this.BtnLoss.Text = "Loss";
            this.BtnLoss.UseVisualStyleBackColor = true;
            this.BtnLoss.Click += new System.EventHandler(this.BtnLoss_Click);
            // 
            // BtnWin
            // 
            this.BtnWin.Enabled = false;
            this.BtnWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWin.Location = new System.Drawing.Point(141, 203);
            this.BtnWin.Name = "BtnWin";
            this.BtnWin.Size = new System.Drawing.Size(85, 50);
            this.BtnWin.TabIndex = 6;
            this.BtnWin.Text = "Win";
            this.BtnWin.UseVisualStyleBackColor = true;
            this.BtnWin.Click += new System.EventHandler(this.BtnWin_Click);
            // 
            // BtnMatchDelete
            // 
            this.BtnMatchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatchDelete.Location = new System.Drawing.Point(480, 259);
            this.BtnMatchDelete.Name = "BtnMatchDelete";
            this.BtnMatchDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnMatchDelete.TabIndex = 7;
            this.BtnMatchDelete.Text = "Delete";
            this.BtnMatchDelete.UseVisualStyleBackColor = true;
            // 
            // BtnMatchEdit
            // 
            this.BtnMatchEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMatchEdit.Location = new System.Drawing.Point(399, 259);
            this.BtnMatchEdit.Name = "BtnMatchEdit";
            this.BtnMatchEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnMatchEdit.TabIndex = 8;
            this.BtnMatchEdit.Text = "Edit";
            this.BtnMatchEdit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ship Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblShipType
            // 
            this.LblShipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblShipType.Location = new System.Drawing.Point(12, 165);
            this.LblShipType.Name = "LblShipType";
            this.LblShipType.Size = new System.Drawing.Size(117, 15);
            this.LblShipType.TabIndex = 11;
            this.LblShipType.Text = "Sloop";
            this.LblShipType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCurrentStreakLbl
            // 
            this.LblCurrentStreakLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentStreakLbl.Location = new System.Drawing.Point(18, 60);
            this.LblCurrentStreakLbl.Name = "LblCurrentStreakLbl";
            this.LblCurrentStreakLbl.Size = new System.Drawing.Size(97, 15);
            this.LblCurrentStreakLbl.TabIndex = 12;
            this.LblCurrentStreakLbl.Text = "Current Streak:";
            // 
            // NudStreak
            // 
            this.NudStreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudStreak.Location = new System.Drawing.Point(121, 58);
            this.NudStreak.Name = "NudStreak";
            this.NudStreak.Size = new System.Drawing.Size(120, 22);
            this.NudStreak.TabIndex = 16;
            this.NudStreak.ValueChanged += new System.EventHandler(this.NudStreak_ValueChanged);
            // 
            // LblFaction
            // 
            this.LblFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaction.Location = new System.Drawing.Point(12, 118);
            this.LblFaction.Name = "LblFaction";
            this.LblFaction.Size = new System.Drawing.Size(117, 15);
            this.LblFaction.TabIndex = 18;
            this.LblFaction.Text = "Athena";
            this.LblFaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Faction:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnChangeFaction
            // 
            this.BtnChangeFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeFaction.Location = new System.Drawing.Point(141, 91);
            this.BtnChangeFaction.Name = "BtnChangeFaction";
            this.BtnChangeFaction.Size = new System.Drawing.Size(85, 50);
            this.BtnChangeFaction.TabIndex = 19;
            this.BtnChangeFaction.Text = "Change Faction";
            this.BtnChangeFaction.UseVisualStyleBackColor = true;
            this.BtnChangeFaction.Click += new System.EventHandler(this.BtnChangeFaction_Click);
            // 
            // TmrSafeTimer
            // 
            this.TmrSafeTimer.Tick += new System.EventHandler(this.TmrSafeTimer_Tick);
            // 
            // LblSafeTimer
            // 
            this.LblSafeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSafeTimer.Location = new System.Drawing.Point(430, 37);
            this.LblSafeTimer.Name = "LblSafeTimer";
            this.LblSafeTimer.Size = new System.Drawing.Size(100, 23);
            this.LblSafeTimer.TabIndex = 21;
            this.LblSafeTimer.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Safe Time:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnRefreshTable
            // 
            this.BtnRefreshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefreshTable.Location = new System.Drawing.Point(12, 259);
            this.BtnRefreshTable.Name = "BtnRefreshTable";
            this.BtnRefreshTable.Size = new System.Drawing.Size(75, 23);
            this.BtnRefreshTable.TabIndex = 22;
            this.BtnRefreshTable.Text = "Refresh";
            this.BtnRefreshTable.UseVisualStyleBackColor = true;
            this.BtnRefreshTable.Click += new System.EventHandler(this.BtnRefreshTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.BtnRefreshTable);
            this.Controls.Add(this.LblSafeTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnChangeFaction);
            this.Controls.Add(this.LblFaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudStreak);
            this.Controls.Add(this.LblCurrentStreakLbl);
            this.Controls.Add(this.LblShipType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnMatchEdit);
            this.Controls.Add(this.BtnMatchDelete);
            this.Controls.Add(this.BtnWin);
            this.Controls.Add(this.BtnLoss);
            this.Controls.Add(this.BtnShipType);
            this.Controls.Add(this.LblCurrentTime);
            this.Controls.Add(this.LblCurrentTimelbl);
            this.Controls.Add(this.BtnStartMatch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(574, 479);
            this.MinimumSize = new System.Drawing.Size(574, 479);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStreak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button BtnRefreshTable;

        private System.Windows.Forms.Label LblSafeTimer;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Timer TmrSafeTimer;

        private System.Windows.Forms.Label LblFaction;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button BtnStartMatch;

        private System.Windows.Forms.NumericUpDown NudStreak;

        private System.Windows.Forms.Label LblCurrentStreakLbl;

        private System.Windows.Forms.Label LblShipType;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button BtnMatchEdit;

        private System.Windows.Forms.Button BtnMatchDelete;

        private System.Windows.Forms.Button BtnShipType;
        private System.Windows.Forms.Button BtnLoss;
        private System.Windows.Forms.Button BtnWin;

        private System.Windows.Forms.Label LblCurrentTimelbl;
        private System.Windows.Forms.Label LblCurrentTime;

        private System.Windows.Forms.Timer TmrMatchTimer;

        private System.Windows.Forms.Button BtnChangeFaction;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}