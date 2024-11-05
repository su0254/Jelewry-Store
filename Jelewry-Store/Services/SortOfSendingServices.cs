using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class SortOfSendingServices
    {

        static int id = 1;
        static List<SortOfSending> sortsOfSending = new List<SortOfSending>();

        public List<SortOfSending> GetAllSendings()
        {
            return sortsOfSending;
        }
        public SortOfSending GetSendingByCode(int sendingCode)
        {
            foreach (var sortOfSending in sortsOfSending)
            {
                if (sortOfSending.SendingCode == sendingCode)
                    return sortOfSending;
            }
            return null;
        }
        public void AddSending(SortOfSending sending)
        {
            sending.Id = id++;
            sortsOfSending.Add(sending);
        }
        public void PutSending(int sendingCode, SortOfSending sending)
        {
            for (int i = 0; i < sortsOfSending.Count(); i++)
            {
                if (sortsOfSending[i].SendingCode == sendingCode)
                    sortsOfSending[i] = sending;
            }
        }
        public void DeleteSending(int sendingCode)
        {
            foreach (var sending in sortsOfSending)
            {
                if (sending.SendingCode == sendingCode)
                {
                    sortsOfSending.Remove(sending);
                    return;
                }
            }
        }
    }
}
