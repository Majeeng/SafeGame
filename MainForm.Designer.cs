
namespace SafeGame
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelTopic = new System.Windows.Forms.Panel();
            this.tbN = new System.Windows.Forms.NumericUpDown();
            this.btnRestart = new System.Windows.Forms.Button();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelRotates = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PanelTopic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.PanelTopic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelTopic
            // 
            this.PanelTopic.Controls.Add(this.tbN);
            this.PanelTopic.Controls.Add(this.btnRestart);
            this.PanelTopic.Controls.Add(this.labelWins);
            this.PanelTopic.Controls.Add(this.labelRotates);
            this.PanelTopic.Controls.Add(this.labelN);
            this.PanelTopic.Location = new System.Drawing.Point(74, 74);
            this.PanelTopic.Name = "PanelTopic";
            this.PanelTopic.Size = new System.Drawing.Size(577, 60);
            this.PanelTopic.TabIndex = 3;
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.tbN.Location = new System.Drawing.Point(437, 4);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(71, 31);
            this.tbN.TabIndex = 4;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.Location = new System.Drawing.Point(194, 7);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 0;
            this.btnRestart.Text = "Start";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelWins.Location = new System.Drawing.Point(46, 20);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(115, 24);
            this.labelWins.TabIndex = 2;
            this.labelWins.Text = "Пройдено: 0";
            // 
            // labelRotates
            // 
            this.labelRotates.AutoSize = true;
            this.labelRotates.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelRotates.Location = new System.Drawing.Point(350, 33);
            this.labelRotates.Name = "labelRotates";
            this.labelRotates.Size = new System.Drawing.Size(129, 24);
            this.labelRotates.TabIndex = 2;
            this.labelRotates.Text = "Проворотов: 0";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.labelN.Location = new System.Drawing.Point(350, 7);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(87, 24);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "Матрица:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MainPanel.ResumeLayout(false);
            this.PanelTopic.ResumeLayout(false);
            this.PanelTopic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelRotates;
        private System.Windows.Forms.Panel PanelTopic;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.NumericUpDown tbN;
    }
}

