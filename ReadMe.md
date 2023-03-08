Designing the data structures for a very large social network like Facebook or LinkedIn requires careful consideration of performance and scalability. 

1. 	Data Structures:
·   	User: This data structure represents a user in the social network, with properties such as a unique user ID, name, and list of friends.
·   	Friendship: This data structure represents a connection between two users in the social network, with properties such as the IDs of the two users and the date the friendship was established.
·   	Graph: The social network can be represented as a graph, with users as nodes and friendships as edges.
2. 	Algorithm: To find the shortest path between two users, I can use a variation of the Breadth-First Search (BFS) algorithm. 

·   	Start with the source user, add them to the queue, and mark them as visited.
·   	For each of the source user's friends:
·   	If the friend has not been visited, add them to the queue, mark them as visited, and set their parent to be the source user.
·   	If the friend is the target user, terminate the search and return the path from the source user to the target user.
·   	Continue the above step for each level of friends until the target user is found or the queue is empty.

Once the algorithm has found the target user, we can backtrack from the target user's parent to the source user to obtain the shortest path.

The hardest part of designing the algorithm to show the shortest path between two people is 
to be performance optimization. 
In a large social network with millions of users and billions of friendships,
the BFS algorithm can become very slow. 
To optimize performance, we can use techniques such as caching, 
pre-computation of common paths, and distributed processing. 
Additionally, we may need to carefully consider data storage and retrieval,
as well as network latency,
to ensure that the algorithm performs well even under heavy load.
