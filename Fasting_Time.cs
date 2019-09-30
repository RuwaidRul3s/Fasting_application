using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeClass;
enum Fasting_Types
{
    OMAD=1,
    SixtennHours,
    TwentyHours
}
namespace TimeClass
{
    [Serializable]
    class Fasting_Time:Time
    {
        public Fasting_Time( )
        {

            FastComplete = false;
             
        }
        public bool Fast_State
        {
            get
            {
                if (this.Hours == 0 && this.Minutes == 0 && this.Seconds == 0)
                {
                    FastComplete = true;
                   
                }
                return FastComplete;
            }
            set
            {
                FastComplete = value;
            }

        }
        public int Fasting_ProtoType { set; get; }
        private bool FastComplete;
       public  bool Marked = false;
    }
}
