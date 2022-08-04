OBJECT ORIENTED PROGRAMMING (OOP)
1.	OOP Nedir?
Belli kurallar ve kalıplar dahilinde, tekrarsız ve anlaşılabilir kod yazmamıza olanak sağlayan bir yapıdır. 
Karmaşık gerçek yaşam gereksinimlerinin, bilgisayarın anlaması için talimatlara modellenmesi gerekir. İşlemsel Programlama, Nesne yönelimli programlama, İşlevsel Programlama vb. gibi iş gereksinimlerini bilgisayar programlarına modellemeye yardımcı olabilecek birkaç paradigma vardır. OOP de bunlardan biridir.
 OOP Bütün dünyayı nesneler ( objects ) ve nesneler arası ilişki olarak gören bir model kullanılarak yapılan bir programlama tekniğidir. 
Nesne Yönelimli Programlama (OOP) bir felsefedir ve dilden bağımsızdır. 
2.	OOP Ne için Kullanılır (Neden OOP'ye ihtiyaç duyuldu) -Tarihçesi
1960’li yıllarının sonlarına doğru programlama dünyasına dahil olduğu bilinmektedir. Kod karmaşıklıkları, tekrarlı kodlar ve meydana gelen teknolojik sorunlar neticesinde ortaya çıkmıştır. Nesne yönelimli programlama terminolojisindeki “object/nesne” ve “oriented/yönelimli” kavramları ilk olarak 1966 veya 1967 yılında NYP’nin babası olarak bilinen Alan Kay tarafından kullanılmıştır.
OOP yi destekleyen ilk dillere Simula ve Smaltalk örnek verilebilir. Günümüzde ise kullanan dillere C#, java ,Python, C++, Delphi, Swift ,perl, ruby ve PHP örnek verilebilir . Bunlardan JAVA  pure object oriented (Saf nesne yönelimli programlama dili) dir ve JAVA bütün mantığını nesne yönelimli olarak inşa etmiştir.
3.	 OOP nin sağladığı kolaylıklar 

-	Gerçek dünyadaki nesnelerin tasarımları sınıf içinde yapılır.

-	Sınıftan nesne üretilip değişiklik yapılmak istendiğinde tüm programda değişiklik yapmak gerekmez, sadece oluşturulan nesnenin sınıf içinde değişiklik yapılması yeterlidir.

-	Oluşturulan nesneler birbirinden bağımsız olduğu için bilgi gizleme olanağı artar.

-	Nesne oluşturma, bir sınıf içerisinde gerçekleştirilir ve bu kodlar başka projelerde kullanılabilir.

-	Nesne Yönelimli Programlama ‘da mevcut bir sınıfa yeni özellik ve metotlar ekleyerek artan işlevsellik sağlamak çok kolaydır.

-	Oluşturulan sınıflar yardımıyla daha az kod ile daha fazla iş yapılıp kod tekrarı önlenir.

-	Kod tekrarı önlendiği için geliştirme sürecinin verimliliği artar

4.	OOP Özellikleri Nelerdir ? OOP Özellikleri Ne için ve Nasıl Kullanılır?
NYP paradigmasında dünyadaki herhangi bir şeyi bir nesne olarak düşünmek hem basittir hem de doğal hayatın akışına uygun bir yaklaşımdır. Dolayısıyla NYP’nin yordamsal programlama yaklaşımının genişletilmiş ve gerçeğe çok daha yakın bir versiyonu olduğunu söylemek mümkündür. Değişkenler ve fonksiyonlar (metotlar) bu yaklaşımda da kullanılır fakat burada ana odak noktası nesnelerdir.
Yordamsal programlamadaki büyük ve karmaşık sistemleri tasarlamak yerine, birbiriyle iletişim ve etkileşim halinde nesnelerin olduğu bir dünya kolayca tasarlanabilir. NYP paradigmasını destekleyen bir dilin aşağıdaki dört özelliğe sahip olması gerekmektedir. Bu özelliklerin tanımlarını yapmadan önce Sınıf ve Nesne kavramlarının tanımlanması ve içselleştirilmesi gerekmektedir.
Nesne ise , içinde veri ve bu veriler üzerinde işlem yapacak olan metotları (fonksiyon) bulunduran yazılım bileşenidir. Nesne bu tanıma uygun olarak, kendi işlevselliğini de içinde taşır. Nesneler her uygulamada tekrar tekrar kullanılabilir. Veri ve metotlar, birlikte nesnenin üyeleri (members) adını alır. Bir nesne yapısı, bir sınıf (class) içinde tanımlanır. Sınıf içinde nesneyi oluşturan üye değişkenler ve metotlar açıkça tanımlanır.
Nesne Yönelimli Programlamada 4 temel özellik :
1.) Soyutlama (Abstraction)
2.) Kapsülleme (Encapsulation)
3.) Miras Alma (Inheritance)
4.) Çok biçimlilik (Polymorphism)

