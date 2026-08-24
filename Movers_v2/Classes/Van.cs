using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_v2
{

    public class Van
    {
        int vanID;
        string regNo, model, color, size;
        DateTime motDueDate;

        public Van(int vID, string re, DateTime mD, string mo, string co, string si)
        {
            vanID = vID;
            regNo = re;
            motDueDate = mD;
            model = mo;
            color = co;
            size = si;

        }

        public Van()
        {
            vanID = 0;
            motDueDate = new DateTime();
            regNo = null;
            model = "";
            color = "";
            size = "";
        }

        public int VanID
        { get { return vanID; } 
          set { vanID = value; }
        }

        public DateTime MotDueDate
        {
            get { return motDueDate; }
            set { motDueDate = value; }
        }
        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }


    }
}
