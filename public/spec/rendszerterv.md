
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

### Szerepkörök
- Designer & Developer: Csontos Dominik
- Senior Designer: Palotai Martin
- Designer & Developer: Kóder László
- Designer & Developer: Sirák Norbert

### Egyéni Projekt Munkálatok
- Design elkészítése: Csontos Dominik
- Keretrendszer elkészítése: Palotai Martin

### Közös feladatok
- Követelmény Specifikáció megírásában történő közreműködés
- Funkcionális Specifikáció megírásában történő közreműködés
- Rendszerterv megírásában történő közreműködés

## Üzleti folyamatok modellje
### Megrendelő
- A megrendelő olyan céget üzemeltet, ahol hosszú és kihívást jelentő játékokat készítenek.
- A játékok egy része platformer stílusú.
- Az ügyfél nem elégedett a jelenlegi eladások számával.
- Az eladások kevés száma azért van, mivel már egy ideje nem hoztak piacra új játékot.

A játékokkal kapcsolatos elvárások és igények kielégítésére az ügyfél ötlete tökéletesen alkalmas.
Az emberek manapság sokkal inkább érdeklődnek a retro jellegű platformerek iránt, épp ezért a cél egy ilyen jellegű játék létrehozása. Mely alkalmazkodik az eddigi üzleti folyamatokhoz: van benne kihívás és hosszan tartó szórakoztató játékélmény.

### Célok
- Átlátható felhasználói felület készítése a játékhoz
- Élvezetes játékmenet megvalósítása
- A platformer játékok színesítése
- Nagyob, közösségre alapuló projektek lehetőségeinek megteremtése
- Többféle eszközről is játszható játék, ami növeli a népszerűséget
- Új játékosbázis kialakítása
- 
### Előnyök
- Új játékosbázis
- Régi játékosok visszacsábítása a platformra
- Új promóciós lehetőségek
- Nagy profit
- A játék jellegéből adódóan: népszerűség

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

### Pálya rendszer:
- Megtekinhetőek a pályák nevei
- Azokhoz tartozó képek
- Az, hogy teljesitett-e az adott pálya
- A teljesitmény szintje
- A rejtett tárgy meg lett-e találva

### Felszerelés rendszer
- Fontosabb felszerelésben szereplő tárgyak mindig láthatóak
- Összes tárgy megtekintése gombnyomásra
- Tárgyak használata
- Tárgyak kidobása

### Fegyver rendszer
- Távolharci fegyverek
- Közelharci fegyverek
- Rejtett fegyverek
- Fegyverek lövése
- Fegyverek újratöltése
- Ammunició követése

### Harcrendszer
- Közelharci és lőfegyverekkel zajlik
- Az alapvető fegyverek: kés és pisztoly
- Speciális képességek különleges fegyvereket adnak
- Ha 0-ra esik a HP-ja egy karakternek, meghal

### Mozgás rendszer
- Jobbra való mozgás
- Balra való mozgás
- Ugrás
- Falon ugrás
- Kúszás
- Egér irányába való lövés

### Képességrendszer
- Képességpontokat lehet gyűjteni
- Ágakon lehet képességeket fejleszteni
- Szintek alapján lehet fejleszteni
- Bónuszokat adnak, ágakon lehet továbbvinni őket

### Lootrendszer
- Az ellenségek dobhatnak tárgyakat
- A pályán vannak lootolható ládák
- Növényeket is lehet gyűjteni
- A pályán szétszórva itemek találhatók

### Raktár
- Itemek tárolása
- Bővíthető (nagyobb táskával)
- Bázison is lehet tárolni itemeket
- Lapozható raktárabalakok

### Ellenségek
- Különféle típusúak
- A játékos érzékelésekor támadnak
- Lehet tőlük zsákmányolni
- Küldetésekben lehet szerepük

### Barátságos NPC-k
- Történetet viszik előrébb
- Küldetéseket adnak
- Lehet tőlük tárgyakat vásárolni
- El lehet nekik adni tárgyakat

### Felhasználói felület:
- Belépéskor választható menüpontok: Resume, Levels, Settings, Quit
- Játék közben történő megállításkor a Levels helyett Save opció jelenik meg
- A sarkokban mutatja a játékos életerejét, fegyverét és töltényeinek számát, leltárát és egyéb gombokat, mint pl.: Skills
- Leltárban a fegyverekre húzva az egeret megjelennek annak statjai és a lehetséges tevékenységek

## Funkcionális terv
	Rendszerszereplők:
		Felhasználó.

	Rendszerhasználati esetek:
		Telepítés.
		Játék.

## Fizikai környezet
A teszt Windows, macOS, illetve Linux operációs rendszereken futtatható.
Nincsenek megvásárolt komponenseink.
Fejlesztői eszközök:
	Unity
	C#

## Architekturális terv

A játék megvalósítását a Unity nevű programmal tervezzük megvalósítani.

Ezeket a scripteket amennyire csak lehet külön fájlokba írva készítjük, és
úgy fogjuk egymáshoz csatolni a jobb átláthatóság, könnyebb változtathatóság,
és könnyebb bővítés érdekében. Az egyedi eseteket leszámítva.


## Adatbázis terv


## Implementációs terv
### A követelménylistában feltüntetett elemek implementálása:
- Javarészt a Unity videójáték-motor segítségével
- Gites verziókövetést használva
- Trellon végzendő feladatkövetéssel
- Csapatos meetingek során sprintekben
- Tervezési minták szerint

### Tervezési minták
Ebben a pontban a tervezési minták konkrét eszközölését írjuk le.

#### MVC
A pályák adatbázismodellekre (model), nézetekre (view) és a kettőt összekötő logikára (controller) lesznek tagolva a könyvtárrendszerben.

#### Singleton
A főmenü csupán egyszer kerül majd példányosításra a játék indításakor, a pályákon való megállítások során ugyanezt a példányt fogja látni a játékos.

#### Prototípus
Egyes ellenségekből prototípust fogunk készíteni, és ezt a példányt klónozva különböző színösszeállítású szörnyeket fogunk generálni.

#### Gyártófüggvény
A főkarakter konstruktora kizárólag egy olyan függvény által kerülhet majd meghívásra, amely azt vizsgálja, hogy van-e még élete a játékosnak.
Ha minden élete elfogyott, akkor a pálya újraindítása és a karakter újboli példányosítása helyett a "Game Over" felirat jelenik meg és véget ér a játék.

#### Sablonfüggvény
Ellenseg ősosztállyal rendelkező származtatott osztályok az ősük tuzeles() metódusát fogják override-olni, például: töltény helyett rakétát lőnek majd.

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
