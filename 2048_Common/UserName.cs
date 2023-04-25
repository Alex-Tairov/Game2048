using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_Common
{
    public class UserName
    {
        public string name;
        public int score;

        public UserName(string name)
        {
            this.name = name;
            score = 0;
        }
    }
}