•	KAPSÜLLEME(Encapsulation)
Encapsulation (sarma) NYP’nin temel kavramlarından biridir. Genel tanımıyla kullanıcı tarafından verilerin, sınıfların ve metotların ne kadarının görüntülenebileceği ve değiştirilebileceğinin sınırlarının konulmasını sağlar. 
Bunun için aşağıdaki Erişim düzenleyiciler (Access modifier) kullanılır
1.	Public: Bütün sınıflar tarafından ulaşılabilir
2.	Private: Sadece kendi sınıfında kullanılan özellik ve davranışlara verilen isimdir.
3.	Protected: Sınıf ve Miras Alınan alt sınıflarda kullanılmaya açık olanlara verilen isimdir.
4.	Internal: Sadece bulunduğu proje içerisinden erişilebilir konumda olmasını sağlar.
5.	Protected Internal: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir. Aynı proje içerisinde olma şartı olmamasıyla protected’dan farklılaşır.

Eğer sınıflar için tanımlanırken erişim özelliği belirlenmezse private default olarak tanımlanır. 

Bazı durumlarda private bir claas in içine erişmemiz ve bazen data yı değiştirmemiz gerekebilir. Bu durumdalar da field lara erişim kontrolü yapmamız için geliştirilmiş olan yapılara property denmektedir.

Property yapısını oluşturabilmenin yapısal olarak birkaç farklı yolu vardır

Full property
Prop
Auto Property initialzers
Ref read only returns
Computed (Hesaplanmış) proporties
Expression boodied property
Init only properties ve init acessor

Full porperty: 

En sade porperty yapılanmasıdır, içersin de Get ve Set blokları ile tanımlanmalıdır. Sadece GET bloğu tanımlanmazsa sadece yazılabilir , Set  bloğu tanımlanmazsa sadece okunabilir. Senin burada field tanımlanman gerekir. 

get  
{

}
Set
{

}

Prop :

Temsil ettiği field daki bilgiye hiç müdahale edilmeden değeri kullanıyya vermesine yada field alanına direk yazmasında kullanılır.  Bu imzada property sadece read olabilir fakat sadece write olamaz. Class içinde bu durumda fiel ı sen tanımlamazsın senin adına derleyici bu durumda tanımlayacaktır. 

{ get; set; }


Auto Property initialzers:

Bir property’nin ilk değerini nesne ayağa kaldırı kaldırılmaz atayabiliriz . bu yine field üzerinde bir işlem yapılmadan yapılacak durumlarda kullanılabilir. Bu özellik sayesinde read only olan değerlere hızlıca değer atanabilmektedir.  Read only bir property dir

Public string Adi {get; set;} = “ZORLU”

Ref read only returns:

Bir sınıf içersindeki field ı refereansı ile döndürmemeizi sağlayan ve bir yadan da bu değişkenin değerini read only yapan özelliktir aşağıda bize sadece field dı geri döncektir

String adi = “zorlu”

Public ref readonly string Adi => ref adi 

Computed (Hesaplanmış) proporties :

İçerisinde türetilmiş bir bağıntı taşıyan property dir.  Aritmetik işlemlerin yapılıp dönülmesi gibi.


Expression boodied property :

Sadecec read only olrak kullanılabilr. Porportey aşağıdaki gibi imzası vardır.

Public string cinsiyet => “Erkek”

Init only properties ve init acessor

Nesnenin sadece ilk yaratılış anında property lerine değer atamaktadır.  Böylece iş kuralı gereği run time da değeri değişmemişi gereken nesneler için önlem alınmaktadır. Bu özellik Init keyword ile kullanılmaktadır. 


