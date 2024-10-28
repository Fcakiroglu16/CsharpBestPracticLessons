
# C# Collection Types: Explanations and Examples

C# koleksiyonları, verilerin farklı yapı ve organizasyonlarda tutulmasını sağlar. Bu belgede en sık kullanılan C# koleksiyon tiplerinin açıklamaları ve örnekleri yer almaktadır.

---

## 1. List<T>

**Açıklama**: `List<T>`, genel bir koleksiyondur ve öğeleri dizi olarak saklar. Sıralama yapılmaz; ekleme sırasına göre düzenlenir. Belirli bir indekse hızlı erişim sağlar.

**Big O Notation**:
- Ekleme: O(1) amortize, O(n) en kötü durum.
- Erişim: O(1)
- Silme (ortadan veya baştan): O(n)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

List<int> list = new List<int> { 1, 2, 3 };
list.Add(4); // Sona ekleme
Console.WriteLine(list[2]); // 3. elemanı alma
```

---

## 2. LinkedList<T>

**Açıklama**: `LinkedList<T>`, çift yönlü bir bağlı liste yapısında çalışır. Başta veya sonda hızlı ekleme/silme işlemleri sağlar.

**Big O Notation**:
- Başa/sona ekleme: O(1)
- Ortaya ekleme/erişim: O(n)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

LinkedList<int> linkedList = new LinkedList<int>();
linkedList.AddLast(1);
linkedList.AddLast(2);
linkedList.AddFirst(0);
foreach (var item in linkedList)
{
    Console.WriteLine(item); // 0, 1, 2
}
```

---

## 3. Dictionary<TKey, TValue>

**Açıklama**: `Dictionary<TKey, TValue>`, anahtar-değer çiftleriyle çalışır. Anahtarlar benzersizdir ve key-value yapısına hızlı erişim sağlar.

**Big O Notation**:
- Ekleme/Erişim: O(1) ortalama, O(n) en kötü durum.

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

Dictionary<string, int> dictionary = new Dictionary<string, int>();
dictionary.Add("bir", 1);
dictionary.Add("iki", 2);
Console.WriteLine(dictionary["bir"]); // 1
```

---

## 4. SortedList<TKey, TValue>

**Açıklama**: `SortedList<TKey, TValue>`, anahtar-değer çiftlerini anahtara göre sıralı tutar.

**Big O Notation**:
- Ekleme: O(log n)
- Erişim/Silme: O(log n)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

SortedList<int, string> sortedList = new SortedList<int, string>();
sortedList.Add(2, "İki");
sortedList.Add(1, "Bir");
foreach (var kvp in sortedList)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}"); // 1: Bir, 2: İki
}
```

---

## 5. HashSet<T>

**Açıklama**: `HashSet<T>`, benzersiz öğeleri depolar. Eleman sıralaması yoktur ve hızlı erişim sağlar.

**Big O Notation**:
- Ekleme/Erişim: O(1) ortalama, O(n) en kötü durum.

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

HashSet<int> hashSet = new HashSet<int>();
hashSet.Add(1);
hashSet.Add(2);
hashSet.Add(2); // Yinelenen eleman eklenmez
foreach (var item in hashSet)
{
    Console.WriteLine(item); // 1, 2
}
```

---

## 6. Queue<T>

**Açıklama**: `Queue<T>`, FIFO (First-In-First-Out) yapısında çalışır. İlk eklenen öğe ilk çıkar.

**Big O Notation**:
- Ekleme: O(1)
- Çıkarma: O(1)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

Queue<string> queue = new Queue<string>();
queue.Enqueue("Birinci");
queue.Enqueue("İkinci");
Console.WriteLine(queue.Dequeue()); // Birinci
```

---

## 7. Stack<T>

**Açıklama**: `Stack<T>`, LIFO (Last-In-First-Out) yapısında çalışır. Son eklenen öğe ilk çıkar.

**Big O Notation**:
- Ekleme/Çıkarma: O(1)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

Stack<string> stack = new Stack<string>();
stack.Push("Birinci");
stack.Push("İkinci");
Console.WriteLine(stack.Pop()); // İkinci
```

---

## 8. Hashtable

**Açıklama**: `Hashtable`, anahtar-değer çiftlerini tutar ancak tür güvenliği yoktur. Bu, `Dictionary`'den farklı olarak genel olmayan (non-generic) bir koleksiyondur.

**Big O Notation**:
- Ekleme/Erişim: O(1) ortalama, O(n) en kötü durum.

**Örnek**:

```csharp
using System;
using System.Collections;

Hashtable hashtable = new Hashtable();
hashtable.Add(1, "Bir");
hashtable.Add(2, "İki");
Console.WriteLine(hashtable[1]); // Bir
```

---

## 9. SortedDictionary<TKey, TValue>

**Açıklama**: `SortedDictionary<TKey, TValue>`, `Dictionary` ile benzerdir ancak anahtarları sıralı bir şekilde saklar.

**Big O Notation**:
- Ekleme/Erişim: O(log n)

**Örnek**:

```csharp
using System;
using System.Collections.Generic;

SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
sortedDictionary.Add(2, "İki");
sortedDictionary.Add(1, "Bir");
foreach (var kvp in sortedDictionary)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}"); // 1: Bir, 2: İki
}
```

---

## 10. ConcurrentDictionary<TKey, TValue>

**Açıklama**: `ConcurrentDictionary<TKey, TValue>` çoklu iş parçacığı (multithreading) ortamlarında güvenli bir şekilde kullanılan bir koleksiyondur. Erişim sırasında kilitlenme veya çakışma yaşamamak için tasarlanmıştır.

**Big O Notation**:
- Ekleme/Erişim: O(1) ortalama

**Örnek**:

```csharp
using System;
using System.Collections.Concurrent;

ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();
concurrentDictionary.TryAdd(1, "Bir");
concurrentDictionary.TryAdd(2, "İki");
Console.WriteLine(concurrentDictionary[1]); // Bir
```

---

Bu belgede C#’ta en yaygın kullanılan koleksiyon türleri açıklanmış ve örnek kodlarla desteklenmiştir. Her koleksiyon türü, belirli kullanım durumları için optimize edilmiştir, bu yüzden uygun koleksiyonu seçmek performans açısından önemlidir.
