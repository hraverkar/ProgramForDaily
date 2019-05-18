package com.company;

class Node {
    int key;
    Node left, right;

    public Node(int item) {
        this.key = item;
        left = right = null;
    }
}

class BinaryTree {
    public Node root;
    static int findMax(Node node)
    {
        if (node == null) return Integer.MIN_VALUE;
        int res = node.key;
        int lres = findMax(node.left);
        int rres = findMax(node.right);

        if(lres > res)
            res = lres;
        if(rres > res)
            res = rres;
        return res;
    }
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

        System.out.println("Maximum element is " +
            bt.findMax(bt.root));
    }
}
