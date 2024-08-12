# Sınıf ve Resource Dosyası İlişkisi

Resource dosyalarının isimleri, onları kullanan sınıfların adlarıyla eşleştirilmelidir. Eğer bir sınıf için resource dosyası oluşturuyorsanız, dosya adı sınıfın tam adıyla (namespace dahil) ve kültür koduyla birlikte olmalıdır.

## Kural


## Örnek

- **Namespace:** `MyApp.Services`
- **Class Name:** `LocService`

### Resource Dosyaları

- `Resources/MyApp.Services.LocService.en-US.resx`
- `Resources/MyApp.Services.LocService.tr-TR.resx`
- `Resources/MyApp.Services.LocService.de-DE.resx`
