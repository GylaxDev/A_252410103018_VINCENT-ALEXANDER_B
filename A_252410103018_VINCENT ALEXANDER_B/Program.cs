using PBO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PBO;

public class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public Agen()
    {
        idAgen = "test";
        namaAgen = "yes";
        stokAgen = 12;

    }

    static void Main(string[] args) { }
        public void Tampilinfo()
        {
            Console.WriteLine("lol");
            Console.WriteLine(namaAgen);
            Console.WriteLine(stokAgen);
        }
    }

abstract class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;

    class KurangiStok
        {
        private int stokGudang;

        public int StokGudang { get => stokGudang; set => stokGudang = 0; }
        }
}

class GalonAkua : ProdukGalon
{
    public int harga = 20000;
    public string jenis = "resmi";
}

class GalonBerkeran : ProdukGalon
{
    public int harga = 12000;
    public string jenis = "keran";


public virtual void HitungBiaya(
    public override(
        GalonAkua = jumlah*20000;
        GalonBerkeran = jumlah*12000;
    )
        
}

{
      HitungBiaya (int jumlah)
}

public class DapatDidistribusikan
{
    public string Agen;
    public string ProdukGalon;
    public int JumlahGalon;
}

public class DistribusiGalon
{

}

public class SindikatGalon
{
    public Agen List<string>
    public ProdukGalon List<string>

    public void TambahAgen();
    public void TambahProduk();
    public void TampilkanSindikat();
}








