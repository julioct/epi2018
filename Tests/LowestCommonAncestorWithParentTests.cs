using EPI2018.Solutions;
using Xunit;

namespace EPI2018.Tests
{
    public class LowestCommonAncestorWithParentTests
    {
        [Fact]
        public void CanFindLCA()
        {
            var lca = new LowestCommonAncestorWithParentSolution.TreeNodeWithParent<int>(6);
            lca.Parent = new LowestCommonAncestorWithParentSolution.TreeNodeWithParent<int>(314);

            var node0 = new LowestCommonAncestorWithParentSolution.TreeNodeWithParent<int>(2);
            node0.Parent = lca;

            var node1 = new LowestCommonAncestorWithParentSolution.TreeNodeWithParent<int>(28);
            node1.Parent = new LowestCommonAncestorWithParentSolution.TreeNodeWithParent<int>(271);
            node1.Parent.Parent = lca;

            var expected = lca;
            var actual = LowestCommonAncestorWithParentSolution.LCA(node0, node1);

            Assert.Equal(expected, actual);
        }
    }
}
