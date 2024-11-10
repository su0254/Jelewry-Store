using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class BranchServices
    {
        
        static int id = 1;
        public List<Branch> GetAllBranches()
        {
            return DataContextManager.Manager.Branches;
        }
        public Branch GetBranchByCode(int codeBranch)
        {
            if (DataContextManager.Manager.Users == null) return null;
            return DataContextManager.Manager.Branches.Find((b) => b.CodeBranch == codeBranch);
        }
        public bool AddBranch(Branch branch)
        {
            if(branch == null) return false;
            branch.Id = id++;
            DataContextManager.Manager.Branches.Add(branch);
            return true;
        }
        public bool PutBranch(int codeBranch, Branch branch)
        {
            if (branch == null) return false;
            Branch b = DataContextManager.Manager.Branches.Find(b => b.CodeBranch == codeBranch);
            b.CodeManager=branch.CodeManager;
            b.CodeBranch = codeBranch;
            b.Adress=branch.Adress;
            b.City=branch.City;
            b.PhoneNumber=branch.PhoneNumber;
            b.Open=branch.Open;
            b.Close=branch.Close;
            return true;
        }
        public bool DeleteSending(int codeBranch)
        {
            Branch b = DataContextManager.Manager.Branches.Find((b) => b.CodeBranch == codeBranch);
            if (b == null) return false;
            DataContextManager.Manager.Branches.Remove(b);
            return true;
        }
    }
}
