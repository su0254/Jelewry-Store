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
            foreach (var sortOfSending in DataContextManager.Manager.SortOfSendings)
            {
                if (sortOfSending.SendingCode == sendingCode)
                    return sortOfSending;
            }
            return null;
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
        public void DeleteSending(string sendingCode)
        {
            foreach (var sending in DataContextManager.Manager.SortOfSendings)
            {
                if (sending.SendingCode == sendingCode)
                {
                    DataContextManager.Manager.SortOfSendings.Remove(sending);
                    return;
                }
            }
        }
    }
}
