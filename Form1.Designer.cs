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
            this.backGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Controls.Add(this.ball);
            this.backGround.Controls.Add(this.platform);
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
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
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backGround;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Timer lose;
    }
}

