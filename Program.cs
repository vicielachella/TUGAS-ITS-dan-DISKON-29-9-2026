using System;

namespace TugasITS
{
    class Home
    {
        public static void Main(string[] args)
        {
            int kkmTKA = 280;
            int kkmUTBK = 600;
            bool totalNilai = true;

            while (totalNilai)
            {
                Console.WriteLine("Pilih Menu Yang ingin Anda Coba");
                Console.WriteLine("1. Masuk ITS Jalur Prestasi");
                Console.WriteLine("2. Masuk ITS Jalur UTBK");
                Console.WriteLine("--------------");
                int pilih = Convert.ToInt32(Console.ReadLine());

                if (pilih == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Masuk ITS Jalur Prestasi");
                    Console.WriteLine("---------------------");
                    Console.Write("Input Nilai Matematika: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Nilai Bhasa Inggris: ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Nilai Pilihan: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("==> Hasil Penjumlahan Nilai TKA = ");
                    int total = a + b + c;
                    Console.WriteLine(total);
                    Console.WriteLine("---------------------");
                    Console.WriteLine("==> Hasil TKA :");

                    if (total >= kkmTKA)
                    {
                        Console.WriteLine("SELAMATT KAMU DAPAT DAFTAR JALUR PRESTASI");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Kamu Tidak Dapat Daftar Jalur Prestasi");
                        Console.WriteLine("SEMANGAT TERUSS, BANTAI UTBK");
                        Console.WriteLine();
                    }
                }
                if (pilih == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Masuk ITS Jalur UTBK");
                    Console.WriteLine("---------------------");
                    Console.Write("Input Nilai Total TKA: ");
                    int TKA = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Nilai UTBK: ");
                    int UTBK = Convert.ToInt32(Console.ReadLine());

                    double nilaiAkhir = (TKA * 0.30) + UTBK;
                    Console.WriteLine("---------------------");
                    Console.WriteLine("==> Total Keseluruhan:" + nilaiAkhir);
                    Console.WriteLine("---------------------");

                    if (nilaiAkhir >= kkmUTBK)
                    {
                        Console.WriteLine("SELAMAT KAMU LOLOS");
                        Console.WriteLine();
                    }
                    else if (nilaiAkhir <= kkmUTBK)
                    {
                        Console.WriteLine("MOHON MAAF KAMU TIDAK LOLOS");
                        Console.WriteLine("SEMANGAT TERUS JANGAN PANTANG MENYERAH");
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}