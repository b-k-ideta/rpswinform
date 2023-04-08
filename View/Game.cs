using RPS_GUI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RPS_GUI.View
{
    public partial class Game : UserControl
    {
        private Player player;
        private Player com;
        private GameCore core_script;
        private int button_value;
        private bool second_time;
        private bool is_processing;

        public Game()
        {
            InitializeComponent();
            player = new Player();
            com = new Player();
            core_script = new GameCore();
            message1.Text = core_script.getMessage();
            message2.Text = "";
            second_time = false;
            is_processing = false;
            button_value = 0;
            UpdateWinCount();
        }

        private void rock_button_Click(object sender, EventArgs e)
        {
            if (is_processing == false)
            {
                button_value = 0;
                ImageChanger(button_value, player_image);
                GameProcess();
            }
        
        }

        private void paper_button_Click(object sender, EventArgs e)
        {
            if (is_processing == false)
            {
                button_value = 1;
                ImageChanger(button_value, player_image);
                GameProcess();
            }
                
        }

        private void scissor_button_Click(object sender, EventArgs e)
        {
            if (is_processing == false)
            {
                button_value = 2;
                ImageChanger(button_value, player_image);
                GameProcess();
            }
         
        }

        private void ShowMessage()
        {
            core_script.setMessage();
            message1.Text = core_script.getMessage();
            message1.Update();
        }

        private void UpdateWinCount()
        {
            int pl_win_cnt = player.getWinCount();
            player_win_label.Text = "プレイヤー" + pl_win_cnt.ToString()+"勝";
            int com_win_cnt = com.getWinCount();
            com_win_label.Text = "COM" + com_win_cnt.ToString()+"勝";
            int draw_count = core_script.getRound();
            round_label.Text = draw_count.ToString() + "戦目";
            Label[] winCounts = {player_win_label, com_win_label, round_label};
            foreach (var win in winCounts)
            {
                win.Update();
            }
        }

        private void PonMessage(bool show_message)
        {
            if (show_message == true){
                if (second_time == true)
                {
                    message2.Text = "しょ！";
                }
                else
                {
                    message2.Text = "ポン！";
                }
            }
            else
            {
                message2.Text = "";
            }
            message2.Update();
            
        }

        private void ResetAll()
        {
            PonMessage(false);
            second_time = false;
            core_script.resetGame();
            ResetImage();
            ShowMessage();
        }

        private void ImageChanger(int decision, PictureBox image_field)
        {
            switch (decision)
            {
                case 0:
                    image_field.Load(@".\Img\rock.png");
                    image_field.Update();
                    break;
                case 1:
                    image_field.Load(@".\Img\paper.png");
                    image_field.Update();
                    break;
                case 2:
                    image_field.Load(@".\Img\scissor.png");
                    image_field.Update();
                    break;
            }
        }

        private void ResetImage()
        {
            player_image.Image = null;
            player_image.Update();
            com_image.Image = null;
            com_image.Update();
        }

        private async void GameProcess()
        {
            is_processing = true;
            player.setDecision(button_value);
            com.comDecision();
            ImageChanger(com.getDecision(), com_image);
            PonMessage(true);
            string winner = core_script.whoWin(player.getDecision(), com.getDecision());
            await Task.Delay(700);
            ShowMessage();
            PonMessage(false);
            
            if (winner == "引き分け")
            {
                second_time = true;
                ResetImage();
                await Task.Delay(500);
                is_processing = false;
            } 
            else{
                await Task.Delay(700);
                switch (winner){
                    case "プレイヤー":
                        player.addWinCount();
                        ResetAll();
                        break;
                    case "COM":
                        com.addWinCount();
                        ResetAll();
                        break;
                    }
                core_script.addRound();
                UpdateWinCount();
                is_processing = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
