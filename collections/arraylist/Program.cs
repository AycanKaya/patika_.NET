namespace arraylist
{
    class Program
    {
        public static void Main(string[] args)
        {
            // add
            ArrayList list = new ArrayList();
            list.Add("Ayse");
            list.Add(1);
            list.Add(true);
            list.Add('a');

            Console.WriteLine(list[1]);

            foreach (var i in list) Console.WriteLine(i);

            string[] colors = { "red", "black" };
            list.AddRange(colors);

            ArrayList list2 = new ArrayList();
            list2.Add(13);
            list2.Add(154);
            list2.Add(1);
            list2.Add(12);

            //Sort
            list2.Sort();
            foreach (var i in list2) Console.WriteLine(i);

            Console.WriteLine(list2.BinarySearch(13));

            list2.Reverse();

            list2.Clear();

        }
    }
}