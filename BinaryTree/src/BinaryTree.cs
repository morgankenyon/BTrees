namespace BinTree;

public class BinaryTree
{
    public TreeNode? Root { get; private set; }

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode? node, int value)
    {
        if (node == null)
        {
            node = new TreeNode(value);
            return node;
        }

        if (value < node.Value)
        {
            node.Left = InsertRec(node.Left, value);
        }
        else
        {
            node.Right = InsertRec(node.Right, value);
        }

        return node;
    }

    public int Count() => CountRec(Root);

    private int CountRec(TreeNode? treeNode)
    {
        if (treeNode != null)
        {
            var leftCount = CountRec(treeNode.Left);
            var rightCount = CountRec(treeNode.Right);
            return leftCount + rightCount + 1;
        }
        return 0;
    }

    public IEnumerable<int> InOrderTraversal() => InOrderRec(Root);

    private IEnumerable<int> InOrderRec(TreeNode? node)
    {
        if (node != null)
        {
            foreach (var lValue in InOrderRec(node.Left))
                yield return lValue;

            yield return node.Value;

            foreach (var rValue in InOrderRec(node.Right))
                yield return rValue;
        }
    }

    public IEnumerable<int> PreOrderTraversal() => PreOrderRec(Root);

    private IEnumerable<int> PreOrderRec(TreeNode? node)
    {
        if (node != null)
        {
            yield return node.Value;

            foreach (var lValue in PreOrderRec(node.Left))
                yield return lValue;

            foreach (var rValue in PreOrderRec(node.Right))
                yield return rValue;
        }
    }

    public IEnumerable<int> PostOrderTraversal() => PostOrderRec(Root);

    private IEnumerable<int> PostOrderRec(TreeNode? node)
    {
        if (node != null)
        {
            foreach (var lValue in PostOrderRec(node.Left))
                yield return lValue;

            foreach (var rValue in PostOrderRec(node.Right))
                yield return rValue;

            yield return node.Value;
        }
    }
}