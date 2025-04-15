using modul8_103022300029;

class Program
{
    static void Main()
    {
        BankTransferConfig config = new BankTransferConfig();
        BankTransferConfig data = config.LoadConfig();
        int totalAmount;

        if (data.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
            int uang = Convert.ToInt32(Console.ReadLine());


            if (uang <= data.transfer.threshold)
            {

                totalAmount = uang + data.transfer.low_fee;

            }
            else
            {

                totalAmount = uang + data.transfer.high_fee;
            }
            Console.WriteLine("\nSelect transfer method: ");
            for (int i = 0; i < data.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + data.methods[i]);
            }
            int metode = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nPlease type " + data.confirmation.en + " to confirm the transaction");

            string konfirmasi = Convert.ToString(Console.ReadLine());
            if (konfirmasi != data.confirmation.en)
            {
                Console.WriteLine("Transfer is cancelled");
            }
            else
            {
                Console.WriteLine("The transfer is completed");
            }

        }
        else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
            int uang = Convert.ToInt32(Console.ReadLine());


            if (uang <= data.transfer.threshold)
            {

                totalAmount = uang + data.transfer.low_fee;

            }
            else
            {

                totalAmount = uang + data.transfer.high_fee;
            }
            Console.WriteLine("\nPilih metode transfer: ");
            for (int i = 0; i < data.methods.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + data.methods[i]);
            }
            int metode = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nKetik " + data.confirmation.id + "  untuk mengkonfirmasi transaksi:");

            string konfirmasi = Convert.ToString(Console.ReadLine());
            if (konfirmasi != data.confirmation.en)
            {
                Console.WriteLine("Proses transfer berhasil");
            }
            else
            {
                Console.WriteLine("Transfer dibatalkan");
            }

        }
    }

    
}