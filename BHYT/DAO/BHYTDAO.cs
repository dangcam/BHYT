using BHYT.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BHYT.DAO
{
    public class BHYTDAO
    {
        Connection db = null;
        public BHYTDAO(Connection db)
        {
            this.db = db;
        }
        public BHYTVO getBHYT(int maSo)
        {
            BHYTVO bhyt = new BHYTVO ();
            DataTable data = new DataTable ();
            data = db.ExcuteQuery ("Select  * From BHYT Where MA_SO = " + maSo,
                CommandType.Text, null);
            if(data !=null)
            {
                foreach(DataRow dr in data.Rows)
                {
                    bhyt.MaSo = int.Parse (dr[0].ToString());
                    bhyt.NhomDT = dr[1].ToString ();
                    bhyt.TyLe = int.Parse (dr[2].ToString ());
                    return bhyt;
                }
            }
            return null;
        }
    }
}
