# TraverselCore
Entity Framework Core - N Tier Architecture

Seyahat ve Rezervasyon Sitesi <br>
Sitemizin üye paneli ve admin paneli bulunmaktadır.

<h2>Kullanılan Tablolar</h2>

![tables](https://user-images.githubusercontent.com/76698070/211226001-887240e2-ac0b-4e71-a2a1-a3db89736a87.png)


<h2>Ana Sayfa</h2>


![dash](https://user-images.githubusercontent.com/76698070/211225962-722d687c-77ec-46f1-baa3-259c0fe5324a.png)


<h2>Uye Paneli</h2>

![uy-panel](https://user-images.githubusercontent.com/76698070/211225976-0641dfc0-dc80-4539-9464-db082b59eca8.png)

<h2>Kayıt Olma Ekranı<h/2>


![reg](https://user-images.githubusercontent.com/76698070/211226040-08c18d1a-8fe8-42a1-a39e-1e8a63230959.png)


<h2>Projemizde N Katmanlı Mimari Kullanılmaktadır.</h2>
<h5>Şu anda 4 Katman bulunuyor. Geliştirme esnasında Core katmanı da eklenecektir.</h5>

![katman](https://user-images.githubusercontent.com/76698070/211226141-606231f4-a574-49ff-885f-d07cbf128486.png)

<h4> USER INTERFACE KATMANI</h4>
<h5>Bu katmanda projeye ait olan tüm html,css,javascript dosyaları bulunmaktadır. Ayrıca diğer katmanlarla iletişim halinde olan ve görünümlere veri aktaran Controller'lar da bu katmanda bulunmaktadır. Aynı zamanda üye ve admin panellerimiz için ayırıcı görev gören Area'larda bu katmandadır.</h5>

<h4>ENTITY KATMANI</h4>
<h5>Veritabanına yansıyan tüm tablo ve sütunları içeren yapılar bu katmanda bulunur.</h5>

<h4> DATA ACCESS KATMANI</h4>
<h5>Veritabanı bağlantısı (Context) , migration işlemleri ve diğer veritabanı CRUD(Create,Read,Update,Delete) fonksiyonlarının yapıldığı katmandır.</h5>

<h4> BUSINESS KATMANI</h4>
<h5>Entity ve Data access katmanını kullanarak proje içerisindeki validasyon(kurallar) işlemlerinin yapıldığı katmandır. User Interface, Business katmanı ile direkt olarak haberleşir.</h5>
