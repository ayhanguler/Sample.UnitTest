# UnitTest

Unit test, adı üzerinde birim testidir, yazılımın test edilebilir en küçük parçasının test edildiği, yazılım sürecidir.
Birimlerin tek tek biribirinden bağımsız testi yapılır, yazılım testlerinin ilk seviyesidir, bundan sonraki seviyede entegrasyon
testleri vardır. Unit testleri yazılımın geliştiricisi kendi yazar.

Unit testin amacı, yazılımın her fonksiyonunun doğru çalıştığını doğrulamak ve kod refactor işlemini kolaylaştırmaktır.
Unit testler ile yazılan kod hızlı bir şekilde test edilebilir.

Unit testleri uygulamadan önce kodun solid prensiplerine uygun yazılmış olması, dependency injection'ların düzgün şekilde yapılmış
olması unit testlerin yazımını kolaylaştırır ve doğru test yazımına olanak sağlar.

Uygulamamız matematik işlemlerinin yapıldığı bir kütüphane projesi ve bunu test eden unit test projesini içerir.
Microsoft.VisualStudio.TestTools.UnitTesting kütüphanesi kullanılarak oluşturulmuştur.
Uygulamada unit testin doğru çalıştığını tespit için, matematik işlemlerinden, çarpma işlemi bilinçli şekilde yanlış yazılmıştır.
