
# Rendszerterv

## A rendszer célja
A felhasználó egy olyan platformer játékkal játszhasson, amely egy posztapokaliptikus világban játszódik, ahol
az Ózdi Atomerőmű katasztrófájának valódi történetét kell felfedezni a kalandok során.
A felhasználónak a játék elkezdéséhel meg kell azt vásárolnia, letöltenie, majd telepítenie.
Egyszerre csak egy játékot kezdhetünk el, ha szeretnénk újból kezdeni a játékot, akkor nem nyílik
lehetősége a felhasználónak új játékbeli karakter készítésére, hanem a jelenlegit kell törölnie és újat indítani.
A játék minden pálya elvégzése után mentést készít, így legközelebb azon pályán folytathatjuk, ahol abbahagytuk.
A felhasználónak lehetősége nyílik különböző fegyverek és felszerelések szerzésére a játék során.
Tehát a fő cél a felhasználó szórakoztatása egy történet alapú, lövöldözős platformer játékkal.

## Projektterv


## Üzleti folyamatok modellje


## Követelmények

### Funkcionális követelmények
- Mozgás: A karakternek képesnek kell lennie a nyilak vagy "WASD" gombok segítségével mozognia.
- Tüzelés: A karakternek képesnek kell lennie a "szóköz" gomb megnyomásával elsütni az éppen kézben tartott fegyverét.
- Újratöltés: A karakternek képesnek kell lennie az "R" gomb megnyomásával újratölteni a fegyverét.
- Interakció: A karakternek képesnek kell lennie a pálya néhány elemével interakcióba lépni az "Enter" gomb megnyomásával.
- Felszerelés: A karakternek a következő pálya előtt mindig kiválaszthatjuk, hogy milyen felszerelést hozzon magával legközelebb.

### Nem funkcionális követelmények
- Ikonok használata a fegyverek és felszerelések megkülönböztetésére.
- Felhasználóbarát grafikus interface kialakítása, melyet könnyű átlátni és kezelni.
- Poszt-apokaliptikus hangulat megteremtése a pálya-, karakter-, felszerelés-design elemeit illetően

## Funkcionális terv
	Rendszerszereplők:
		Felhasználó.

	Rendszerhasználati esetek:
		Telepítés.
		Játék.

## Fizikai környezet


## Architekturális terv

A játék megvalósítását a Unity nevű programmal tervezzük megvalósítani.

Ezeket a scripteket amennyire csak lehet külön fájlokba írva készítjük, és
úgy fogjuk egymáshoz csatolni a jobb átláthatóság, könnyebb változtathatóság,
és könnyebb bővítés érdekében. Az egyedi eseteket leszámítva.


## Adatbázis terv


## Implementációs terv


## Tesztterv
A teszteléseink célja a teljes rendszer és annak minden játékmódja és azok minden komponensei 
funkcionalitásának hiánytalan vizsgálata, ellenőrzése.
A rendszerbéli hiányosságok feltárása és javítása.
A tesztelésink metódusait három fő komponensre tudjuk bontani melyek:
Az első minden egyes funkció megírásakor az a fejleszés akkori szakaszában valósul meg 
amikor a fejlesztő előszőr lefuttatja az adott funkciót és megnézi a kapott választ.
A második amikor az adott funkció megvalósított formában kerül futtatható formátumban.
Ekkor a fejlesztő mint egyszerű játékos próbálja ki a funkciót minden lehetséges módon és az ezekből kapott válaszokat 
nézi a console felületén. Ezen válaszok alapján tudja értékelni, hogy az adott funkció tökéletesen működik, 
vagy hiba van bizonyos eljárások, logikák során. Melyek javítást igényelnek.
A harmadik amikor az eddig meglévő funkcióknak a különböző számítógépekkel való kompatibilitásának tesztelése. 
Ezeket a lépéseket bármelyik fejlesztő végezheti és nem csak a saját részlegét tesztelheti ilyen módon.
Az eljárás sikeres, ha különböző számítógépeken is
megfelelően működik minden funkciók, és akkor ér véget ha minden funkciót sikeresen tesztelt.

Tesztelendő funkciók:

Menü rendszer:

Képesnek kell lennie kilépés, új játék indításra funkciókra.

Játékok felülete:

A játékok felületének képesnek kell lennie a funkcionális specifikációban megadott
képernyőtervek szerint megvalósulnia. Minden funkcióját betöltenie.

## Telepítési terv

Asztali alkalmazás.

Mire van szükségünk ahhoz, hogy használni tudjuk?
- Számítógép
- Internet(A letöltés és vásárlás miatt)

- Böngésző program(A letöltés és vásárlás miatt):
	- Google Chrome
	- Safari
	- Opera
	- Mozilla Firefox

Hogyan telepítsük?
A vásárlást követően, a szolgáltató oldalán elérhetővé válik a játék telepítőjének letöltése.
Letöltés után:
	- Elindítjuk a telepítőt
	- Elfogadjuk a felhasználási feltételeket
	- Kiválasztjuk a mappát, ahová telepíteni szeretnénk
	- Telepítés végeztével bezárjuk a telepítőt
	- Elindítjuk a játékot és már játszhatunk is

## Karbantartási terv

Ellenőrizni kell a játékosok számítógépeihez való 
kompatibilitást és reszponzivitást. Majd ha nem valósul meg 
kijavítani a teljes funcionalitást.
Valamint a játékosok visszajelzései alapján a folyamatokban kialakuló problémák kiértékelése és azok megoldására kell törekedni. A játékosok új igényei és a játék naprakész tartása érdekében folyamatos módosítások. A játék hosszútávon is magas élvezeti faktoron valóü tartása érdekében. 