using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotDog : Dog, IRobot
    {
        public RobotDog(string name, COLOR color, int year)
            : base(name,color,year)
        {

        }

        public override string ToString()
        {
            return $"ROBOTDOG:{Name}";
        }

        //자동구현 프로퍼티
        public int BatteryLevel { get; set; }
        
        public void Charge()
        {
            BatteryLevel = 1000;
        }
    }
}
