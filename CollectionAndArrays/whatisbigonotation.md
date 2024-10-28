
## Big O Notation'da "Complexity" Nedir?

**Big O Notation**'da "complexity" (karmaşıklık), bir algoritmanın verimliliğini tanımlayan bir kavramdır. Algoritmanın çalışma süresinin veya hafıza kullanımının, giriş boyutuna göre nasıl değiştiğini ifade eder. Genellikle **zaman karmaşıklığı** (time complexity) ve **hafıza karmaşıklığı** (space complexity) olarak iki ana kategoriye ayrılır.

### 1. Zaman Karmaşıklığı (Time Complexity)
Zaman karmaşıklığı, algoritmanın çalışması için gereken süreyi ölçer. Giriş boyutu büyüdükçe algoritmanın çalışma süresinin nasıl değiştiğini gösterir. **Big O Notation**, en yaygın kullanılan ölçü birimidir ve algoritmanın en kötü durumda (**worst case**) nasıl davrandığını ifade eder.

#### Zaman Karmaşıklığı Örnekleri:
- **O(1)**: Sabit zaman, giriş boyutundan bağımsızdır. Örnek: Bir dizi elemanına doğrudan erişim.
- **O(n)**: Doğrusal zaman, giriş boyutuna doğru orantılı artar. Örnek: Bir dizideki tüm elemanları döngü ile dolaşmak.
- **O(n^2)**: Kuadratik zaman, giriş boyutunun karesi kadar artar. Örnek: İç içe döngüler kullanılarak elemanları karşılaştırmak.

### 2. Hafıza Karmaşıklığı (Space Complexity)
Hafıza karmaşıklığı, algoritmanın çalışması için ihtiyaç duyduğu ek hafızayı ölçer. Giriş boyutuna göre bellek kullanımının nasıl değiştiğini ifade eder. Algoritma büyük veri kümeleri ile çalışırken, hafıza kullanımının sınırlandırılması önemlidir.

#### Hafıza Karmaşıklığı Örnekleri:
- **O(1)**: Sabit hafıza, giriş boyutundan bağımsızdır.
- **O(n)**: Doğrusal hafıza, giriş boyutuna orantılı artar. Örnek: Bir diziye tüm elemanları eklemek için kullanılan bellek.
- **O(n^2)**: Kuadratik hafıza, giriş boyutunun karesi kadar bellek gerektirir.

### Complexity Türlerinin Anlamı ve Önemi
Bir algoritmanın **zaman ve hafıza karmaşıklığı**, verimliliğini ve ölçeklenebilirliğini doğrudan etkiler. Karmaşıklık türleri arasındaki farklar, özellikle büyük veri kümelerinde algoritmanın ne kadar hızlı veya yavaş çalışacağını anlamamıza yardımcı olur. **Big O Notation**, algoritmalar arasında karşılaştırma yaparak daha verimli çözümler geliştirmemize ve sistem kaynaklarını optimize etmemize yardımcı olur.
