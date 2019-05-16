namespace Lesson2_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.background = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.pause);
            this.background.Controls.Add(this.loseLabel);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gameBall);
            this.background.Controls.Add(this.gamePanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 0;
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pause.Location = new System.Drawing.Point(245, 202);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(161, 47);
            this.pause.TabIndex = 4;
            this.pause.Text = "ПАУЗА";
            this.pause.Visible = false;
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLabel.Location = new System.Drawing.Point(254, 189);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(311, 47);
            this.loseLabel.TabIndex = 3;
            this.loseLabel.Text = "Вы проиграли!";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Arial Black", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(600, 26);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(177, 32);
            this.result.TabIndex = 2;
            this.result.Text = "Результат: 0";
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(198, 186);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Red;
            this.gamePanel.Location = new System.Drawing.Point(268, 389);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(170, 26);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Label pause;
    }
}
