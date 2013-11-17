﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinarySearchTree<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, ICloneable where TKey : IComparable<TKey>
{
    //Fields
    private TreeNode root = null;

    //Properties
    public TValue this[TKey key]
    {
        get
        {
            TreeNode searchResult = this.Search(this.root, key);

            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }

            return searchResult.Value;
        }
        set
        {
            TreeNode searchResult = this.Search(this.root, key);

            if (searchResult == null)
            {
                throw new KeyNotFoundException();
            }
            searchResult.Value = value;
        }
    }

    public ICollection<TKey> Keys
    {
        get
        {
            ICollection<TKey> keys = new List<TKey>();
            InorderTreeWalk(this.root, x => keys.Add(x.Key));
            return keys;
        }
    }

    public ICollection<TValue> Values
    {
        get
        {
            ICollection<TValue> values = new List<TValue>();
            InorderTreeWalk(this.root, x => values.Add(x.Value));
            return values;
        }
    }

    // Public Methods ----------------------------------------
    public void Add(TKey key, TValue value)
    {
        TreeNode newNode = new TreeNode(key, value, null, null, null);
        this.Insert(newNode);
    }

    public bool Remove(TKey key)
    {
        TreeNode node = Search(this.root, key);
        if (node == null)
        {
            return false;
        }
        Delete(node);
        return true;
    }

    public void Clear()
    {
        this.root = null;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        InorderTreeWalk(this.root, x => sb.AppendFormat("[K: {0}; V: {1}] ", x.Key, x.Value));
        return sb.ToString();
    }


    public override int GetHashCode()
    {
        int hash = 0;
        InorderTreeWalk(this.root, x => hash ^= x.GetHashCode());
        return hash;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        BinarySearchTree<TKey, TValue> tree = obj as BinarySearchTree<TKey, TValue>;
        if ((object)tree == null)
        {
            return false;
        }

        ICollection<TKey> thisKeys = this.Keys;
        ICollection<TKey> otherKeys = tree.Keys;

        if (thisKeys.Count != otherKeys.Count)
        {
            return false;
        }

        for (int i = 0; i < thisKeys.Count; i++)
        {
            if (thisKeys.ElementAt(i).CompareTo(otherKeys.ElementAt(i)) != 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool operator ==(BinarySearchTree<TKey, TValue> first, BinarySearchTree<TKey, TValue> second)
    {
        return first.Equals(second);
    }

    public static bool operator !=(BinarySearchTree<TKey, TValue> first, BinarySearchTree<TKey, TValue> second)
    {
        return !(first == second);
    }

    //IEnumerable Methods -----------------------------
    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        IList<KeyValuePair<TKey, TValue>> elems = new List<KeyValuePair<TKey, TValue>>();
        InorderTreeWalk(this.root, x => elems.Add(new KeyValuePair<TKey, TValue>(x.Key, x.Value)));

        foreach (var elem in elems)
        {
            yield return elem;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    // ICloneable Methods -----------------------------
    object ICloneable.Clone()
    {
        return this.Clone();
    }

    public BinarySearchTree<TKey, TValue> Clone()
    {
        BinarySearchTree<TKey, TValue> newTree = new BinarySearchTree<TKey, TValue>();
        PreorderTreeWalk(this.root, x => newTree.Add(x.Key, x.Value));
        return newTree;
    }

    // Private Methods --------------------------------
    private void InorderTreeWalk(TreeNode node, Action<TreeNode> action)
    {
        if (node != null)
        {
            InorderTreeWalk(node.LeftNode, action);
            action(node);
            InorderTreeWalk(node.RightNode, action);
        }
    }

    private void PreorderTreeWalk(TreeNode node, Action<TreeNode> action)
    {
        if (node != null)
        {
            action(node);
            PreorderTreeWalk(node.LeftNode, action);
            PreorderTreeWalk(node.RightNode, action);
        }
    }

    private TreeNode Search(TreeNode node, TKey key)
    {
        int cmp = key.CompareTo(node.Key);

        if (node == null || cmp == 0)
        {
            return node;
        }
        if (cmp < 0)
        {
            return Search(node.LeftNode, key);
        }
        else
        {
            return Search(node.RightNode, key);
        }
    }

    private void Insert(TreeNode newNode)
    {
        TreeNode parentNode = null;
        TreeNode currentNode = this.root;

        while (currentNode != null)
        {
            parentNode = currentNode;
            if (newNode.Key.CompareTo(currentNode.Key) < 0)
            {
                currentNode = currentNode.LeftNode;
            }
            else
            {
                currentNode = currentNode.RightNode;
            }
        }

        newNode.ParentNode = parentNode;

        if (parentNode == null)
        {
            this.root = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) < 0)
        {
            parentNode.LeftNode = newNode;
        }
        else if (newNode.Key.CompareTo(parentNode.Key) > 0)
        {
            parentNode.RightNode = newNode;
        }
        else
        {
            parentNode.Value = newNode.Value;
        }
    }

    private void Delete(TreeNode node)
    {
        if (node.LeftNode == null)
        {
            Transplant(node, node.RightNode);
        }
        else if (node.RightNode == null)
        {
            Transplant(node, node.LeftNode);
        }
        else
        {
            TreeNode y = Minimum(node.RightNode);
            if (!y.ParentNode.Equals(node))
            {
                Transplant(y, y.RightNode);
                y.RightNode = node.RightNode;
                y.RightNode.ParentNode = y;
            }
            Transplant(node, y);
            y.LeftNode = node.LeftNode;
            y.LeftNode.ParentNode = y;
        }
    }

    //move subtree v at the position of subtree u
    private void Transplant(TreeNode u, TreeNode v)
    {
        if (u.ParentNode == null)//the element we are transplanting to is the root of the tree
        {
            this.root = v;
        }
        else if (u.Equals(u.ParentNode.LeftNode))//the element we are transplanting to is the left child of it's parent
        {
            // u = v;
            u.ParentNode.LeftNode = v;
        }
        else //the element we are transplanting to is the right child of it's parent
        {
            u.ParentNode.RightNode = v;
        }
        if (v != null) //the element we are transplanting exists
        {
            v.ParentNode = u.ParentNode; //fixing the parent of the the transplanted element
        }
    }

    private TreeNode Minimum(TreeNode node)
    {
        while (node.LeftNode != null)
        {
            node = node.LeftNode;
        }
        return node;
    }

    //Inner class
    private class TreeNode
    {
        private TKey key;
        private TValue data;
        private TreeNode leftNode;
        private TreeNode rightNode;
        private TreeNode parentNode;

        internal TreeNode(TKey key, TValue data, TreeNode leftNode, TreeNode rightNode, TreeNode parentNode)
        {
            this.Key = key;
            this.Value = data;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
            this.ParentNode = parentNode;
        }

        public TreeNode ParentNode
        {
            get { return parentNode; }
            set { parentNode = value; }
        }
        
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        public TValue Value
        {
            get { return data; }
            set { data = value; }
        }

        public TKey Key
        {
            get { return key; }
            set { key = value; }
        }
     
        public override int GetHashCode()
        {
            return this.Key.GetHashCode() ^ this.Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            TreeNode node = obj as TreeNode;
            if ((object)node == null)
            {
                return false;
            }

            return this.Key.CompareTo(node.Key) == 0;
        }
    }
}