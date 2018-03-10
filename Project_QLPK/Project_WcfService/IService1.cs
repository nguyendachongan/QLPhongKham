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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Drug
        [OperationContract]
        List<eDrug> getAllDrugs();

        [OperationContract]
        bool insertDrug(eDrug e);

        [OperationContract]
        eDrug getOneDrug(int id);

        [OperationContract]
        bool updateDrug(eDrug e);

        // Account

        [OperationContract]
        List<Account> getAllAccount();

        [OperationContract]
        bool insertAccount(Account e);

        [OperationContract]
        Account getOneAccount(string id);

        [OperationContract]
        bool updateAccount(Account e);

        // Type of Drug

        [OperationContract]
        List<TypeOfDrug> getAllTypeDrugs();

        [OperationContract]
        bool insertTypeDrug(TypeOfDrug e);

        [OperationContract]
        TypeOfDrug getOneTypeDrug(int id);

        [OperationContract]
        bool updateTypeDrug(TypeOfDrug e);

        // Parient

        [OperationContract]
        List<Patient> getAllParient();

        [OperationContract]
        bool insertParient(Patient e);

        [OperationContract]
        Patient getOneParient(int id);

        [OperationContract]
        bool updateParient(Patient e);

        // Prescription

        [OperationContract]
        List<PrescriptionDetail> getAllPrescriptionDetail();

        [OperationContract]
        bool insertPrescriptionDetail(PrescriptionDetail e);

        [OperationContract]
        PrescriptionDetail getOnePrescriptionDetail(int id);

        [OperationContract]
        bool updatePrescriptionDetail(PrescriptionDetail e);

    }

    [DataContract]
    public class eDrug
    {
        [DataMember]
        public int DrugID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public int TypeID { get; set; }

    }
}
