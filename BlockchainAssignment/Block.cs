using System;
using System.Security.Cryptography;

namespace BlockchainAssignment
{
    class Block
    {
        public DateTime timestamp;
        public int index;
        public String hash;
        public String previousHash;

        /* Genisus Block creater */

        public Block ()
        {
            timestamp = DateTime.Now;
            index = 0;
            previousHash = String.Empty;
            hash = createHash();
        }

        
        public Block (string previousHash, int index)
        {
            this.previousHash = previousHash;
            this.index = index + 1;
            hash = createHash();
        }

        public Block(Block lastBlock)
        {
            timestamp = DateTime.Now;
            previousHash = lastBlock.hash;
            index = lastBlock.index + 1;
            hash = createHash();
        }
        public String createHash()
        {
            SHA256 hasher = SHA256Managed.Create();
            return String.Empty; //TODO
        }

    }
}
