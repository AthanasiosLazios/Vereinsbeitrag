# Vereinsbeitrags-Rechner (C#)

Dieses Konsolenprogramm berechnet den Mitgliedsbeitrag für einen Verein auf Basis des Alters und der Erwerbstätigkeit.  
Das Projekt dient dazu, die Grundlagen der Programmierung mit C# zu vertiefen.

---

## Funktionen

- Abfrage des Alters
- Beitragsberechnung abhängig von Altersgruppen
- Zusätzliche Abfrage der Erwerbstätigkeit bei Erwachsenen zwischen 18-65 Jahren
- Eingabevalidierung für „j“ und „n“
- Ausgabe des richtigen Beitrags basierend auf allen Eingaben

---

## Beitragslogik

| Altersgruppe          | Beitrag              |
|----------------------|----------------------|
| bis 6 Jahre          | frei                 |
| 7–17 Jahre           | 30 Euro              |
| 18–65 Jahre, erwerbstätig | 80 Euro      |
| 18–65 Jahre, nicht erwerbstätig | 40 Euro |
| über 65 Jahre        | 50 Euro              |

---

## Beispielablauf

```
Berechnen Sie Ihren Vereinsbeitrag.
Wie alt sind Sie?
> 32
Sind Sie erwerbstätig? (j/n)
> j
Beitrag: 80 Euro
```

---

## Technologien

- C#
- .NET 9.0
- Visual Studio 2022

---

## Zweck

Dieses Projekt übt:

- Bedingungen (`if`, `else if`, `else`)
- Eingabevalidierung über Schleifen
- sinnvolle Programmstruktur
- einfache Entscheidungslogik

---

## Status

Das Programm ist funktionsfähig und kann später um weitere Kriterien erweitert werden.
