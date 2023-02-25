// See https://aka.ms/new-console-template for more information
using Branches;

var root = new Branch<int>(1);
var branch1 = new Branch<int>(2);
var branch2 = new Branch<int>(3);
var grandBranch1 = new Branch<int>(4);
var grandBranch2 = new Branch<int>(5);
var grandBranch3 = new Branch<int>(6);
var grandBranch4 = new Branch<int>(7);
var greatgrandBranch1 = new Branch<int>(8);
var greatgrandBranch2 = new Branch<int>(9);
var greatgrandBranch3 = new Branch<int>(10);
var greatgreatgrandBranch1 = new Branch<int>(11);

root.AddBranch(branch1);
root.AddBranch(branch2);

branch1.AddBranch(grandBranch1);
branch2.AddBranch(grandBranch2);
branch2.AddBranch(grandBranch3);
branch2.AddBranch(grandBranch4);

grandBranch2.AddBranch(greatgrandBranch1);
grandBranch3.AddBranch(greatgrandBranch2);
grandBranch3.AddBranch(greatgrandBranch3);

grandBranch3.AddBranch(greatgreatgrandBranch1);
