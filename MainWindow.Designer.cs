namespace RPS_GUI
{
    partial class MainWindow
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.start_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.title_screen = new RPS_GUI.View.Title();
            this.game_screen = new RPS_GUI.View.Game();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.start_button.Location = new System.Drawing.Point(32, 400);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(216, 128);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "スタート";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_Click);
            // 
            // quit_button
            // 
            this.quit_button.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.quit_button.Location = new System.Drawing.Point(536, 400);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(216, 128);
            this.quit_button.TabIndex = 5;
            this.quit_button.Text = "終了";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_Click);
            // 
            // title_screen
            // 
            this.title_screen.BackColor = System.Drawing.SystemColors.Control;
            this.title_screen.Location = new System.Drawing.Point(-8, -40);
            this.title_screen.Name = "title_screen";
            this.title_screen.Size = new System.Drawing.Size(800, 600);
            this.title_screen.TabIndex = 3;
            // 
            // game_screen
            // 
            this.game_screen.AutoSize = true;
            this.game_screen.Location = new System.Drawing.Point(0, -16);
            this.game_screen.Name = "game_screen";
            this.game_screen.Size = new System.Drawing.Size(784, 576);
            this.game_screen.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.title_screen);
            this.Controls.Add(this.game_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private View.Title title_screen;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button quit_button;
        private View.Game game_screen;
    }
}

