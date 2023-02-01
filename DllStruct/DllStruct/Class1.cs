using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace DllStruct
{
    [Serializable]
    public struct info
    {
        // имя пользователя, имя компьютера, ip адрес
        public string username, netname, ip;
        public DateTime dt; // дата и время передачи данных
        public Image scr; // скриншот
        public DriveInfo[] allDrivers; // массив с данными о дисках
        public string[] process;
    }

}
