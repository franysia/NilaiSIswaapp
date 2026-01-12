int nilai;
 string nama;
Console.WriteLine("AplikasiNilaiSiswa");

Console.WriteLine("Input Nilai ");
nama = Console.ReadLine();

Console.WriteLine("Nama Siswa");
nilai =  int.Parse(Console.ReadLine());

if (nilai >= 75)
    Console.WriteLine("Selamat Anda Lulus");

else
    Console.WriteLine("Maaf anda tidak lulus");
    