Encapsulation sayesinde sınıf ve üyeleri üzerinde daha iyi bir kontrol sağlayarak programcının yada başkalarının kodu bozmasını engellemiş oluruz. Get ve set özelikleri ile fied ları sadece okuyabilir sadece yazılabilir de yaparız. Bize kodun diğer parçaları etkilenmeden değiştirebilme esnekliği sağlar.  Verinin güvenliğini artırmış oluruz. 
•	MİRAS ALMA(Inheritance)
Inheritance (kalıtım) bir sınıftan başka bir sınıf türetirken aralarında bir alt-üst ilişkisi oluşturmayı ve bu sınıflar üzerinde ortak metotlar ve özellikler kullanılmasını sağlayan bir mekanizmadır.
Nesneye yönelik programlamada, bir nesne, genellikle bir nesne sınıfına ait bir örnektir (instance).
Kendisinden alt sınıf üretilen sınıfa, temel sınıf (base class) veya süper sınıf (super class) veya ana sınıf (parent class) adı verilir. Subclass yerine child class terimi de kullanılmaktadır.
Bir class hem drived hem base class olabilir. Bir class sadece bir adet base claass ı olabilir.
Bir nesne üretilirken kalıtımm aldığı üst sınıflar varsa önce o sınıflardan sırayla nesne üretilecektir. Bu üretimin yapılabilmesi için Base sınıfı constructor ı tetiklenmedir.
Base Keywordü:
 Bir classın constructorın yanında kullanılırsa o classın tüm cons. getirecektir. Hangi cons. tetikeklenmesi gerekliğini bu şekilde belirleyebiliriz. Dirve class ile kullanılır.
Base ile base class taki member lara ulaşabiliriz. Sadece erişelilebilir olanlara erişilebilir
This keywordü :
Bir sınıfın costructorları arasında geçiş yapmak istenildiğinde kullanılan keyword tür. This ile kendi clasındaki memberlara ulaşabilirsin, bu kalıtımsal olarak gelen üyeler içinde geçerlidir, onalra da ulabilirsin

Alt sınıfın nesneleri, türetildikleri temel sınıfa ait özellikleri alıyorsa, burada miras alma (inheritance) özelliği vardır denir.
Bu anlamda, miras alma özellikli bir nesne yönelimli programlama dilinde, bir nesne sınıfından türetilen alt nesne sınıfına ait nesneler, üst sınıfın özelliklerini (properties) ve metodlarını (methods) aynen alırlar.
Bir class dan miras alınırken “:” sembolü kullanılır. Inheritance kodun tekrar kullanılabilirliği açısında önemlidir. Bu sayede yeni bir class yaratarak (instance) methodları field ları tanımlayabiliriz. 
Bir sınıf oluşturulduğunda object sınıfından türetilecektir. Bu kalıtımsal olarak Equals,Gethascode, tostrring ,gettype metotların kalıtımsal olarak gelmesinin nedenidir.
The Sealed anahtar kelimesi :
Oluşturduğun sınıfın başka bit sınıf tarafından miras alınmasını engellemek istiyorsak sealed anahtar sözcüğünü aşağıdaki kullanabiliriz.






Name Hiding Sorunsalı : 

Kalıtım durumlarında atalardaki herhangi bir member ile aynı isimde olması durumudur. Bu base veya atalardan geldiği için isim saklanmış oluyor. Derleyici hata vermez ama new keywordünün kullanılması gerektiğini uyarısını eskiden belirtirdi. Şuan ki durumlarda bu gerekli değildir derleyici new olarak algılar.

•	SOYUTLAMA(Abstraction)
Soyutlama denilince, nesneyi bazı karakteristikleri olan ve bazı eylemleri gerçekleştirebilen bir veri tipi olarak genelleştirmek anlaşılmalıdır.
Abstraction yani soyutlama sınıf tanımlarında yalnızca gerekli özelliklerin üzerine odaklanılıp buradan belirli yapılar elde etme işidir. Ana amacı gereksiz karmaşıklığı elimine etmek böylece gereksiz detaylardan kullanıcıyı kurtarmaktır. Ayrıca güvenliğin artmasını sağlar.
Soyutlama, soyut sınıflar (abstract classes) veya arayüzler ( interfaces) ile gerçekleştirilebilir.

