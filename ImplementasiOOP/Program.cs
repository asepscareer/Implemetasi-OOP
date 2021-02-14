using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementasiOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            string ulangi = "";
            do
            {
            input:
                Console.WriteLine("Pilih Menu");
                Console.WriteLine("1. Persegi");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Lingkaran");
                Console.WriteLine("Masukkan pilihan anda >> ");

                try
                {
                    pilihan = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    Console.WriteLine("Silahkan masukkan pilihan anda dengan benar\n");
                    goto input;
                    throw;
                }

                Console.Clear();
                switch (pilihan)
                {
                    // Persegi
                    case 1:
                        Persegi p = new Persegi();
                    persegi:
                        try
                        {
                            Console.WriteLine("Input sisi :");
                            p.sisi = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("Input anda salah, mohon gunakan angka!!\n");
                            goto persegi;
                            throw;
                        }

                        Console.WriteLine("Panjang Sisi : {0}", p.sisi);
                        Console.WriteLine("Keliling Persegi : {0}", p.HitungKeliling());
                        Console.WriteLine("Luas Persegi : {0}\n\n", p.HitungLuas());
                        Console.WriteLine("Berhenti? ");
                        Console.WriteLine("Ya/Tidak ");
                        ulangi = Console.ReadLine().ToLower().Trim();
                        Console.Clear();

                        break;

                    // Persegi Panjang
                    case 2:
                        PersegiPanjang pp = new PersegiPanjang();

                    persegipanjang:
                        try
                        {
                            Console.WriteLine("Input Panjang :");
                            pp.panjang = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Input Lebar :");
                            pp.lebar = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("Input anda salah, mohon gunakan angka!!\n");
                            goto persegipanjang;
                            throw;
                        }
                        Console.Clear();
                        Console.WriteLine("Panjang : {0}", pp.panjang);
                        Console.WriteLine("Panjang Lebar : {0}", pp.lebar);
                        Console.WriteLine("Keliling dari Persegi Panjang : {0}", pp.HitungKeliling());
                        Console.WriteLine("Luas dari Persegi Panjang : {0}\n\n", pp.HitungLuas());
                        Console.WriteLine("Berhenti? ");
                        Console.WriteLine("Ya/Tidak ");
                        ulangi = Console.ReadLine().ToLower().Trim();
                        Console.Clear();
                        break;

                    // Lingkaran
                    case 3:
                        Lingkaran l = new Lingkaran();
                    lingkaran:
                        try
                        {
                            Console.WriteLine("Input panjang jari-jari  :");
                            l.jarijari = Convert.ToDouble(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception error)
                        {
                            Console.WriteLine(error);
                            Console.WriteLine("Input anda salah, mohon gunakan angka!!\n");
                            goto lingkaran;
                            throw;
                        }

                        Console.WriteLine("Panjang jari-jari : {0}", l.jarijari);
                        Console.WriteLine("Keliling Lingkaran : {0}", l.HitungKeliling());
                        Console.WriteLine("Luas Lingkaran : {0}\n\n", l.HitungLuas());
                        Console.WriteLine("Berhenti? ");
                        Console.WriteLine("Ya/Tidak ");
                        ulangi = Console.ReadLine().ToLower().Trim();
                        Console.Clear();
                        break;
                }
            } while (ulangi == "tidak" || ulangi == "Tidak" || ulangi == "TIDAK");
            Console.WriteLine("Terimakasih, sampai berjumpa lagi!");
        }
    }
}