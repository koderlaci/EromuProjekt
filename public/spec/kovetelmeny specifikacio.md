

# Követelmény specifikáció

##  Áttekintés


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

### Karakter irányítása
- Jobbra, balra lehet mozogni
- Ugrás és kúszás megvalósítása
- Egérrel irányítható a lövedék iránya
- Speciális képesség (pl. gránát eldobása)

### Harcrendszer
- Közelharci és lőfegyverekkel zajlik
- Az alapvető fegyverek: kés és pisztoly
- Speciális képességek különleges fegyvereket adnak
- Ha 0-ra esik a HP-ja egy karakternek, meghal

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


## Jelenlegi üzleti folyamatok modellje
Jelenleg a játékipar, más irányú játékok felé orientálódik. Ezért ezek más fajtájú, és más hangulatú játékok. Így ez a hiánypótló új ötlet régi köntösben rengeteg új játékost és profitot teremthet.

## Igényelt üzleti folyamatok


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


## Fogalomtár
-PC: Personal Computer
-2D: 2 dimenziós játék
-Platformer: A platformjáték egy videójáték-műfaj, az akciójáték alműfaja. A játékos által irányított karakternek platformokon keresztül kell ugrálnia és/vagy különböző akadályokat kell átugrania. A játékos feladata, hogy a karakterével megfelelő időben ugorjon, hogy tovább tudjon menni vagy ne essen le.

	
