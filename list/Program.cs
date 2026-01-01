using System;

namespace jobsheet
{
    class Menu
    {
        public static List<string> kumpulandata = new List<string>();
        public static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                string pilihanmenu;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("===== IDENTITAS =====");
                Console.WriteLine("Nama  : Damar Areefa Naraya");
                Console.WriteLine("Kelas : X-RPL 1");
                Console.WriteLine("tugas LIst");
                Console.WriteLine("=====================");
                Console.WriteLine("");
                Console.WriteLine("===== Menu List =====");
                Console.WriteLine("1. tambah dan tampilkan data");
                Console.WriteLine("2. ganti dan tampilkan data");
                Console.WriteLine("3. hapus dan tampilkan data");
                Console.WriteLine("=======================");
                Console.Write("pilihan mu  : ");
                pilihanmenu = Console.ReadLine();
                switch (pilihanmenu)
                {
                    case "1":
                        Data.input1();
                        break;
                    case "2":
                        Update.update1();
                        break;
                    case "3":
                        Delete.delete1();
                        break;
                    default:
                        Console.WriteLine("tidak ada pilihan");
                        break;
                }
            }
        }
    }

    class Data
    {
        public static void input1()
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("===== MENU INPUT DATA =====");
            Console.Write("masukkan jumlah data yang di inginkan: ");
            int inputuser = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputuser; i++)
            {
                Console.Write($"masukkan data ke :  {i + 1} : ");
                string alldata = Console.ReadLine();
                Menu.kumpulandata.Add(alldata);
            }
            Console.WriteLine("");
            for (int j = 0; j < Menu.kumpulandata.Count; j++)
            {
                Console.WriteLine($"hasil input data ke : {j + 1} = {Menu.kumpulandata[j]}");
            }
            Console.WriteLine("");
            string pilihan;
            Console.WriteLine("--- opsi input kembali data ---");
            Console.WriteLine("apakah ingin melanjutkan input data? ");
            Console.Write("YA/TIDAK : ");
            pilihan = Console.ReadLine();
            if (pilihan == "ya")
            {
                Console.WriteLine("");
                Console.WriteLine("--- opsi input data ---");
                Console.WriteLine("1. tambahkan data di sisip list yang sudah ada");
                Console.WriteLine("2. tambahkan data di awal list yang sudah ada");
                Console.WriteLine("3. tambahkan data di akhir list yang sudah ada");
                Console.Write("pilihan menu [1-3] : ");
                string pilahan_menutambahan;
                pilahan_menutambahan = Console.ReadLine();
                switch (pilahan_menutambahan)
                {
                    case "1":
                        Console.Write("masukkan data baru : ");
                        string data1 = Console.ReadLine();
                        int posisitengah = Menu.kumpulandata.Count / 2;
                        Menu.kumpulandata.Insert(posisitengah, data1);
                        Console.WriteLine($"Data : {data1} ditambahkan di Tengah (posisi data : {posisitengah})");
                        break;
                    case "2":
                        Console.Write("masukkan data baru : ");
                        string data2 = Console.ReadLine();
                        Menu.kumpulandata.Insert(0, data2);
                        Console.WriteLine($"'Data : {data2} ditambahkan di awal");
                        break;
                    case "3":
                        Console.Write("masukkan data baru : ");
                        string data3 = Console.ReadLine();
                        Menu.kumpulandata.Add(data3);
                        Console.WriteLine($"Data : {data3} ditambahkan di akhir");
                        break;
                }
                Console.WriteLine("=== HASIL INPUT TAMBAHAN ===");
                for (int j = 0; j < Menu.kumpulandata.Count; j++)
                {
                    Console.WriteLine($"hasil input data ke : {j + 1} = {Menu.kumpulandata[j]}");
                }
            }

            else if (pilihan == "tidak")
            {
                return;
            }
            Console.WriteLine("Tekan ENTER untuk kembali ke menu utama...");
            Console.ReadLine();
        }
    }
    class Update
    {
        public static void update1()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            if (Menu.kumpulandata.Count == 0)
            {
                Console.WriteLine("TIDAK ADA DATA, SILAHKAN MASUKKAN DATA TERLEBIH DAHULU DI MENU TAMBAH DATA!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("===== MENU GANTI DATA =====");
            Console.WriteLine("Data yang sudah ada :");
            for (int j = 0; j < Menu.kumpulandata.Count; j++)
            {
                Console.WriteLine($"[{j + 1}] {Menu.kumpulandata[j]}");
            }

            Console.Write("pilih data yang akan di ganti : ");
            string jwb = Console.ReadLine();
            int idx = Menu.kumpulandata.IndexOf(jwb);

            if (idx != -1)
            {
                Console.WriteLine($"Data : {jwb} ditemukan di posisi {idx + 1}");
                Console.Write("Ganti dengan data baru: ");
                string jwb2 = Console.ReadLine();
                Menu.kumpulandata[idx] = jwb2;
                Console.WriteLine($"\nData berhasil diganti: {jwb} menjadi {jwb2}");

                // --- Sorting Logic ---
                Console.Write("\napakah anda ingin sorting data? (YA/TIDAK): ");
                string pilihan = Console.ReadLine().ToLower();

                if (pilihan == "ya")
                {
                    Console.WriteLine("\n--- opsi sorting data ---");
                    Console.WriteLine("1. sorting secara ASCENDING ");
                    Console.WriteLine("2. sorting secara DESCENDING ");
                    Console.Write("pilihan menu [1/2] : ");
                    string sortingdata = Console.ReadLine();

                    switch (sortingdata)
                    {
                        case "1":
                            Console.WriteLine("diurutkan secara ASCENDING");
                            Menu.kumpulandata.Sort();
                            break;
                        case "2":
                            Console.WriteLine("diurutkan secara DESCENDING");
                            Menu.kumpulandata.Sort();
                            Menu.kumpulandata.Reverse();
                            break;
                    }
                }
                else if (pilihan == "tidak")
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine($"Data : {jwb} tidak ditemukan");
            }

            Console.WriteLine("=== HASIL GANTI DATA ===");
            for (int j = 0; j < Menu.kumpulandata.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {Menu.kumpulandata[j]}");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu utama...");
            Console.ReadLine();
        }
    }
    class Delete
    {
        public static void delete1()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("===== MENU GANTI DATA =====");
            if (Menu.kumpulandata.Count == 0)
            {
                Console.WriteLine("TIDAK ADA DATA, SILAHKAN MASUKKAN DATA TERLEBIH DAHULU DI MENU TAMBAH DATA!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("data yang sudah ada :");
            for (int j = 0; j < Menu.kumpulandata.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {Menu.kumpulandata[j]}");
            }

            Console.Write("pilih data List yang akan dihapus : ");
            string jwb = Console.ReadLine();

            bool berhasilHapus = Menu.kumpulandata.Remove(jwb);

            if (berhasilHapus)
            {
                Console.WriteLine($"Data :{jwb} berhasil dihapus.");
            }
            else
            {
                Console.WriteLine($"Data :{jwb} tidak ditemukan.");
            }

            Console.WriteLine("=== HASIL HAPUS DATA ===");
            for (int j = 0; j < Menu.kumpulandata.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {Menu.kumpulandata[j]}");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu utama...");
            Console.ReadLine();
        }
    }
}