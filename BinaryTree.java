package com.company;

class Node {
    int key;
    Node left, right;

    public Node(int item) {
        this.key = item;
        left = right = null;
    }
}

class BinaryTree{
    public Node root;
    public BinaryTree()
    {
        root = null;
    }

    void InOrder(Node node)
    {
        if(node == null) return;
        InOrder(node.left);
        System.out.println(node.key + " ");
        InOrder(node.right);
    }

    void PreOrder(Node node)
    {
        if(node == null) return;
        System.out.println(node.key +" ");
        PreOrder(node.left);
        PreOrder(node.right);
    }

    void PostOrder(Node node)
    {
        if (node == null)return;
        PostOrder(node.left);
        PostOrder(node.right);
        System.out.println(node.key +" ");
    }

    void InOrder(){InOrder(root);}
    void PreOrder(){PreOrder(root);}
    void PostOrder(){PostOrder(root);}
}

public class Main {
    public static void main(String[] args) {
        // write your code here
        System.out.println("Hello Harshal Raverkar");
        BinaryTree bt = new BinaryTree();
        bt.root = new Node(1);
        bt.root.left = new Node(2);
        bt.root.right = new Node(3);
        bt.root.left.left = new Node(4);
        bt.root.left.right = new Node(5);
        bt.root.right.left = new Node(6);
        bt.root.right.right = new Node(7);

        System.out.println("Inorder Traversal of binary tree");
        bt.InOrder();
        System.out.println("PreOrder Traversal of Binary tree");
        bt.PreOrder();
        System.out.println("PostOrder Traversal of binary tree");
        bt.PostOrder();
    }
}
