using System;
using modul8_103022300053;
class Program
{
    static void Main()
    {
        BankTransferConfig config = new BankTransferConfig();
        if (config.lang == "en")
        {
            Console.WriteLine($"Please insert the amount of money to transfer: ");
        }else if(config.lang == "id"){
            Console.WriteLine($"Masukkan jumlah uang yang akan di-transfer: ");
        }
       int nominal =int.Parse(Console.ReadLine());
        if (nominal<=config.transfer.threshold)
        {
            int biayaTransfer = config.transfer.low_fee;
        }
        else if(nominal<=config.transfer.threshold)
        {

        }
       

    }
}