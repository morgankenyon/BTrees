using FluentAssertions;

namespace BinTree.Tests;

public class BinaryTreeTests
{
    [Fact]
    public void BinaryTree_CanInsertNode()
    {
        //arrange
        var bt = new BinaryTree();

        //act
        bt.Insert(23);

        //assert
        bt.InOrderTraversal().Should().Equal(23);
    }

    [Fact]
    public void BinaryTree_CanInsertMultipleNodes()
    {
        //arrange
        var bt = new BinaryTree();

        //act
        bt.Insert(23);
        bt.Insert(33);

        //assert
        bt.InOrderTraversal().Should().Equal(23, 33);
    }

    [Fact]
    public void BinaryTree_CanTraversePreOrder()
    {
        //arrange
        var bt = new BinaryTree();

        //act
        bt.Insert(20);
        bt.Insert(23);
        bt.Insert(33);
        bt.Insert(0);

        //assert
        bt.PreOrderTraversal().Should().Equal(20, 0, 23, 33);
    }

    [Fact]
    public void BinaryTree_CanTraversePostOrder()
    {
        //arrange
        var bt = new BinaryTree();

        //act
        bt.Insert(20);
        bt.Insert(23);
        bt.Insert(33);
        bt.Insert(0);

        //assert
        bt.PostOrderTraversal().Should().Equal(0, 33, 23, 20);
    }
}