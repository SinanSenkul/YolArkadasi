bool plan = true; //later in the do loop we will ask user if he wants to replan a new vacation and change the value of this variable
do
{
    Console.WriteLine("Merhaba! Aşağıda lokasyonlarımız sıralanmıştır:");
    Console.WriteLine("Bodrum (Paket başlangıç fiyatı 4000 TL)");
    Console.WriteLine("Marmaris (Paket başlangıç fiyatı 3000 TL)");
    Console.WriteLine("Çeşme (Paket başlangıç fiyatı 5000 TL)");
    Console.Write("Gitmek istediğiniz lokasyonu türkçe karakter kullanmadan giriniz:"); //gives me error in turkish letters
    string location = Console.ReadLine().ToLower();

    while (location != "bodrum" && location != "marmaris" && location != "cesme")
    {
        Console.Write("Maalesef o nokta için seçeneğimiz yok. Seçeneklerimiz Bodrum, Marmaris ve Çeşme'dir. Lütfen tekrar giriniz:");
        location = Console.ReadLine().ToLower();
    }
    int people = 0;
    Console.WriteLine("");

    while (true)
    {
        Console.Write("Tatile kaç kişi olarak gitmeyi planlıyorsun? ");
        if (int.TryParse(Console.ReadLine(), out people))
        {
            // if the parse was successful, we can break out of the loop
            break;
        }
        else
        {
            // if the parse was unsuccessful, display an error message and try again
            Console.WriteLine("Lütfen geçerli bir sayı giriniz");
        }
    }

    Console.WriteLine("Ulaşım için iki seçeneğimiz var,");
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
    Console.WriteLine("2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");
    Console.Write("Seçmek istediğiniz ulaşım seçeneğini 1 veya 2 olarak giriniz: ");
    string transportation = Console.ReadLine(); //we'll take it as a string value
    while (transportation != "1" && transportation != "2")
    {
        Console.Write("Lütfen 1 veya 2 şeklinde giriniz");
        transportation = Console.ReadLine().ToLower();
    }

    //calculating the sum of payments down below:
    int payment = people;
    if (location == "bodrum")
    {
        payment = payment * 4000;
    }
    else if (location == "marmaris")
    {
        payment = payment * 3000;
    }
    else
    {
        payment = payment * 5000;
    }

    if (transportation == "1")
    {
        payment = payment + people * 1500;
    }
    else
    {
        payment = payment + people * 4000;
    }

    Console.WriteLine($"Ödeyeceğiniz toplam tutar: {payment}");
    Console.Write("Yeniden bir planlama yapmak ister misiniz? (e/h) ");
    string res = Console.ReadLine().ToLower();
    //if user says "h", the do loop will be terminated. if "e", will repeat
    if (res == "e")
    {
        plan = true;
    }
    else
    {
        plan = false;
        Console.WriteLine("Hoşçakalın!");
    }
}
while (plan);