using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Project_DAL;

namespace Project_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DrugDAL drugdal = new DrugDAL();
        AccountDAL accdal = new AccountDAL();
        PatientDAL patientdal = new PatientDAL();
        PrescriptionDAL presdal = new PrescriptionDAL();
        TypeOfDrugDAL typedal = new TypeOfDrugDAL();
        List<eDrug> IService1.getAllDrugs()
        {
            List<eDrug> ls = new List<eDrug>();
            foreach(Drug dr in drugdal.getAllDrug())
            {
                eDrug edr = new eDrug();
                edr.DrugID = dr.DrugID;
                edr.Description = dr.Description;
                edr.Name = dr.Name;
                edr.Price =Convert.ToDouble(dr.Price);
                edr.TypeID = dr.TypeID;
                ls.Add(edr);
            }
            return ls;
            
        }
        public bool insertDrug(eDrug e)
        {
            try
            {
                Drug d = new Drug();
                d.Description = e.Description;
                d.DrugID = e.DrugID;
                d.Name = e.Name;
                d.Price = Convert.ToDecimal(e.Price);
                d.TypeID = e.TypeID;
                drugdal.insertDrug(d);
                return true;
            }
            catch
            {
                return false;
            }
        }




        public eDrug getOneDrug(int id)
        {
            var result= drugdal.getOneDrug(id);
            eDrug e = new eDrug();
            e.TypeID = result.TypeID;
            e.Description = result.Description;
            e.DrugID = result.DrugID;
            e.Name = result.Name;
            e.Price =Convert.ToDouble(result.Price);
            return e;
        }


        public bool updateDrug(eDrug e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// account 
        /// </summary>
        /// <returns></returns>
        public List<Account> getAllAccount()
        {
            return accdal.getAllAccount();
        }        

        public bool insertAccount(Account e)
        {
            try
            {
                accdal.insertAccount(e);
                return true;
            }
            catch{
                return false;
            }
        }

        public Account getOneAccount(string id)
        {
            return accdal.getOneAccount(id);
        }

       
        public bool updateAccount(Account e)
        {
            throw new NotImplementedException();
        }
     
        // Type of drug
        public List<TypeOfDrug> getAllTypeDrugs()
        {
            return typedal.getAllTypeOfDrug();
        }

        public bool insertTypeDrug(TypeOfDrug e)
        {
            try
            {
                typedal.insertTypeOfDrug(e);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public TypeOfDrug getOneTypeDrug(int id)
        {
            return typedal.getOneTypeOfDrug(id);
        }

        public bool updateTypeDrug(TypeOfDrug e)
        {
            throw new NotImplementedException();
        }

        // patient


        public List<Patient> getAllParient()
        {
            return patientdal.getAllPatient();
        }

        public bool insertParient(Patient e)
        {
            try
            {
                patientdal.insertPatient(e);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Patient getOneParient(int id)
        {
            return patientdal.getOnePatient(id);
        }

        public bool updateParient(Patient e)
        {
            throw new NotImplementedException();
        }


        // prescription
        public List<PrescriptionDetail> getAllPrescriptionDetail()
        {
            return presdal.getAllPrescription();
        }

        public bool insertPrescriptionDetail(PrescriptionDetail e)
        {
            try
            {
                presdal.insertPrescription(e);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public PrescriptionDetail getOnePrescriptionDetail(int id)
        {
            return presdal.getOnePrescription(id);
        }

        public bool updatePrescriptionDetail(PrescriptionDetail e)
        {
            throw new NotImplementedException();
        }
    }
}
