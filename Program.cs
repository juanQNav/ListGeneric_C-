using ListG;
using Iterator;
using LinkedListG;
using ArrayListG;

namespace Program
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            //ListG <String> list1 = new LinkedListG<String>();
            ListG <String> list1 = new ArrayListG<String>();
            String ? data;

            //*********addAtTail
            Console.WriteLine("*********addAtTail");
                list1.addAtTail("1");
                list1.addAtTail("2");
                list1.addAtTail("3");
                list1.addAtTail("4");
                list1.addAtTail("5");

            printList(list1);

            //********getAt
            Console.WriteLine("*********getAt ");
            data = list1.getAt(2);
            Console.WriteLine(data + " ");

            //*********remove
            Console.WriteLine("*********remove");
            list1.remove(1);

            printList(list1);
            
            //*********removeAll
            Console.WriteLine("*********removeALl");
                list1.removeAll();

            //*********addAtFront
            Console.WriteLine("*********addAtFront");
                list1.addAtFront("5");
                list1.addAtFront("4");
                list1.addAtFront("3");
                list1.addAtFront("3");
                list1.addAtFront("2");
                list1.addAtFront("1");

            printList(list1);

            //*********setAt
            Console.WriteLine("*********setAt");
            list1.setAt(1,"0");

            printList(list1);

            //*********removeAllWIthValue
            Console.WriteLine("*********removeAllWithValue");
            list1.removeAllWithValue("3");

            printList(list1);

            //*********getSize
            Console.WriteLine("The current size of the list is: "+list1.getSize());
        }
        public static void printList(ListG <String> list){
            Iterator <String> iterator = list.getIterator();
            while (iterator.hasNext()){
                Console.WriteLine(iterator.next());
            }
        }
    }
}
