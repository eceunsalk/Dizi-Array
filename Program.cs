internal class Program
{
    private static void Main(string[] args)
    {
        //Sort Methodu
        int[] sayiDizisi = {23,12,4,86,72,3,11,17}; //8 elemanlı ve maks. 7 indeksi olan bir sayı dizisi tanımladım.
        Console.WriteLine("*** Sırasız Dizi *** ");
        foreach (var sayi in sayiDizisi)
        {
           Console.WriteLine(sayi); 
        }
        Console.WriteLine("*** Sıralı Dizi *** ");

        Array.Sort(sayiDizisi); //array sınıfının methodunu kullanıyoruz. array sınıfı bize statik olarak bu methodu açtığından array. yazdığımda buna erişebiliyorum.
        foreach (var sayi in sayiDizisi)
        {
           Console.WriteLine(sayi); 
        }

        //Clear Methodu -- Verdiğiniz dizi içerisinde verdiğiniz indeksten başlayarak verdiğiniz eleman sayısı kadar değeri sıfırlıyor. Direkt gidip dizinin o elemanına sıfır değerini atıyor.
        Console.WriteLine("*** Array Clear *** ");
        Array.Clear(sayiDizisi,2,2); //ilk array, hangi indeksten başlayacağı, kaç elemanı temizleyeceği.
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi); //öncesinde sıraladığı sayı dizisinde 2.indeksten başlayarak (3.eleman) 2 elemana 0 verdi.
        }

        //Reverse Methodu -- verdiğiniz diziyi ortadan aynalayarak yer değiştirir. ilk elemanı son eleman, son elemanı ilk eleman yapıyor. 
        Console.WriteLine("*** Array Reverse *** ");

        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf Methodu -- verdiğiniz dizi üzerinde verdiğiniz elemanın eğer içerisinde varsa indeksini döner.

        Console.WriteLine("*** Array IndexOf *** ");

        Console.WriteLine(Array.IndexOf(sayiDizisi,23)); // En son sayı dizisini tersine çevirmiştik, 23 burada 3.sırada indeks 0'dan başladığı için indeksi 2. Bu kod da bize sonuç olarak 2'yi verdi.

        //Resize Methodu -- Yeniden boyutlandırma yapar.

        Console.WriteLine("*** Array Resize *** ");
        Array.Resize<int>(ref sayiDizisi,9); //Diziyi yeniden boyutlandır, artık 9 elemanlı yap dedik. Bunu dedikten sonra 9 elemanı yani 8.indeksi belirttik ve ona bir sayı atadık. foreach ile yazdırdığımızda son elemana 99 atadığını görebiliyoruz. 
        sayiDizisi[8]=99; //Eğer 8.indeksi biz atamamış olsaydık, 9 eleman olarak 0 değerini verecekti. 
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }
        


    }
}