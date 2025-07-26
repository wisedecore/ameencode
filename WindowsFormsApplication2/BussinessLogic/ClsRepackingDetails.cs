using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsRepackingDetails
    {
        public long Vno;
        public string Slno;
        public float ItemId;
        public string Batchcode;
        public double Qty;
        public double Prate;
        public double Crate;
        public double Srate;
        public double Mrp;
        public double Amount;
        public double DepoId;

        DBTask _DBTask = new DBTask();

        public void InsertRepackingDetails()
        {
            object[,] ObjArg = new object[11, 2]
            {
                {"@Vno",Vno},
                {"@Slno",Slno},
                {"@ItemId",ItemId},
                {"@BatchCode",Batchcode},
                {"@QTY",Qty},
                {"@PRate",Prate},
                {"@Crate",Crate},
                {"@SRate",Srate},
                {"@MRP",Mrp},
                {"@Amount",Amount},
                 {"@DepoId",DepoId}
            };

            _DBTask.ExecuteNonQuery_SP("Insertrepackingdetails", ObjArg);
            return;
        }

    }
}