Soyut yapılar nelerdir:
Sanal yapı bir sınıf  içerisinde bildirilmiş olan ve o sınıftan türeyen alt sınıflarda tekrar türeyebilen yapılardır.  Metot veya property olabilir. Bir sınıfta türeyen sanal yapı bu sınıfta türeyen torunlarında ezilebilmekte yani yeniden yapılandırılabilmektedir. Yani sanal yapılandırmalarda üstten gelen bir yapının yeniden yapılandırılması vardır.
Sanal yapının yeniden azılması yada atadan gelenin kullanılması durumların hepsinin kararı run timde da verilecektir. Eğer yeniden tasarlanırsa çağrılan nesnenin asıl üyesi olacaktır. Değiştirilmezse geldiği sınıfın sanal üyesi olarak kalacaktır. Bu duruma da late biding denir. 
Bu durumu kullanma sebebimiz istediğimiz yerlerde değiştirebilme olanağını verir. Sanal yapı oluşturabilmek için Virtual keywordü kullanılmalıdır. Aşağıdaki sınıf sanal bir sınıftır. 
My class {
Public virtual method ()
{
}
               }
Virtual ile işaretlenen method yada property in yeniden yazılması için override ile tekrardan aynı member oluşturulmalıdır. Birden fazla kez override edilebilir
Class My class2 : My class
{
Public virtuual void method() 
 {
 }
}
Abstract Class: 
Abstract class , nesneler oluşturmak için kullanılamayan kısıtlı bir sınıftır (ona erişmek için  başka bir sınıftan miras alınması gerekir).
Abstract Method ; sadece Abstract class ile kullanılabilir ve gövdesi yoktur. Gövde türetilmiş sınıf tarafından sağlanır. 
Abstract class  aynı anda hem düzenli (regular ) method hemde abstract method a sahip olabilir. 
Abstract class içinde tanımlanan abstract metot ve propertyler miras verilen sınıfta uygulanmak zorundadır.  
İnterface :
İnterface sadece abstract method ve özelikler içerebilir. Aşağıdaki örnekteki gibi;
interface Animal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}
Kendisinden kalıtım olacak sınıflara, o sınıflara bir şablan yada arayüz özelliği gösterir. 
Interface leri class dan ayırt etmek için başlarında” I” kullanımı yaygındır. Bu zorunluluk değil yazılım kültüründen gelir. 
Interface methodlar gövde içermez, bundan türetilen sınıflarda metotların gövdeleri doldurulur. 
İnterface lerin gövdesinde erişim belirleyiciler kullanılmaz. Kalıtım alan drever class larda zorla uygulatacağı imzayı taşır. 
Interfacler nesne üretici olarak kullanılmadığından constructor yoktur. Referans noktası oluşturabilir. Bir sınıf birden fazla interfacden kalıtım alabilir buna multiple inheritance denir.
Interface kullanım nedeni; güvenliği artırabilmek, kullanıcıdan detayları gözleyip sadece önemli olanı verebilmek. 

•	Çok biçimlilik (Polymorphism)
İki veeya daha fazla nesnenin aynı tür sınıf tarafından referans edilebilmesidir. Yani bir nesnenin birden dazla farklı türdeki referans tarafından işaretlenebilmesi polimorfizm dir.
Plimorfizm OOP tasarımalrında geliştirilen koda daha manevrasal bir şekilde nitelik kazandıran ir yaklaşım sergilememizi sağlayan bir özeliktir.
Programlamada temel prensip olan sol sağ prensibini yani A a = new A(); mantığını aşıp eldeki nesnenin birden fazla referansla işaretlenmesini sağlar. Böylece bu nesne birden fazla türün davranışını sergilemesini sağlamış oluruz
Örnek olarak byte türünden bir değeri bir integer a atayabiliriz  bu bir çok biçimlilik felsefesidir ya da string bir değeri string e de object tede atayabiliriz bu bir polimorfizm dir. 
OOP de bir nesnenin başka bir nesne ile işaretlenebilmesi için arada kesinlikle kalıtımsal bir ilişki olmalıdır. A a=  new B() ; olması için aşağıdaki kalıtımsal ilişki olmalıdır
Polimorfiziim türüleri : statik ve dinamik polifizimdr. Static olana method overloading örnek verilebilir bu poliformizim de derleme anında karar verilir. Dinamik olan çalışma zamanında sergilenen polimorfizmdir . Çalışmma anında olduğu için dinamiktir yani değişkenlik gösterebilir. Bu durumada method override örnek verilebilir, yani sanal sınıfların run time da override edilmesidir. 
Class A 
{
}
Class B :A
{
}
Bu sayede kalıtımsal olarak a da hem A nın hem de B nin metod ve property lerine erişebilmemizi sağlar. 




