using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAL
{
    public class DrugDAL
    {
        DataBaseDataContext db;
        public DrugDAL()
        {
            db = new DataBaseDataContext();
        }      
        public List<Drug> getAllDrug()
        {
            var ls = db.Drugs.ToList();
            return db.Drugs.ToList();
        }
        public Drug getOneDrug(int Id)
        {
            return db.Drugs.Where(x => x.DrugID == Id).FirstOrDefault();
        }
        public void insertDrug(Drug Drug)
        {
            db.Drugs.InsertOnSubmit(Drug);
            db.SubmitChanges();
        }
        public void updateDrug(Drug Drug)
        {
            //db.Drugs.     
            //db.SubmitChanges();
        }   
    }
}
