
### 1. **O(1) - Constant Time Complexity**

**O(1)**, işlemin çalışma süresinin giriş boyutuna bağlı olmadığı ve sabit olduğu anlamına gelir. Girdi ne kadar büyük olursa olsun, işlem süresi değişmez.

- **Örnek 1**: Bir dizideki bir elemana indeks ile erişmek **O(1)** karmaşıklığına sahiptir. `array[3]` veya `array[1000]`'e erişmek aynı süreyi alır çünkü indeks doğrudan elemana erişim sağlar.

  ```csharp
  int[] sayilar = {10, 20, 30, 40};
  int deger = sayilar[2]; // Üçüncü elemana erişim O(1)
  ```

- **Örnek 2**: Bir sayının çift veya tek olup olmadığını mod işlemi ile kontrol etmek de **O(1)**’dir. Sayının boyutu ne olursa olsun, yalnızca tek bir işlem yapılır.

  ```csharp
  bool ciftMi = sayi % 2 == 0;
  ```

### 2. **O(n) - Linear Time Complexity**

**O(n)**, çalışma süresinin giriş boyutuna bağlı olarak doğrusal bir şekilde arttığı anlamına gelir. Giriş iki katına çıkarsa, çalışma süresi de yaklaşık olarak iki katına çıkar.

- **Örnek 1**: Bir dizideki tüm elemanları döngü ile dolaşmak **O(n)**’dir, çünkü her bir elemana bir kez bakmak gerekir.

  ```csharp
  int toplam = 0;
  foreach (int num in sayilar)
  {
      toplam += num; // 'sayilar' içindeki her bir elemanı ziyaret ediyoruz
  }
  ```

- **Örnek 2**: Sırasız bir listede belirli bir değeri aramak **O(n)**’dir, çünkü hedef değeri bulmak için her bir öğeyi kontrol etmek gerekebilir.

  ```csharp
  bool iceriyorMu = sayilar.Contains(20); // Doğrusal arama, en kötü durumda O(n)
  ```

### 3. **O(log n) - Logarithmic Time Complexity**

**O(log n)**, giriş boyutu arttıkça çalışma süresinin logaritmik olarak arttığı anlamına gelir. Logaritmik karmaşıklık genellikle girişin her seferinde yarıya indirildiği algoritmalarda görülür.

- **Örnek 1**: Sıralı bir dizide ikili arama (Binary Search) **O(log n)** karmaşıklığa sahiptir. Her adımda arama alanı yarıya indirilir.

  ```csharp
  int IkiliArama(int[] siraliDizi, int hedef)
  {
      int sol = 0;
      int sag = siraliDizi.Length - 1;
      while (sol <= sag)
      {
          int orta = sol + (sag - sol) / 2;
          if (siraliDizi[orta] == hedef) return orta;
          if (siraliDizi[orta] < hedef) sol = orta + 1;
          else sag = orta - 1;
      }
      return -1; // Hedef bulunamadı
  }
  ```

- **Örnek 2**: Dengeli ikili arama ağaçları gibi veri yapılarında (örneğin, C#'ta `SortedDictionary`), çoğu işlem **O(log n)** karmaşıklığına sahiptir çünkü ağaç dengeli tutulur ve her işlemde giriş boyutu yarıya indirilir.
