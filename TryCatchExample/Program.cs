bool devam = false;
while (!devam)
{

    try {
        Console.Write("Bir sayı giriniz: ");
        string str = Console.ReadLine();
        int sayi = Convert.ToInt32(str);

        devam = true;
        Console.WriteLine("Girdiğiniz sayının karesi : "+ Math.Pow(sayi,2));

    }
    catch(Exception ex) {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
    }


}
