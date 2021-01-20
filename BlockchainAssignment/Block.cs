using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        public DateTime timestamp;
        public int index;
        public String hash;
        public String previousHash;
        
        public Block (Block lastBlock)
        {
            timestamp = DateTime.Now;
            index = lastBlock.index + 1;
            previousHash = lastBlock.hash;
        }
    }
}
