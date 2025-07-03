# C# QuizGame

Ein konsolenbasiertes, flexibles Quizspiel für Einsteiger und Fortgeschrittene in C#.  
Das Projekt demonstriert moderne C#-Konzepte wie Objektorientierung, Enums, Interfaces, Polymorphismus und das Strategy Pattern – und ist leicht erweiterbar.

---

## Features

- **Multiple Choice Quiz**  
  Fragen und Antwortmöglichkeiten werden aus einer JSON-Datei geladen.

- **Benutzerprofil**  
  Spieler geben ihren Namen ein und erhalten eine persönliche Begrüßung und Auswertung.

- **Highscore-System**  
  Die besten Ergebnisse werden in einer Datei gespeichert und nach jedem Spiel angezeigt.

- **Schwierigkeitsgrade**  
  Jede Frage hat eine Difficulty (`Easy`, `Medium`, `Hard`). Die Schwierigkeit beeinflusst die Punktevergabe.

- **Hinweise oder Joker**  
  Zu jeder Frage kann ein Tipp angezeigt werden. Die Nutzung eines Hinweises halbiert die maximal erreichbare Punktzahl.
  Spieler können pro Spiel einen Joker einsetzen, z.B. um eine falsche Antwort zu wiederholen oder Antwortmöglichkeiten zu reduzieren.

- **Flexible Punkteberechnung**  
  Das Bewertungssystem ist über Interfaces und verschiedene Strategien flexibel austauschbar (z.B. Standard, Schwierigkeit, Bonus-Modus).

- **Profi-Modus mit Timer**
  Spieler hat für jede Antwort nur 10 Sekunden oder weniger Zeit

- **Unterschiedliche Fragetypen**
  Mehrfachantworten möglich, Freitext, Ja/Nein Antworten

- **Support für mehrere UIs**
  Logik in eine Class-Library extrahieren und einen IRenderer einführen (Console, WinForms, WPF usw.)

---

## Projektstruktur

- **/Data/questions.json**  
  Enthält alle Quizfragen mit Antwortmöglichkeiten, Lösung, Schwierigkeitsgrad und Hinweis.

- **/Models/**  
  Enthält die Datenmodelle wie `User`, `QuizItem` und `HighScore`.

- **/Program.cs**  
  Hauptprogramm: Einlesen der Daten, Spiellogik, Highscore, Auswertung.

---

## Schrittweise Erweiterungsideen

1. **Start: Einfaches Multiple-Choice-Quiz**
   - Fragen und Antworten aus JSON
   - Punkte für richtige Antworten

2. **Benutzerprofil & Highscore**
   - Namen abfragen
   - Ergebnisse speichern und anzeigen

3. **Schwierigkeitsgrade**
   - Jede Frage bekommt eine Difficulty
   - Punktevergabe abhängig von Difficulty

4. **Hints & Joker**
   - Hinweise pro Frage anzeigen (auf Wunsch)
   - Nutzung halbiert die Punktzahl
   - Joker für einmalige Vorteile pro Spiel

5. **Flexible Punkteberechnung**
   - Verschiedene Bewertungssysteme via Strategy Pattern
   - Z.B. Bonus-Modus, „No Hint“-Modus, Zeitfaktor

6. **Weitere Fragetypen**
   - Wahr/Falsch, Freitext, Zuordnungsfragen (über Interface und Polymorphismus)

7. **Mehrspieler-Modus**
   - Abwechselnde Runden, Teamwertung

8. **Verbesserte Benutzerführung**
   - Menüsystem, Fragekategorien, Fortschrittsanzeige

9. **Externe Verwaltung der Highscores und Fragen**
   - Speicherung in Datenbank oder Cloud
   - Fragen-Editor für Trainer

---

## Ausprobieren

1. Repo klonen
2. Fragen im JSON-Format in `/Data/questions.json` anpassen oder erweitern
3. Projekt in Visual Studio oder VS Code öffnen
4. Build & Run

---

Viel Spaß beim Coden und Lernen!
