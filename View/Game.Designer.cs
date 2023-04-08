namespace RPS_GUI.View
{
    partial class Game
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.rock_button = new System.Windows.Forms.Button();
            this.scissor_button = new System.Windows.Forms.Button();
            this.paper_button = new System.Windows.Forms.Button();
            this.player_image = new System.Windows.Forms.PictureBox();
            this.com_image = new System.Windows.Forms.PictureBox();
            this.message1 = new System.Windows.Forms.Label();
            this.message2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.player_win_label = new System.Windows.Forms.Label();
            this.com_win_label = new System.Windows.Forms.Label();
            this.round_label = new System.Windows.Forms.Label();
            this.totitle_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_image)).BeginInit();
            this.SuspendLayout();
            // 
            // rock_button
            // 
            this.rock_button.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rock_button.Location = new System.Drawing.Point(40, 456);
            this.rock_button.Name = "rock_button";
            this.rock_button.Size = new System.Drawing.Size(200, 103);
            this.rock_button.TabIndex = 0;
            this.rock_button.Text = "グー";
            this.rock_button.UseVisualStyleBackColor = true;
            this.rock_button.Click += new System.EventHandler(this.rock_button_Click);
            // 
            // scissor_button
            // 
            this.scissor_button.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scissor_button.Location = new System.Drawing.Point(304, 456);
            this.scissor_button.Name = "scissor_button";
            this.scissor_button.Size = new System.Drawing.Size(200, 103);
            this.scissor_button.TabIndex = 1;
            this.scissor_button.Text = "チョキ";
            this.scissor_button.UseVisualStyleBackColor = true;
            this.scissor_button.Click += new System.EventHandler(this.scissor_button_Click);
            // 
            // paper_button
            // 
            this.paper_button.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paper_button.Location = new System.Drawing.Point(560, 456);
            this.paper_button.Name = "paper_button";
            this.paper_button.Size = new System.Drawing.Size(200, 103);
            this.paper_button.TabIndex = 2;
            this.paper_button.Text = "パー";
            this.paper_button.UseVisualStyleBackColor = true;
            this.paper_button.Click += new System.EventHandler(this.paper_button_Click);
            // 
            // player_image
            // 
            this.player_image.Location = new System.Drawing.Point(56, 144);
            this.player_image.Name = "player_image";
            this.player_image.Size = new System.Drawing.Size(166, 195);
            this.player_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player_image.TabIndex = 3;
            this.player_image.TabStop = false;
            // 
            // com_image
            // 
            this.com_image.Location = new System.Drawing.Point(576, 144);
            this.com_image.Name = "com_image";
            this.com_image.Size = new System.Drawing.Size(166, 195);
            this.com_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.com_image.TabIndex = 4;
            this.com_image.TabStop = false;
            // 
            // message1
            // 
            this.message1.AutoSize = true;
            this.message1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message1.Location = new System.Drawing.Point(296, 56);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(180, 43);
            this.message1.TabIndex = 5;
            this.message1.Text = "メッセージ";
            this.message1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // message2
            // 
            this.message2.AutoSize = true;
            this.message2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.message2.Location = new System.Drawing.Point(320, 216);
            this.message2.Name = "message2";
            this.message2.Size = new System.Drawing.Size(179, 60);
            this.message2.TabIndex = 6;
            this.message2.Text = "ポン！";
            this.message2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player_win_label
            // 
            this.player_win_label.AutoSize = true;
            this.player_win_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.player_win_label.Location = new System.Drawing.Point(72, 400);
            this.player_win_label.Name = "player_win_label";
            this.player_win_label.Size = new System.Drawing.Size(122, 20);
            this.player_win_label.TabIndex = 7;
            this.player_win_label.Text = "プレイヤーn勝";
            // 
            // com_win_label
            // 
            this.com_win_label.AutoSize = true;
            this.com_win_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.com_win_label.Location = new System.Drawing.Point(616, 400);
            this.com_win_label.Name = "com_win_label";
            this.com_win_label.Size = new System.Drawing.Size(86, 20);
            this.com_win_label.TabIndex = 8;
            this.com_win_label.Text = "COMn勝";
            // 
            // round_label
            // 
            this.round_label.AutoSize = true;
            this.round_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.round_label.Location = new System.Drawing.Point(352, 400);
            this.round_label.Name = "round_label";
            this.round_label.Size = new System.Drawing.Size(95, 20);
            this.round_label.TabIndex = 9;
            this.round_label.Text = "n引き分け";
            // 
            // totitle_button
            // 
            this.totitle_button.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.totitle_button.Location = new System.Drawing.Point(608, 64);
            this.totitle_button.Name = "totitle_button";
            this.totitle_button.Size = new System.Drawing.Size(128, 40);
            this.totitle_button.TabIndex = 10;
            this.totitle_button.Text = "タイトル画面";
            this.totitle_button.UseVisualStyleBackColor = true;
            this.totitle_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.totitle_button);
            this.Controls.Add(this.round_label);
            this.Controls.Add(this.com_win_label);
            this.Controls.Add(this.player_win_label);
            this.Controls.Add(this.message2);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.com_image);
            this.Controls.Add(this.player_image);
            this.Controls.Add(this.paper_button);
            this.Controls.Add(this.scissor_button);
            this.Controls.Add(this.rock_button);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.player_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.com_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock_button;
        private System.Windows.Forms.Button scissor_button;
        private System.Windows.Forms.Button paper_button;
        private System.Windows.Forms.PictureBox player_image;
        private System.Windows.Forms.PictureBox com_image;
        private System.Windows.Forms.Label message1;
        private System.Windows.Forms.Label message2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label player_win_label;
        private System.Windows.Forms.Label com_win_label;
        private System.Windows.Forms.Label round_label;
        private System.Windows.Forms.Button totitle_button;
    }
}
