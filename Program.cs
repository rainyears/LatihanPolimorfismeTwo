BankTransfer bankTransfer = new BankTransfer();
EWallet eWallet = new EWallet();
KartuKredit kartuKredit = new KartuKredit();

Console.WriteLine("Simulasi Checkout");
Console.WriteLine("Pilih Metode: ");
Console.WriteLine("1. Bank Transfer \n2. E-Wallet \n3. Kartu Kredit");
Console.WriteLine("Pilihan Anda (1/2/3): ");
string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        bankTransfer.Bayar(100000);
        break;
    case "2":
        eWallet.Bayar(100000);
        break;
    case "3":
        kartuKredit.Bayar(100000);
        break;
    default:
        Console.WriteLine("Pembayaran Invalid");
        break;
}
class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Segera melakukan pembayaran");
    }
}
class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah {jumlah} ke nomer rekening 12345678");
    }
}
class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah {jumlah} ke nomer rekening 12345678");
    }
}
class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah {jumlah} ke nomer rekening 12345678");
    }
}