using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DataStructures
{
    public class Graph
    {
        public List<User> Nodes { get; set; }
        public List<Friendship> Edges { get; set; }
    }
}
