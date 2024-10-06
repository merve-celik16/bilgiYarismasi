# 2.yöntem
`int sayac = 0; // Doğru cevap sayısı için tanımladığım değişken

// 1. Soru
Console.WriteLine("1 )Kaçkar Dağı, hangi coğrafi bölgenin en yüksek dağıdır?");
Console.WriteLine("a) Akdeniz b) Karadeniz");
Console.Write("Cevabınızı girin (A ya da B): ");
string cevap1 = Console.ReadLine().ToLower();
switch (cevap1)
{
    case "b":
        Console.WriteLine("Vermiş olduğunuz cevap doğru ");
        sayac++;
        break;

    default:
        Console.WriteLine(" Vermiş olduğunuz cevap yanlış");
        break;

}

// 2. Soru
Console.WriteLine("2 )5 yıl önce aralarındaki yaş farkı 10 olan iki kişinin 20 yıl sonra aralarındaki yaş farkı kaç olur?");
Console.WriteLine("a) 10 b) 20");
Console.Write("Cevabınızı girin (A ya da B): ");
string cevap2 = Console.ReadLine().ToLower();
switch (cevap2)
{
    case "a":
        Console.WriteLine(" Vermiş olduğunuz cevap doğru ");
        sayac++;
        break;

    default:
        Console.WriteLine(" Vermiş olduğunuz cevap yanlış");
        break;


}
switch (sayac )
{
    case 2:
        Console.WriteLine(" Tebrikler büyük ödülü kazandnız...");
        break;

    case 1:
        
        //3.soru
        Console.WriteLine("3 )Hangi canlı, günde en az 250 kez gerçekleşen ve her biri yaklaşık 1 dakika süren uykuya dalar?");
        Console.WriteLine("a) Karınca b) Arı");
        Console.Write("Cevabınızı girin (A ya da B): ");
        string cevap3 = Console.ReadLine().ToLower();
        switch (cevap3)
        {
            case "a":
                Console.WriteLine("cevap doğru ");

                break;
                sayac++;
            default:
                Console.WriteLine("yanlış");
                break;
        }


        switch (sayac )
        {
            case 2:
                Console.WriteLine("Tebrikler 1 Milyon TL değerindeki büyük ödülü kazandınız ..");
                break;
            default:
                Console.WriteLine("Üzgünüm büyük ödülü kazanamadınız...");
                break;



        }

        break;
    default:
        Console.WriteLine("Üzgünüm büyük ödülü kazanamadınız...");
        break;
}`
