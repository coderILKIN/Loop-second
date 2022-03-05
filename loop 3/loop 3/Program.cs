using System;

namespace loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Ilkin", "Ferid", "Dunyamali", "Sahile" };

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Length>5)
                {
                    Console.WriteLine(name[i]);

                }

            }
        }
    }
}
