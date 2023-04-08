using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPS_GUI.Core
{
    internal class Player
    {
        private int decision;
        private int win_count;
        public Player() {
            decision = 0;
            win_count = 0;
        }

        public void setDecision(int button_value){
            decision = button_value;
        }

        public int getDecision(){
            return decision; 
        }

        public void comDecision()
        {
            Random random= new Random();
            decision = random.Next(0,3);
        }

        public void addWinCount()
        {
            win_count++;
        }

        public int getWinCount() 
        { 
            return win_count;
        }
    }
}
