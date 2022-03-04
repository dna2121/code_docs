using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilai_akhir
{
    /// <summary>
    /// main class
    /// </summary>
    /// 
    /// <remarks>class input merupakan class yang digunakan
    /// untuk mengisi data, menjalankan proses dan menghasilkan output</remarks>
    class input
    {
        /// <summary>
        /// deklarasi variable mtk, bi, fis, bio, ki
        /// </summary>
        /// <remarks>mendeklarasikan variable untuk menyimpan nilai mata pelajaran matematika, bahasa indonesia, 
        /// fisika, biologi, dan kimia</remarks>
        public double mtk, bi, fis, bio, ki;

        /// <summary>
        /// deklarasi variable nama
        /// </summary>
        /// <remarks>mendeklarasikan variable untuk menyimpan nilai nama</remarks>
        public string nama;
        
        /// <summary>
        /// untuk memasukkan nama dan nilai mata pelajaran
        /// </summary>
        public void inputdata()
        {
            Console.Write("Nama Siswa = ");
            nama = Console.ReadLine();
            Console.Write("Nilai Matematika = ");
            mtk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Bahasa INdonesia = ");
            bi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Fisika = ");
            fis = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Biologi = ");
            bio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nilai Kimia = ");
            ki = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// operasi rata-rata hasil nilai akhir siswa
        /// </summary>
        /// <param name="m">nilai mata pelajaran matematika yang akan dihitung dengan nilai mata pelajaran lainnya untuk hasil nilai akhir</param>
        /// <param name="ind">nilai mata pelajaran bahasa indonesia yang akan dihitung dengan nilai mata pelajaran lainnya untuk hasil nilai akhir</param>
        /// <param name="fi">nilai mata pelajaran fisika yang akan dihitung dengan nilai mata pelajaran lainnya untuk hasil nilai akhir</param>
        /// <param name="bioo">nilai mata pelajaran biologi yang akan dihitung dengan nilai mata pelajaran lainnya untuk hasil nilai akhir</param>
        /// <param name="kim">nilai mata pelajaran kimia yang akan dihitung dengan nilai mata pelajaran lainnya untuk hasil nilai akhir</param>
        /// <returns>hasil dari jumlah nilai semua mata pelajaran kemudian dibagi 5</returns>
        public double nilaiakhir(double m, double ind, double fi, double bioo, double kim)
        {
            return (m + ind + fi + bioo + kim) / 5;
        }

        /// <summary>
        /// method untuk mengondisikan keterangan predikat
        /// </summary>
        /// <returns>predikat berupa abjad dari hasil pengondisian</returns>
        public string Keterangan()
        {
            // deklarasi variable untuk menyimpan value keterangan berupa abjad
            string predikat;
            if (nilaiakhir(mtk,bi,fis,ki,bio) >= 90)
            {
                predikat = "A";
            }
            else if (nilaiakhir(mtk,bi,fis,ki,bio) >= 85 && nilaiakhir(mtk, bi, fis, ki, bio) < 90)
            {
                predikat = "AB";
            }
            else if (nilaiakhir(mtk, bi, fis, ki, bio) >= 80 && nilaiakhir(mtk, bi, fis, ki, bio) < 85)
            {
                predikat = "B";
            }
            else if (nilaiakhir(mtk, bi, fis, ki, bio) >= 75 && nilaiakhir(mtk, bi, fis, ki, bio) < 80)
            {
                predikat = "BC";
            }
            else if (nilaiakhir(mtk, bi, fis, ki, bio) >= 70 && nilaiakhir(mtk, bi, fis, ki, bio) < 75)
            {
                predikat = "C";
            }
            else if (nilaiakhir(mtk, bi, fis, ki, bio) >= 65 && nilaiakhir(mtk, bi, fis, ki, bio) < 70)
            {
                predikat = "D";
            }
            else if (nilaiakhir(mtk, bi, fis, ki, bio) >= 60 && nilaiakhir(mtk, bi, fis, ki, bio) < 65)
            {
                predikat = "E";
            }
            else
            {
                predikat = "F";
            }
            return predikat;
        }

        /// <summary>
        /// method untuk mengondisikan keterangan kelulusan siswa
        /// </summary>
        /// <returns>hasil berupa lulus atau tidak lulus</returns>
        public string Keterangan2()
        {
            string hasil;
            if (mtk >= 70 && bi >= 80 && fis >= 65 && bio >= 70 && ki >= 65 && nilaiakhir(mtk,bi,fis,ki,bio) >= 70)
            {
                hasil = "Lulus";
            }
            else
            {
                hasil = "Belum Lulus";
            }
            return hasil;
        }      

        /// <summary>
        /// method yang menghasilkan output kelulusan
        /// </summary>
        /// <remarks>pada method ini output yang ditampilkan berupa nilai akhir, predikat, dan hasil kelulusan.</remarks>
        public void output()
        {
            Console.WriteLine("Nilai Akhir = {0} \nPredikat = {1} \nHasil Kelulusan = {2}", nilaiakhir(mtk,bi,fis,ki,bio), Keterangan(), this.Keterangan2());
        }
    }

    /// <summary>
    /// class program
    /// </summary>
    /// <remarks>class yang digunakan untuk memanggil method dari class lain dan menjalankan program</remarks>
    class Program
    {
        //method yang digunakan untuk mengeksekusi kode program
        static void Main(string[] args)
        {
            //mendefinisikan class input
            input i = new input();

            //memanggil method inputdata dari class i (input)
            i.inputdata();
            //memanggil method output dari class i (input)
            i.output();
            Console.ReadLine();
        }
    }
}


/*BEGIN
numeric nMTK, nBIO, nRata, nBI, nFIS, nKI nCounter
for (nCounter = 0; nCounter++)
Begin
display " Nilai Matematika = "
accept nMTK
display " Nilai bio = "
accept nBIO
display "nilai bhs indo = "
accept nBI
display "nilai fisika = "
accept nFIS
display "nilai kimia = "
accept nKI
nRata = (nMTK + nBIO + nBI + nFIS + nKI)/5
if ((nRata>=70)AND(nMTK>=70)AND(nBIO>=70)AND(nBI>=80)AND(nFIS>=65)AND(nKI>65))
Begin
status = "Lulus "
End
else
Begin
status = " Tidak Lulus "
End
if(nRata>=90)
Begin
pre = "A"
End
else if ((nRata>=85ND(nRata<90))
Begin
pre = "AB"
End
else if ((nRata>=80)AND(nRata<85))
Begin
pre = "B"
End
else if ((nRata>=75)AND(nRata<80))
Begin
pre = "BC"
End
else if ((nRata>=70)AND(nRata<75))
Begin
pre = "C"
End
else if ((nRata>=65)AND(nRata<70))
Begin
pre = "D"
End
else if ((nRata>=60)AND(nRata<65))
Begin
pre = "E"
End
else
Begin
display "F"
End 
display "rata-rata = ", nRata
display "predikat = ", pre
display "hasil kelulusan = ", status
END*/
