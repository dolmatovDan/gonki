namespace gonki
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
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine3 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine2 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine1 = new System.Windows.Forms.PictureBox();
            this.pbBoundRight = new System.Windows.Forms.PictureBox();
            this.pbBoundLeft = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pbRoadLine4 = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.LblGameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.BackgroundImage = global::gonki.Properties.Resources.police;
            this.Enemy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy1.Location = new System.Drawing.Point(178, 665);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(71, 116);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 6;
            this.Enemy1.TabStop = false;
            this.Enemy1.Click += new System.EventHandler(this.Enemy1_Click);
            // 
            // pbRoadLine3
            // 
            this.pbRoadLine3.BackColor = System.Drawing.Color.White;
            this.pbRoadLine3.Location = new System.Drawing.Point(454, 552);
            this.pbRoadLine3.Name = "pbRoadLine3";
            this.pbRoadLine3.Size = new System.Drawing.Size(27, 263);
            this.pbRoadLine3.TabIndex = 5;
            this.pbRoadLine3.TabStop = false;
            // 
            // pbRoadLine2
            // 
            this.pbRoadLine2.BackColor = System.Drawing.Color.White;
            this.pbRoadLine2.Location = new System.Drawing.Point(454, 204);
            this.pbRoadLine2.Name = "pbRoadLine2";
            this.pbRoadLine2.Size = new System.Drawing.Size(27, 263);
            this.pbRoadLine2.TabIndex = 4;
            this.pbRoadLine2.TabStop = false;
            // 
            // pbRoadLine1
            // 
            this.pbRoadLine1.BackColor = System.Drawing.Color.White;
            this.pbRoadLine1.Location = new System.Drawing.Point(454, -133);
            this.pbRoadLine1.Name = "pbRoadLine1";
            this.pbRoadLine1.Size = new System.Drawing.Size(27, 263);
            this.pbRoadLine1.TabIndex = 3;
            this.pbRoadLine1.TabStop = false;
            // 
            // pbBoundRight
            // 
            this.pbBoundRight.BackColor = System.Drawing.Color.White;
            this.pbBoundRight.Location = new System.Drawing.Point(893, 1);
            this.pbBoundRight.Name = "pbBoundRight";
            this.pbBoundRight.Size = new System.Drawing.Size(27, 1051);
            this.pbBoundRight.TabIndex = 1;
            this.pbBoundRight.TabStop = false;
            // 
            // pbBoundLeft
            // 
            this.pbBoundLeft.BackColor = System.Drawing.Color.White;
            this.pbBoundLeft.Location = new System.Drawing.Point(33, 1);
            this.pbBoundLeft.Name = "pbBoundLeft";
            this.pbBoundLeft.Size = new System.Drawing.Size(27, 1051);
            this.pbBoundLeft.TabIndex = 0;
            this.pbBoundLeft.TabStop = false;
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.BackgroundImage = global::gonki.Properties.Resources.police;
            this.Enemy2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy2.Location = new System.Drawing.Point(260, 91);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(71, 116);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 7;
            this.Enemy2.TabStop = false;
            // 
            // Enemy3
            // 
            this.Enemy3.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3.BackgroundImage = global::gonki.Properties.Resources.police;
            this.Enemy3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Enemy3.Location = new System.Drawing.Point(623, 316);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(71, 116);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3.TabIndex = 8;
            this.Enemy3.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.car.Image = global::gonki.Properties.Resources.car;
            this.car.Location = new System.Drawing.Point(695, 799);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(81, 116);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 9;
            this.car.TabStop = false;
            this.car.Click += new System.EventHandler(this.car_Click);
            // 
            // pbRoadLine4
            // 
            this.pbRoadLine4.BackColor = System.Drawing.Color.White;
            this.pbRoadLine4.Location = new System.Drawing.Point(454, 907);
            this.pbRoadLine4.Name = "pbRoadLine4";
            this.pbRoadLine4.Size = new System.Drawing.Size(27, 263);
            this.pbRoadLine4.TabIndex = 10;
            this.pbRoadLine4.TabStop = false;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoins.Location = new System.Drawing.Point(66, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(151, 36);
            this.lblCoins.TabIndex = 11;
            this.lblCoins.Text = "Coins = 0";
            // 
            // Coin1
            // 
            this.Coin1.BackgroundImage = global::gonki.Properties.Resources.coin;
            this.Coin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coin1.Location = new System.Drawing.Point(329, 316);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(43, 43);
            this.Coin1.TabIndex = 12;
            this.Coin1.TabStop = false;
            // 
            // Coin4
            // 
            this.Coin4.BackgroundImage = global::gonki.Properties.Resources.coin;
            this.Coin4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coin4.Location = new System.Drawing.Point(137, 527);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(43, 43);
            this.Coin4.TabIndex = 13;
            this.Coin4.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.BackgroundImage = global::gonki.Properties.Resources.coin;
            this.Coin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coin3.Location = new System.Drawing.Point(547, 626);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(43, 43);
            this.Coin3.TabIndex = 14;
            this.Coin3.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.BackgroundImage = global::gonki.Properties.Resources.coin;
            this.Coin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Coin2.Location = new System.Drawing.Point(750, 135);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(43, 43);
            this.Coin2.TabIndex = 15;
            this.Coin2.TabStop = false;
            // 
            // LblGameOver
            // 
            this.LblGameOver.AutoSize = true;
            this.LblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGameOver.Location = new System.Drawing.Point(298, 503);
            this.LblGameOver.Name = "LblGameOver";
            this.LblGameOver.Size = new System.Drawing.Size(179, 36);
            this.LblGameOver.TabIndex = 16;
            this.LblGameOver.Text = "Game Over";
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(959, 1050);
            this.Controls.Add(this.LblGameOver);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pbRoadLine4);
            this.Controls.Add(this.car);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.pbRoadLine3);
            this.Controls.Add(this.pbRoadLine2);
            this.Controls.Add(this.pbRoadLine1);
            this.Controls.Add(this.pbBoundRight);
            this.Controls.Add(this.pbBoundLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBoundLeft;
        private System.Windows.Forms.PictureBox pbBoundRight;
        private System.Windows.Forms.PictureBox pbRoadLine1;
        private System.Windows.Forms.PictureBox pbRoadLine2;
        private System.Windows.Forms.PictureBox pbRoadLine3;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox pbRoadLine4;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.Label LblGameOver;
        private System.Windows.Forms.Timer gameTimer;
    }
}

