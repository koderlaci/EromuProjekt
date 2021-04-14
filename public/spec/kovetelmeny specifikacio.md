

# Követelmény specifikáció

##  Áttekintés
Egy olyan 2D platformer játékot fejlesztünk melyben a felhasználó egy posztapokaliptikus világban kell túlélnie saját maga által szerzett fegyverekkel. 
A felhasználónak először csak egy pisztoly és egy bunkós bot áll a rendelkezésére, viszont a játék folyamán különböző módon lehetősége lesz új fegyverek megszerezésére. 
A felhasználó célja, hogy az előtte álló akadályokon átküzdve magát kideritse, hogy mi rejlik az Ózdi Atomérőmű katasztrófa hátterében. 
A felhasználó egy megadott sorrendben tudja feloldani a pályákat azok teljesitésével, viszont később visszatérhet bármelyik feloldott pályára. 
A pályák elkezdése előtt kiválaszthatja, hogy milyen felszerelést kiván magával vinni. 
Halál esetén csak a pályán megszerzett haladást vesztjük el. 
A felhasználónak lehetősége lesz jobbra és balra mozogni, emellett ugrani. 
A fegyver a kurzus felé fog mindig célozni. 
Lehetőség lesz rejtett tárgyak megszerzésére a pályákon, ezek különleges tulajdonságokkal fognak birni. 
A felhasználó mind távol, és közelharci fegyvert is használhat, a többi már csak azon múlik, hogy mit talál és mit választ. 


## Jelenlegi helyzet
A megrendelő kérése egy régi klasszikusokat idéző, 2D alapú platformer. Melyet egyedi ötletével szeretné megvalósítani. Eddigi játékok során nem találkozott még olyannal, melyben egy felrobbant atomerőművet kell elhagyni és ezzel a különös ötlettel keresett meg minket. Mely szerinte betölti ezt a "piaci rést". Ezzel az újító ötlettel szeretne piaci és anyagi előnyökhöz jutni. A játékot a legnagyobb játékosközösség miatt, és így legtöbb profit miatt PC re kell fejleszteni.

## Vágyálom rendszer
Egy olyan unity alapú játékot szeretnénk készíteni, amely visszahozza számunkra a régi platformer játékok nagyszerű hangulatát, saját megvalósításunkkal egy posztapokaliptikus világban, ahol az
Ózdi Atomerőműben történt szerencsétlenségek után játszódik a történet. Főhősünk a katasztrófa egyik túlélője, akinek meg kell találnia a módját a túlélésre.
A program egyjátékos módban fog futni, esetleg később bővíthető lesz többjátékos móddal is.
A program telepítését követően, regisztráció nélkül lehetőségünk nyílik a játék megkezdésére.
A játék harcrendszere nagyon változatos, közelharci és távolsági egyaránt, ugyanis szeretnénk több kis hatótávalságú és több nagy hatótávolságú fegyvert is
implementálni a játékba, amelyeket a felhasználó majd a kalandjai során, a pályákon végighaladva oldhat, néhány fegyver megszerzése viszont szerencsét kíván.
A kezdő fegyver egy kezdő pisztoly és egy kezdő bunkós bot lesz majd a karakternek.
A felhasználó célja, pedig a pályákon való végighaladás lesz, hogy kiderítse, mi is rejlik valójában az atomerőmű katasztrófája hátterében.
A pályák előtt kiválaszthatjuk, hogy a karakterünk milyen felszerelést hozzon magával legközelebb.
Halál esetén nem kell újból kezdeni az egész játékot, ilyenkor csupán az adott pályát kell előről kezdenünk.

## Funkcionális követelmények

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
- Ha meghal a karakter, az külön animációt kap

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


## Rendszerre vonatkozó törvények, szabványok, ajánlás
### Rendszerszabványok:

#### Kommunikáció és feladatkövetés
- Trello
- Discord
- Messenger

#### Verziókövetés
- Git
- Github
- Github Desktop
- Gitkraken

#### Kódszerkesztők
- Sublime text
- Visual studio code
- Atom
- Notepad++

#### Nyelvek és könyvtárak
- C#
- UnityEngine

## Jelenlegi üzleti folyamatok modellje
Jelenleg a játékipar, más irányú játékok felé orientálódik. Ezért ezek más fajtájú, és más hangulatú játékok. Így ez a hiánypótló új ötlet régi köntösben rengeteg új játékost és profitot teremthet.

## Igényelt üzleti folyamatok
A játékokkal kapcsolatos elvárások és igények kielégítésére az ügyfél ötlete tökéletesen alkalmas.
Egyre népszerűbbé válnak a pixelArt platformer játékok napjainkban, a növekvő nosztalgiafaktor miatt.
Az igény továbbra is a jelenlegi üzleti folyamatokhoz kapcsolódik: hosszan tartó játékélmény, kihívással párosítva.

## Követelménylista

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

## Riportok
- Kivitelező: Kérem, mondja el mit szeretne!
- Megrendelő: A játékokat forgalmazó cégem számára szeretnék egy játékot.
- Kivitelező: Milyen típusú játékot szeretne?
- Megrendelő: Egy 2D platformer játékot álmodtam meg, aminek a legfőbb témája az akció.
- Kivitelező: Részletekbe merülően ki tudná fejteni az elképzeléseit?
- Megrendelő: Hogyne, a játék története az lenne, hogy az ózdi atomerőmú megsemmisül és egy apokaliptikus környezetben mutánsokat és egyéb ellenségekre lehet lövöldözni, illetve a cél a mutáció ellenszerének a felfedezése lenne.
- Kivitelező: És hogyan képzeli el a játékmenetet?
- Megrendelő: Különböző pályákon kell küldetéseket teljesíteni és mindegyik pálya végén van egy boss, ami az ellenszerhez ad alkotóelemet.
- Kivitekező: És milyen egyéb funkciókat képzel el az applikáció megjelenítését illetően?
- Megrendelő: A beállítások menüpontban a gombokat jelenítse meg grafikusan a felület, illetve a menü egyéb funkcióinak a színhatása legyen egységes, valamiféle apokaliptkus hangultaot tükröző.
- Kivitelező: Rendben. Egyéb kérés a játékfejlesztés menetével kapcsolatban?
- Megrendelő: Azt szeretném, ha a cégük az eddigi játékfejlesztésből eredő tapasztalatainak a legjobbjait használná fel az applikáció elkészítése során.
- Kivitelező: Rendben, a legjobb tudásunk szerint fogunk cselekedni.

## Fogalomtár
-PC: Personal Computer
-2D: 2 dimenziós játék
-Platformer: A platformjáték egy videójáték-műfaj, az akciójáték alműfaja. A játékos által irányított karakternek platformokon keresztül kell ugrálnia és/vagy különböző akadályokat kell átugrania. A játékos feladata, hogy a karakterével megfelelő időben ugorjon, hogy tovább tudjon menni vagy ne essen le.

	
