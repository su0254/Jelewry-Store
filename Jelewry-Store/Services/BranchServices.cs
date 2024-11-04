using Jelewry_Store.Entities;

namespace Jelewry_Store.Services
{
    public class BranchServices
    {
        static List<Branch> branches = new List<Branch>();

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
        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }
        public void PutBranch(int codeBranch, Branch branch)
        {
            for (int i = 0; i < branches.Count(); i++)
            {
                if (branches[i].CodeBranch == codeBranch)
                    branches[i] = branch;
            }
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
