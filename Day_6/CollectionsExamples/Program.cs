using System.Collections;

namespace CollectionsExamples
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ArrayList o = new ArrayList();
            o.Add(10);
            o.Add("Rushi");
            o.Add(10.20222);
            o.Add(true);
            o.Add(1022.00);

            Console.WriteLine("COunt:-> "+o.Count);

            //o.Remove(10);
            //o.RemoveAt(1);
            //o.RemoveRange(2, 3);
            Console.WriteLine();
            
            //Console.WriteLine(o.Count);

            //Console.WriteLine(o.ToString());

            ArrayList o2= new ArrayList();

            o2.Add(100);
            o2.Add(50.5025);
            o2.Add(true);

            o.AddRange(o2);

            Console.WriteLine("Count of BothArray:-> "+o.Count);
            Console.WriteLine("ArrayList-1");
            foreach (object item in o)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            o.InsertRange(1, o2);
            foreach (object item in o)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            o.RemoveRange(1, 2);
            foreach (object item in o)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("ArrayList-2");
            foreach (object item in o2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Count of ArrayList-2:-> "+o2.Count);
        }

        static void Main2()
        {
            ArrayList arrayList = new ArrayList();

            Console.WriteLine($"count is { arrayList.Count }, capacity is { arrayList.Capacity }");

            arrayList.Add(10);
            Console.WriteLine($"count is {arrayList.Count}, capacity is {arrayList.Capacity}");
            arrayList.Add(20);
            arrayList.Add(30);
            arrayList.Add(40);
            arrayList.Add(50);
            arrayList.TrimToSize();
            Console.WriteLine($"count is {arrayList.Count}, capacity is {arrayList.Capacity}");

            
        }

        static void Main3()
        {
            //Hashtable ht = new Hashtable();
            SortedList st=new SortedList();


            st.Add(1, "Rushi");
            st.Add(2, "Tom");
            st.Add(3, "Jerry");
            st.Add(4, "Bob");

            st[5] = "Hardy";
            st[2] = "Shubh";

            st.Capacity = 6;
            st.Contains(3);

            foreach(DictionaryEntry item in st)
            {
                Console.WriteLine($"key is {item.Key}, value is {item.Value}");
            }

            IList keyList = st.GetKeyList(); 
            
        }

        static void Main()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Peek());
        }
    }
}