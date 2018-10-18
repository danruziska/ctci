using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrefixTree
{
    public class TrieNode
    {
        private Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public int size = 0; // this was the main trick to decrease runtime to pass tests.

        public void putChildIfAbsent(char ch)
        {
            if(!children.ContainsKey(ch))
                children.Add(ch, new TrieNode());
        }

        public TrieNode getChild(char ch)
        {
            if(children.ContainsKey(ch))
                return children[ch];

            return null;
        }
    }

    public class Trie
    {
        TrieNode root = new TrieNode();

        public Trie() { } // default constructor

        Trie(String[] words)
        {
            foreach (String word in words)
            {
                add(word);
            }
        }

        public void add(String str)
        {
            TrieNode curr = root;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                curr.putChildIfAbsent(ch);
                curr = curr.getChild(ch);
                curr.size++;
            }
        }

        public int find(String prefix)
        {
            TrieNode curr = root;

            /* Traverse down tree to end of our prefix */
            for (int i = 0; i < prefix.Length; i++)
            {
                char ch = prefix[i];
                curr = curr.getChild(ch);
                if (curr == null)
                {
                    return 0;
                }
            }
            return curr.size;
        }
    }
}
