using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();
        bool exit = false;


        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1. Tambah Costemer");
            Console.WriteLine("2. hapus");
            Console.WriteLine("3. Tampil");
            Console.WriteLine("4. keluar");


        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Customer costem = new Customer();

            Console.Write(" kode: ");
            costem.Kode = Console.ReadLine();
            Console.Write("NAMA : ");
            costem.Nama = Console.ReadLine();
            Console.Write(" UTANG : ");
            costem.Utang = Console.ReadLine();

            daftarCustomer.Add(costem);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.Write(" Masukan Kode : ");
            string search = Console.ReadLine();

            int index = 0;

            foreach(Customer costem in daftarCustomer)
            {
                if(costem.Kode == search)
                {
                    break;
                }
                index++;
            }
            daftarCustomer.RemoveAt(index);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("NO\t\tKODE\t\tNAMA\t\tUTANG");
            int index =0;


            foreach (Customer costem in daftarCustomer)
            
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", index+1, costem.Kode, costem.Nama, costem.Utang);
                index++;


            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
