using Jelewry_Store.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Jelewry_Store.Services
{
    public class SortOfSendingServices
    {
        
        static int id = 1;

        public List<SortOfSending> GetAllSendings()
        {
            return DataContextManager.Manager.SortOfSendings;
        }
        public SortOfSending GetSendingByCode(string sendingCode)
        {
            if (DataContextManager.Manager.SortOfSendings == null) return null;
            return DataContextManager.Manager.SortOfSendings.Find((s) => s.SendingCode == sendingCode);
        }
        public void AddSending(SortOfSending sending)
        {
            sending.Id = id++;
            DataContextManager.Manager.SortOfSendings.Add(sending);
        }
        public bool PutSending(string sendingCode, SortOfSending sending)
        {
            if(sending == null) return false;
            SortOfSending s=DataContextManager.Manager.SortOfSendings.Find((s)=>s.SendingCode == sendingCode);
            s.SendingCode = sendingCode;
            s.DescraptionSending = sending.DescraptionSending;
            s.Price= sending.Price;
            s.NumOfDays = sending.NumOfDays;
            s.EAreas = sending.EAreas;
            s.MaxItem= sending.MaxItem;
            s.Conditions = sending.Conditions;
            return true;
        }
        public bool DeleteSending(string sendingCode)
        {
            SortOfSending s = DataContextManager.Manager.SortOfSendings.Find((s) => s.SendingCode == sendingCode);
            if (s == null) return false;
            DataContextManager.Manager.SortOfSendings.Remove(s);
            return true;
        }
    }
}
