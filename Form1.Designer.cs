namespace Ping
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
            this.backGround = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.lose = new System.Windows.Forms.Timer(this.components);
            this.counter = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.backGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Controls.Add(this.loseLabel);
            this.backGround.Controls.Add(this.counter);
            this.backGround.Controls.Add(this.ball);
            this.backGround.Controls.Add(this.platform);
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGround.ForeColor = System.Drawing.Color.Coral;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(800, 450);
            this.backGround.TabIndex = 0;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ball.Location = new System.Drawing.Point(197, 158);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 50);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.platform.Location = new System.Drawing.Point(284, 361);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(155, 23);
            this.platform.TabIndex = 0;
            this.platform.TabStop = false;
            // 
            // lose
            // 
            this.lose.Interval = 1;
            this.lose.Tick += new System.EventHandler(this.lose_Tick);
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.counter.ForeColor = System.Drawing.Color.Black;
            this.counter.Location = new System.Drawing.Point(640, 37);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(112, 24);
            this.counter.TabIndex = 2;
            this.counter.Text = "Ваш счёт: 0";
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLabel.ForeColor = System.Drawing.Color.Red;
            this.loseLabel.Location = new System.Drawing.Point(253, 158);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(350, 55);
            this.loseLabel.TabIndex = 3;
            this.loseLabel.Text = "Вы проиграли!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.backGround.ResumeLayout(false);
            this.backGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backGround;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer lose;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Label loseLabel;
    }
}

