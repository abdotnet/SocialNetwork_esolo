using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DataStructures
{
    public class Friendship
    {
        public long UserAId { get; set; }
        public long UserBId { get; set; }
        public DateTime  ConnectionDate { get; set; }
    }
}
