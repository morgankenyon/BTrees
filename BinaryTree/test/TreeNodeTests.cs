using FluentAssertions;

namespace BinTree.Tests;

public class TreeNodeTests
{
    [Fact]
    public void TreeNode_CanCreate()
    {
        //act
        var treeNode = new TreeNode(23);

        //assert
        treeNode.Value.Should().Be(23);
        treeNode.Left.Should().BeNull();
        treeNode.Right.Should().BeNull();
    }
}
