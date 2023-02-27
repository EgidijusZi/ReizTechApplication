namespace Branches
{
    public class Branch<T>
    {
        public T BranchData { get; set; }
        public List<Branch<T>> branches { get; set; }

        public Branch(T branchData)
        {
            BranchData = branchData;
            branches = new List<Branch<T>>();
        }

        public List<Branch<T>> Branches
        {
            get { return branches; }
            set { branches = value; }
        }

        public void AddBranch(Branch<T> branch)
        {
            Branches.Add(branch);
        }

        public void RemoveBranch(Branch<T> branch)
        {
            Branches.Remove(branch);
        }

        public static int Depth(Branch<T> root, int depth)
        {
            int result = depth + 1;

            foreach (Branch<T> branch in root.Branches)
            {
                result = Math.Max(result, Depth(branch, depth + 1));
            }

            return result;
        }
    }
}
