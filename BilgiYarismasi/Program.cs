

int sayac = 0; // Doğru cevapları saymak için değişken

// 1. Soru
Console.WriteLine("1 )Kaçkar Dağı, hangi coğrafi bölgenin en yüksek dağıdır?");
Console.WriteLine("a) Akdeniz b) Karadeniz");
Console.Write("Cevabınızı girin (A ya da B): ");
string cevap1 = Console.ReadLine().ToLower();

if (cevap1 == "b")
{
    Console.WriteLine("Tebrikler! ");
    Console.WriteLine(" Vermiş olduğunuz cevap doğru !");

    sayac++; 
}
else
{
    Console.WriteLine("Vermiş olduğunuz cevap yanlış!");
}

// 2. Soru
Console.WriteLine("2 )5 yıl önce aralarındaki yaş farkı 10 olan iki kişinin 20 yıl sonra aralarındaki yaş farkı kaç olur?");
Console.WriteLine("a) 10 b) 20");
Console.Write("Cevabınızı girin (A ya da B): ");
string cevap2 = Console.ReadLine().ToLower();

if (cevap2 == "a")
{
    Console.WriteLine("Tebrikler! ");
    Console.WriteLine(" Vermiş olduğunuz cevap doğru !");

    sayac++;
}
else
{
    Console.WriteLine("Vermiş olduğunuz cevap yanlış !");
}


if (sayac == 2) // 2 soruya da yanlış cevap verdiğinde 3. soruya gerek var mı kontrolü
{
    Console.WriteLine(" Tebrikler büyük ödülü kazandınız !");
}
else if (sayac == 1)

{

    // 3. Soru
    Console.WriteLine("3 )Hangi canlı, günde en az 250 kez gerçekleşen ve her biri yaklaşık 1 dakika süren uykuya dalar?");

    Console.WriteLine("a) Karınca b) Arı");
    Console.Write("Cevabınızı girin (A ya da B): ");
    string cevap3 = Console.ReadLine().ToLower();

    if (cevap3 == "a")
    {
        Console.WriteLine("Tebrikler! ");
        Console.WriteLine(" Vermiş olduğunuz cevap doğru !");

        sayac++;
    }
    else
    {
        Console.WriteLine(" Vermiş olduğunuz cevap yanlış !");

    }

    if (sayac >= 2)  //2 soruyada doğru cevap verdiğinde büyük ödül değerlendirmesi

    {
        Console.WriteLine("Tebrikler ederim !  1 Milyon TL'lik büyük ödülü kazandınız!");
    }
    else
    {
        Console.WriteLine(" Üzgünüm büyük ödülü kaybettiniz …..");
    }
}

else 
{
    Console.WriteLine("Büyük ödülü kazanamadınız..");
}