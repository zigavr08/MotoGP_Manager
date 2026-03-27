## MotoGP Manager - Seminarska naloga
## Avtor: Žiga Vračun

## 1. Opis projekta
MotoGP Manager je namizna C# aplikacija (Windows Forms), namenjena beleženju in upravljanju podatkov o dirkačih in njihovih motorjih. Projekt je nastal kot seminarska naloga, katere glavni cilj je bil prikaz praktičnega znanja v objektnem programiranju (predmetu OPR).

V kodi so implementirani naslednji koncepti:
 - **Kapsulacija:** Varen dostop do privatnih polj preko get/set z vgrajenim preverjanjem (npr. omejitev moči motorja).
 - **Konstruktorji in destruktorji:** Nastavitev začetnih vrednosti ob kreiranju in ažuriranje števca ob brisanju objekta.
 - **Lastnosti:** Enostavno branje in pisanje podatkov (Ime, Starost, Ekipa).
 - **Statične in objektne metode:** Objektne (npr. PraznujZmago()) za posameznega voznika in statične za logiko razreda.
 - **Static, const, readonly:** Uporabljeno za števec voznikov (static), maksimalno hitrost (const) in številko motorja (readonly).
 - **Preoblaganje operatorjev:** Uporaba > in < za hitro primerjavo dveh voznikov glede na zbrane točke.
 - **Dedovanje:** Razreda MotoGP_Voznik in MladiVoznik podedujeta osnovne atribute od razreda Voznik.
 - **Lastne knjižnice:** Celotna poslovna logika je ločena v svojo knjižnico (MotoGPLibrary).
 - **Polimorfizem:** Mladoletni vozniki preglasijo (override) metodo PraznujZmago(), da pijejo otroški šampanjec.
 - **Abstraktni razredi:** Osnovni razred Voznik določa strukturo, a ga ne moremo direktno instancirati.
 - **Vmesniki (Interfaces):** ITekmovalec predpisuje obvezno implementacijo Imena in Priimka.
 - **Indekserji:** Dostop do podatkov preko string ključa (npr. voznik["ime"]) za hiter izpis osebnega kartona.
 - **Delegati in dogodki (Events):** Sistem preko dogodka obvesti uporabnika (MessageBox), ko voznik dobi nove točke.
---
## 2. Izgled namizne aplikacije
<img width="944" height="543" alt="image" src="https://github.com/user-attachments/assets/baf97428-a797-487d-9802-203847e1009d" />

---
## 3. Navodila za nameščanje in poganjanje
Projekt je zgrajen tako, da za delovanje ne potrebuje nobenih zunanjih baz podatkov ali dodatnih knjižnic.

1. Klonirajte ta repozitorij na svoj lokalni računalnik (ali prenesite ZIP):
   `git clone [TUKAJ_VNESI_SVOJ_GITHUB_LINK]`
2. Odprite mapo s projektom in dvokliknite na datoteko rešitve (`.sln`), da jo odprete v okolju **Visual Studio**.
3. Pritisnite tipko **F5** (ali gumb Start v orodni vrstici), da prevedete in zaženete aplikacijo.

---

## 4. Navodila za uporabo
Aplikacija deluje preko grafičnega vmesnika, kjer se vsi vneseni podatki dinamično prikazujejo v osrednji tabeli.
<p align="center">
<img width="400" height="auto" alt="image" src="https://github.com/user-attachments/assets/665ec898-6817-4f17-b5d1-86b5f98c6734" />
</p>

- **Vnos novega voznika:** V zgornjem delu izpolnite vsa polja (ime, priimek, starost in podatki o motorju). Če vnesete starost pod 18 let, bo sistem voznika samodejno obravnaval kot mladoletnega. S klikom na gumb "Dodaj" se voznik shrani v tabelo.
<p align="center">
<img width="400" height="auto" alt="image" src="https://github.com/user-attachments/assets/aad0b032-a039-47f1-9eb6-b6afd7bd35f3" />
</p>

- **Števec voznikov:** Na vrhu aplikacije se ves čas samodejno osvežuje in izpisuje trenutno število vseh vnesenih dirkačev.

- **Osebni karton:** Za hiter pregled podrobnosti z miško dvokliknite (DoubleClick) na poljubno vrstico z voznikom v tabeli. Odprlo se bo novo okno z njegovimi ključnimi podatki.
<p align="center">
<img width="227" height="201" alt="image" src="https://github.com/user-attachments/assets/668901f4-cb50-4810-bbd5-67692f28f522" />
</p>

- **Dodajanje točk:** Označite voznika v tabeli in kliknite gumb "Dodaj točke (25)" za točke. V ozadju se sproži dogodek, ki na zaslon izpiše obvestilo in se osveži.

- **Primerjava voznikov:** Ko imate v tabeli vsaj dva voznika, kliknite gumb "Primerjaj". Program bo preveril kateri dirkač ima več točk in izpisal zmagovalca.
 
- **Brisanje:** Z gumboma "Odstrani dirkača" ali "Počisti tabelo" lahko varno odstranite posamezne vnose ali celoten seznam (števec voznikov se pri tem ustrezno posodablja).
