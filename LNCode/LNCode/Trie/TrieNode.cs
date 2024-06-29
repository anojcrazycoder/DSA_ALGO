using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNCode.Trie
{
    internal class TrieNode
    {
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsEndOfWord { get; set; }

        public TrieNode() { 
        
            Children = new Dictionary<char, TrieNode>();
            IsEndOfWord = false;
        }
    }

    public class Trie
    {
        private TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }
        public void Insert(string word)
        {

        }
    }


}
