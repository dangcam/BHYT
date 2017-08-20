using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHYT.DAO
{
    public class DataBaseDAO
    {
        Connection db = null;
        public DataBaseDAO (Connection db)
        {
            this.db = db;
        }
        public bool BackUpOrRestore (ref string err, string strSQL)
        {
            return db.BackUpOrRestore (strSQL, ref err);
        }
    }
}
