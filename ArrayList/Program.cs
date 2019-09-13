using System;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList[5] = 19;

            int i = arrayList[0];

            arrayList.Append(3);
            arrayList.Append(5);
            arrayList.Append(7);
            arrayList.Append(9);

        }
    }
}
