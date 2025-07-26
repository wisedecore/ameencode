using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class ClsRepacking
    {
        public long Vno;
        public DateTime VDate;
        public DateTime PDate;
        public string Narretion;
        public string Slno;
        public long ItemId;
        public string BatchCode;
        public double QTY;
        public double PRate;
        public double CRate;
        public double SRate;
        public double Mrp;
        public double Amount;
        public double LabourCharge;
        public double CostFactor;
        public double DepoId;

        DBTask _DBTask = new DBTask();

        public void InsertRepacking()
        {
            object[,] ObjArg = new object[16, 2]
            {
                {"@Vno",Vno},
                {"@VDate",VDate},
                {"@PackDate",PDate},
                {"@Narretion",Narretion},
                {"@Slno",Slno},
                {"@ItemId",ItemId},
                {"@BatchCode",BatchCode},
                {"@QTY",QTY},
                {"@PRate",PRate},
                {"@CRate",CRate},
                {"@SRate",SRate},
                {"@MRP",Mrp},
                {"@Amount",Amount},
                {"@DepoId",DepoId},
                {"@LabourCharge",LabourCharge},
                {"@CostFactor",CostFactor}
            };
            _DBTask.ExecuteNonQuery_SP("Insertrepacking", ObjArg);
            return;
        }
    }
}