using AdTrack.Data;
using AdTrack.Data.Model;
using BigSoft.Framework.Util;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace AdTrack.Business
{
    public class OCompanyGet : AdOperations
    {
        public List<Company> CompanyList
        { get; set; }

        protected override void DoJob()
        {
            CompanyRepository repo = new CompanyRepository(OpConn);
            CompanyList = repo.GetList();
        }
    }

    public class OCompanySave : AdOperations
    {
        private readonly Company Obj;

        public OCompanySave(Company obj)
        {
            Obj = obj;
        }

        protected override void DoJob()
        {
            OCompanyUtil.CheckDuplicateCompany(Obj, OpConn);

            //Firma kayıt
            string query = string.Format("INSERT INTO Company (CompanyName, Status, Explanation) VALUES ('{0}',{1},'{2}');",
                                         Obj.NewCompanyName, Obj.StatusId, Obj.Explanation);
            BaseRepo.BsExecute(query);
            int companyId = (int)OpConn.LastInsertRowId;

            //Adres ve Telefon kayıtları
            OCompanyUtil.SaveAddressAndTel(Obj, OpConn, companyId);
        }
    }

    public class OCompanyUpdate : AdOperations
    {
        private readonly Company Obj;

        public OCompanyUpdate(Company obj)
        {
            Obj = obj;
        }

        protected override void DoJob()
        {
            OCompanyUtil.CheckDuplicateCompany(Obj, OpConn);

            string query = "UPDATE Company SET CompanyName = @CompanyName, Status = @Status, Explanation = @Explanation " +
                                 "WHERE CompanyId = @CompanyId";
            BaseRepo.BsExecute(query, new { Obj.CompanyName, Status = Obj.StatusId, Obj.Explanation, Obj.CompanyId });

            //Adresleri sil
            query = string.Format("DELETE FROM Address WHERE CompanyId = {0}", Obj.CompanyId);
            BaseRepo.BsExecute(query);

            //Telefonları sil
            query = string.Format("DELETE FROM Telephone WHERE CompanyId = {0}", Obj.CompanyId);
            BaseRepo.BsExecute(query);

            //Adres ve Telefon kayıtları
            OCompanyUtil.SaveAddressAndTel(Obj, OpConn, Obj.CompanyId);
        }
    }

    public class OCompanyDelete : AdOperations
    {
        private readonly int id;

        public OCompanyDelete(int id)
        {
            this.id = id;
        }

        protected override void DoJob()
        {
            CompanyRepository rep = new CompanyRepository(OpConn);
            string query = string.Format("DELETE FROM Company WHERE CompanyId = {0}", id);
            rep.BsExecute(query);
        }
    }

    public static class OCompanyUtil
    {
        public static void CheckDuplicateCompany(Company obj, SQLiteConnection opConn)
        {
            CompanyRepository companyRepo = new CompanyRepository(opConn);

            if (string.IsNullOrEmpty(obj.CompanyName))
                throw new BsException("Boş girilemez", OpType.UserError);

            if (obj.CompanyName == obj.NewCompanyName)
                return;

            List<Company> companyList = companyRepo.GetList();
            if (companyList.Any(mag => mag.CompanyName == obj.NewCompanyName))
                throw new BsException("Zaten mevcut kayıt", OpType.UserError);
        }

        public static void SaveAddressAndTel(Company obj, SQLiteConnection opConn, int companyId)
        {
            AddressRepository addressRepo = new AddressRepository(opConn);
            TelephoneRepository telRepo = new TelephoneRepository(opConn);

            //Adres defterine kaydet
            if (!string.IsNullOrEmpty(obj.Address1.AddressText.Trim()))
                addressRepo.SaveAddress(obj.Address1, companyId);
            if (!string.IsNullOrEmpty(obj.Address2.AddressText.Trim()))
                addressRepo.SaveAddress(obj.Address2, companyId);
            if (!string.IsNullOrEmpty(obj.Address3.AddressText.Trim()))
                addressRepo.SaveAddress(obj.Address3, companyId);

            //Telefon defterine kaydet
            if (!string.IsNullOrEmpty(obj.Telephone1.Trim()))
                telRepo.SaveTelephone(obj.Telephone1, companyId);
            if (!string.IsNullOrEmpty(obj.Telephone2.Trim()))
                telRepo.SaveTelephone(obj.Telephone2, companyId);
            if (!string.IsNullOrEmpty(obj.Telephone3.Trim()))
                telRepo.SaveTelephone(obj.Telephone3, companyId);
        }
    }
}