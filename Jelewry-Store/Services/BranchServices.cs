using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class BranchServices
    {
        static List<Branch> branches = new List<Branch>();
        static int id = 1;
        public List<Branch> GetAllBranches()
        {
            return branches;
        }
        public Branch GetBranchByCode(int codeBranch)
        {
            foreach (var branch in branches)
            {
                if (branch.CodeBranch == codeBranch)
                    return branch;
            }
            return null;
        }
        public bool AddBranch(Branch branch)
        {
            if(branch == null) return false;
            branch.Id = id++;
            branches.Add(branch);
            return true;
        }
        public bool PutBranch(int codeBranch, Branch branch)
        {
            if (branch == null) return false;
            Branch b = branches.Find(b => b.CodeBranch == codeBranch);
            b.CodeManager=branch.CodeManager;
            b.CodeBranch = codeBranch;
            b.Adress=branch.Adress;
            b.City=branch.City;
            b.PhoneNumber=branch.PhoneNumber;
            b.Open=branch.Open;
            b.Close=branch.Close;
            return true;
        }
        public void DeleteSending(int codeBranch)
        {
            foreach (var branch in branches)
            {
                if (branch.CodeBranch == codeBranch)
                {
                    branches.Remove(branch);
                    return;
                }
            }
        }
    }
}
