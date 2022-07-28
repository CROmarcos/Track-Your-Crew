# Track-Your-Crew
Aplikacija za popis satnice zaposlenih studenata

### Upute za pokretanje
Budući da connection string vodi na lokalnu putanju, prilikom skidanja repozitorija potrebno je ažurirati .edmx model odabirom opcije "Update Model from Database" na način da se odabere novi connection string te se iz direktorija Baza podataka odabire datoteka RadniSati.mdf.

### Korisničke uloge
Direktor ima sve ovlasti, uključujući i brisanje studenata iz baze studenata, pri čemu se mogu obrisati samo oni studenti koji nemaju niti jedan isplaćen ugovor. Projektni menadžer nema mogućnost brisanja studenata, ali može podnositi i otkazivati otvorene ugovore. Zaposlenik je uloga s kojom se prijavljuju svi ostali zaposlenici organizacije koja koristi aplikaciju, može dodavati nove studente i radna mjesta te otvarati ugovore, ali ih ne može isplaćivati niti otkazivati. Grafički prikaz mogu vidjeti sve tri uloge.

### Lozinke za testiranje
Direktor: "direktor"<br>
Projektni menadžer: "menadzer123"<br>
Zaposlenik: "lozinka"
