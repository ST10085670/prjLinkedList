namespace prjLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(6);
            Node na = new Node(7);
            Node nb = new Node(8);
            n.next = na;
            na.next = nb;
            Console.WriteLine(countNode(n));
        }

        public static int countNode(Node Head) 
        {
            int count = 1;
            Node current = Head;
            while (current.next != null) 
            {
                count++;
                current = current.next;
            }

            return count;
        }
        public static Node FindNode(int value, Node Head) 
        {

        }

    }
}
