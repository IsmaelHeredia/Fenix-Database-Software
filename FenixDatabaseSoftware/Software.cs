using System;
using System.Collections.Generic;
using System.Text;

namespace FenixDatabaseSoftware
{
    class Software
    {
        int id_software;
        string name;
        string link;

        public int pId_software
        {
            get { return id_software; }
            set { id_software = value; }
        }

        public String pName
        {
            get { return name; }
            set { name = value; }
        }

        public String pLink
        {
            get { return link; }
            set { link = value; }
        }
    }
}
