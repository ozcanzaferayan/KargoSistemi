KargoSistemi
============

Object Oriented Analysis And Design Course Project

###Vizyon 
Kargo sistemi tipik olarak, müşterilerin ürünlerini en uygun fiyata taşımak amacıyla yapılan bir 
uygulamadır. 
Kullanıcılar ve taşıyıcı firmalar olmak üzere, sistemin iki çeşit kullanıcı tipi vardır: 
* Müşteriler: Ellerindeki ürünün/eşyanın belirli bir fiyata bir yere taşınmasını isteyen 
kişilerdir. 
* Taşıyıcılar (Kargo Firmaları): Müşterilerin eşyalarını belirli bir ücret doğrultusunda 
taşımak isteyen kişiler/firmalardır. 

Müşteriler elinde bulundurdukları **ürünün boyutlarını (en/boy/genişlik)**, **ağırlığını**, vermek 
istediği **ücreti**, **gönderilme ve teslim tarihlerini** ve bu tarihlere ilişkin **adreslerini**, ürünün 
sistemde açık eksiltmede (ihalede) kalacağı **süreyi** sisteme girerler. 

Bu veriler sisteme iletilerek, ihale edilen ürünler sayfasında yer alır. Müşterilerin ekleyecekleri ürün hakkında adrese göre konum arallığı hesaplanarak tahmini bir **fiyat** değeri müşteriye sunulabilir. 
Taşıyıcı firmalar da ilgilenecekleri ürün detayları ile ilgili bir **tercih (preferences) sayfası** 
bulundururlar. Bu sayfaya ilgilenmek istedikleri ürünün **özelliklerini (fiyat, ağırlık gibi)** girerek, 
ihale edilen ürünler arasında arama yapabilirler. İlgilendikleri ürüne, müşterinin teklif ettiği fiyat 
tutarında veya daha az bir miktarda fiyat teklifi sunarak ürünün kendi doğrultusunda 
taşınmasını önerirler. İhale süresi kapanınca, ihalede **en düşük fiyatı** sunan *3 taşıyıcı* müşteriye 
bildirilir ve müşteri bu taşıyıcılardan birini seçer. 

Müşteriler her taşıyıcı firma ile ilgili **yıldızlandırma (derecelendirme)** ve **yorumlarda** 
bulunarak, taşıyıcıdan ne kadar memnun olduğunu sisteme iletirler ve diğer müşteriler de bu 
yorumlara bakarak taşıyıcı hakkında çıkarımda bulunabilirler. 
Sistem herkesin kullanımına ücretsiz açıktır. Fakat belirli bir fiyat üzerinde yapılacak ihaleleri 
sadece **VIP (Premium) müşteriler** verebilir ve bu müşterilerin sunduğu ihalelere sadece VIP 
taşıyıcılar girebilir. 

VIP olmayan müşterilerin ve taşıyıcılarn ücret sınırı aynı Dropbox’ta olduğu gibi, müşteri 
sisteme farklı cihazlarını entegre ettiğinde, sistemde online olma süresine, sistemde aktif olarak 
yorumlar yaparak bulunma süresine göre belirli **puanlar** alarak bu sınır arttırılabilir. 
Sistemde **ceza puanı** da bulunur. Müşterilerin sisteme girdikleri ürün yerine teslimata farklı 
özelliklere sahip bir ürün vermeleri halinde belirli bir oranda ceza puanı alırlar. Taşıyıcılar için de 
benzer bir durum geçerlidir. Müşterilerin teklifini kabul ederek teslimi üstlenen taşıyıcılar belirli 
tarih aralığında eğer teslimi yapamazlarsa sistemde belirtilen orana göre ceza puanı alırlar. 


Some design images in this project:
![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/KargoSistemi/master/Project%20Design%20Files/Use%20Case%20Diagram%20(19.07%2008-03-14).jpg)

![alt tag](https://raw.githubusercontent.com/ozcanzaferayan/KargoSistemi/master/Project%20Design%20Files/(UC1)Kargo%20i%C5%9Fi%20ekleme.jpg)
