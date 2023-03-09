## ⚪ Úkol
### Praktická část
Vytvořte aplikaci, která zachytí inventář z hry RPG.
Do inventáře bude možné vložit různé typy položek, které mají různé vlastnosti.
Např. Jídlo se časem zkazí, zbraně se opotřebovávají z boje atd.
Inventář bude schopen procházet jeho obsah bez přímého
Přístup k interní sbírce, ve kterém budou položky uloženy.
Vytvořte také aplikaci služby, ve které bude
je možné ověřit provoz přiřazení.

### Písemná část
V písemné části analyzujte principy a možnosti dědičnosti, implementace rozhraní, přepsání metody a obecnost.

## ⚪ provedení praktické části
### Funkce inventáře
- Převíjí dny, které kazí věci v inventáři
- počítá hmotnost zásob
- Přidání nových položek pomocí tažení z nekonečného zdroje

Jak hra vypadá

<img src = "https://cdn.discordapp.com/attachments/967125309184950343/1083391940395008130/image.png" width = "500px">


Schéma dědičnosti třídy, které inventář používá

<img src = "https://cdn.discordapp.com/attachments/967125309184950343/1083388418916106360/image.png" width = "500px">

## ⚪ provedení písemné části
### Dědičnost třídy

<b> princip </b> <br/>
   - Princip dědičnosti třídy - datový typ může zdědit současně prodloužit nebo změnit vlastnosti (data a funkčnost) některého existujícího typu.

<b> se používají </b> <br/>
   - Dědičnost třídy používaná k minimalizaci kódu pomocí již existujícího kódu a
strukturování komponent softwaru pro snazší orientaci v programovém kódu.


### Rozhraní
<b> princip </b> <br/>
   - Princip rozhraní - typ, který může definovat funkčnost (metody
a vlastnosti) bez implementace, použít a implementovat ji do více
třídy a struktury. Třídy a struktury mají také schopnost zdědit
Neomezený počet rozhraní (na rozdíl od dědičnosti třídy).

<b> se používají </b> <br/>
   - Rozhraní se používá pro zjednodušené vytváření tříd a struktur s
rozsáhlá funkčnost, strukturování softwarových komponent pro snadnější orientaci
v programovém kódu.

### Přepsání metody

<b> princip </b> <br/>
   - Princip překrývání metod - Metoda přepsání poskytuje novou implementaci metody zděděné ze základní třídy.

<b> se používají </b> <br/>
   - překrývání metod - umožňující odvozenou třídu poskytnout konkrétní implementaci metody již implementované v základní třídě.


### Generic Class
<b> princip </b> <br/>
   - Princip of generic class - třída schopná plnit stejnou funkčnost pro různé typy dat.

<b> se používají </b> <br/>
   - Obecné generic classrd se používají ve většině případů, když je nutné vytvořit kolekce, která je pro typ obsažených dat flexibilní.