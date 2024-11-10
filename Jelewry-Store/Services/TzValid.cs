
namespace Jelewry_Store.Services
{
    public enum ErrorTZ
    {
        LanghtNotValid,
        DigitsNotOk,
        NotInt,
        OK
    }
    public class TzValid
    {
        public TzValid() { }
        public bool ISOK(string idTZ, out ErrorTZ error)
        {
            if (idTZ == null)
            {
                error = ErrorTZ.LanghtNotValid;
                return false;
            }
            
            if (idTZ.Length != 9)
            {
                error = ErrorTZ.LanghtNotValid;
                return false;
            }
            int id = 0;
            bool ret = int.TryParse(idTZ, out id);
            if (!ret)
            {
                error = ErrorTZ.NotInt;
                return false;
            }
            int digit, sum = 0;
            int checksum = id % 10;
            id /= 10;

            for (int i = 0; i < 8; i++)
            {
                digit = id % 10;
                id /= 10;
                if (i % 2 == 0)
                    digit *= 2;
                if (digit > 9)
                    digit = digit / 10 + digit % 10;
                sum += digit;
            }
            if ((10 - sum % 10) == checksum)
            {
                error = ErrorTZ.OK;
                return true;
            }
            error = ErrorTZ.DigitsNotOk;
            return false;
        }
    }
}
