namespace Branches
{
    public class Branch<T>
    {
        public T BranchData { get; set; }
        public List<Branch<T>> Branches { get; set; }

        public Branch(T branchData)
        {
            BranchData = branchData;
            Branches = new List<Branch<T>>();
        }

        public void AddBranch(Branch<T> branch)
        {
            Branches.Add(branch);
        }

        public void RemoveBranch(Branch<T> branch)
        {
            Branches.Remove(branch);
        }
    }
}
