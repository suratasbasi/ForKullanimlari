
// For döngünüsünü kullanarak Console ekranına metin yazdırıyorum.
for (int i = 0; i < 10; i++)

    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");


Console.WriteLine("\n---------------------------------------------\n");


// For döngüsüyle 1 ile 20 arasındaki sayıları yazdırıyorum.
for (int i = 1; i <= 20; i++)

    Console.WriteLine(i);


Console.WriteLine("\n---------------------------------------------\n");


// For döngüsüyle 1 ile 20 arasındaki çift sayıları 0'ı dahil etmeden yazdırıyorum.
for (int i = 1; i <= 20; i++)

   if (i % 2 == 0)

        Console.WriteLine(i);


Console.WriteLine("\n---------------------------------------------\n");


// For döngüsüyle 50 ile 150 arasındaki sayıların toplamını yazdırıyorum.
int toplam = 0;

for (int i = 50; i <= 150; i++)

    toplam = toplam + i;

    Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);


Console.WriteLine("\n---------------------------------------------\n");


// For döngüsüyle 1 ile 120 arasındaki tek ve çift sayıların toplamını ayrı ayrı yazdırıyorum.
int ciftSayiToplam = 0;
int tekSayiToplam = 0;

for (int i = 1; i <= 120; i++)

    if (i % 2 == 0)

    { ciftSayiToplam = ciftSayiToplam + i; }



    else

    { tekSayiToplam = tekSayiToplam + i; }


Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftSayiToplam);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekSayiToplam);
