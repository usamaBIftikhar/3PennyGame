using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3PennyGame
{
    class Player
    {
        private String first;
        private String second;
        private String third;
        public Player(String f , String s, String t)
        {
            this.first = f;
            this.second = s;
            this.third = t;
        }
        public String GetFirst() { return this.first; }
        public String GetSecond() { return this.second; }
        public String GetThird() { return this.third; }
        public void SetFirst(String f) { this.first = f; }
        public void SetSecond(String s) { this.second = s; }
        public void SetThird(String t) { this.third = t; }
        public bool ComparePlayer(String f, String s, String t)
        {
            if(this.first == f)
            {
                if(this.second == s)
                {
                    if(this.third == t)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
