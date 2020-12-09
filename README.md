# IRF_Project
A beadandó során a következő tételeket kaptam:
1)	B feladat (Adatbázis létrehozása, kapcsolódás és legalább egy tábla adatainak beolvasása)
2)	D feladat (Unit Test megvalósítása egy nem referencia típusú visszatérési értékkel)
3)	C feladat (Diagramm rajzolás + kapcsolódó adatok megjelenítése)
4)	A feladat (Véletlenszám generálás és felhasználás)

A beadandó feladat során egy autókölcsönzőt szeretnék megvalósítani különböző funkciókkal. Terveim szerint a program elindítása után a felhasználónak két lehetőség közül kell választani: „dolgozó vagyok” vagy „ügyfél vagyok”. Ennek kiválasztása után más-más felületek nyílnának meg. Az ügyfelek csak új foglalást fognak tudni leadni, míg a dolgozóknak több lehetősége lesz. Új foglalást mind az ügyfél, mind pedig a dolgozó is létrehozhat. Itt a név, a telefonszám és a születési dátum megadása után lehet új foglalást létrehozni. A dolgozók számára adott lesz a lehetőség, hogy az egyes autókhoz esetlegesen különböző sérüléseket tudjon felvinni, ezek mellett még lehetőségük lesz foglalást törölni. 

Az adatbázisom az alábbi táblákból fog felépülni:

1.	Ügyfelek tábla (Ügyfelek adatait tárolom benne)
2.	Foglalások tábla (Ügyfelek által leadott foglalások adatait tárolom benne)
3.	Gépjármű tábla (különböző gépjárművek adatait tárolom benne)
4.	TípusÁr tábla (Adott típusú autókhoz tartózó bérleti díj)
5.	Sérülések tábla (Különböző autók sérüléseit tárolom benne)

Az Unit Tesztet során egy telefonszámokat ellenőrző tesztet valósítok meg. Ennek azért van nagy jelentősége, mert új ügyfelek bármikor regisztrálhatnak a rendszerbe. Ekkor pedig kötelező megadniuk a telefonszámukat. Itt nagyon fontos, hogy még véletlenül se adjanak meg invalid telefonszámot.

A harmadik feladat C részét úgy valósítanám meg, hogy egy diagrammon ábrázolom egy adott év (jelen esetben a 2020-as év) foglalásait. Ezt úgy valósítanám meg, hogy a foglalások kezdetét ábrázolnám a diagrammon úgy, hogy egy LINQ lekérdezésben csoportosítom a hónapok szerint a különböző foglalásokat.

 A 4. feladat A részét úgy implementálnám a projektembe, hogy bizonyos ügyfeleknek (azoknak, akiknek legalább 5 foglalása volt már a rendszerünkben) lehetősége lenne arra, hogy egy nyereményjátékban részt vegyenek. Ezen nyereményjáték úgy működne, hogy egy random számot sorsolnék ki az ügyfeleknek 0-20 között. Amennyiben az ügyfél olyan számot kap, amilyen sorszámú autónk van, akkor az ügyfél az adott sorszámú autót kibérelheti 1 napra ingyenesen. 
