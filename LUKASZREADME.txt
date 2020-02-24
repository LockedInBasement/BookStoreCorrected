Commit 1 - STAGE 1:
Skladniki instalacji do całego projektu to:
-Opracowanie Zawartości dla platformy ASP.NET i sieci Web
-Programowanie na platformie Azure
-Programowanie aplikacji klasycznych dla platformy .NET
-Magazynowanie i przetwarzanie danych
-Programowanie rozszerzeń programu VisualStudio
-Programowanie dla wielu platform w środowisku .NET

Potrzebujesz wszystkich packów dla książki i tutorialu. Reszte doinstalujesz nugetem. Jbc to daj znać w razie problemów.

Stage 3:

3A.Missing context files
To jest blad w ksiazce - errata powinna byc dodana - autor najpier leci z CF a potem z DF dlatego sie wszystko rozjeżdża. Po prostu zrób tylko CF - reszte olej i bedzie wszystko ok.

3B.Baza
Baze wpisujesz recznie(nie ma juz default name'a numerem versji) - tworzysz z (localdb)\MSSQLLocalDB (defaultowo to bedzie twoj serwer) a potem na dole wpisujesz nazwe twojej bazy.
Potem muszisz dodac w web.config inny connection string niz podany(patrz zmiany w commicie).

4.Stage 4:
4A.Linq ->stare enumy sa obsolete np: ASC-> Ascending itd. Po prostu usun wszystkie i czekaj co ci intellisense pokaze ;)
4B.Autor dal ciala z namespaceami-usun wszystkie namespacy z katalogami i sprowadz do jednej biblioteki np:

ABC.DataAccesLayer-> ABC
ABC.Extensions->ABC
ABC.Models->ABC

albo importujesz wszystkie biblioteki do każdego pliku osobno(autor pomija dość dużo ref'ów),
tak długo jak nie ma konfiltu nazw wszystko bedzie ok. Po prostu nie dubluj nazw.

Stage 6
W calej ksiazce nie ma walidacji danych -> czesc jest wprowadzona w rodziale 6 , reszte musisz dopisac sam.
