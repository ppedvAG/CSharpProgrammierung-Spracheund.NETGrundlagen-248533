# GIT COMMANDS

## Links

-   [Git Homepage](https://git-scm.com)
-   [GitHub Cheat Sheet](https://education.github.com/git-cheat-sheet-education.pdf)

## Configuration

| Befehl                                                        | Beschreibung                                       |
| ------------------------------------------------------------- | -------------------------------------------------- |
| `git config --global user.name "full name"`                   | Erfoderlich, da Name in Git History auftaucht      |
| `git config --global user.email "valid email"`                | Erfoderlich, da sie mit Verlauf verknüpft wird     |
| `git config --global core.autocrlf true`                      | Zeilenumbrüche für Windows (input für Linux/macOS) |
| `git config --global color.ui auto`                           | Farben in Befehlszeile verwenden                   |
| `git config --global alias.st "status --short"`               | Alias "st" für Status in einer Zeile               |
| `git config --global alias.lga "log --oneline --all --graph"` | Alias "lga" um Log Befehl über alle Branches       |
| `git config --global alias.unstage "reset HEAD --"`           | Alias "unstage" um Staging rückgängig zu machen    |

## Setup & Init

| Befehl            | Beschreibung                                   |
| ----------------- | ---------------------------------------------- |
| `git init`        | Neues Repository anlegen                       |
| `git clone [url]` | kopieren von einem Online-Repository am Anfang |

## Stage & Snapshot

| Befehl                                 | Beschreibung                                                     |
| -------------------------------------- | ---------------------------------------------------------------- |
| `git status [-s]`                      | Änderungen im Arbeitsverzeichnis anzeigen lassen                 |
| `git add .`                            | alle Änderungen rekursiv für ein Commit vorschlagen              |
| `git restore --staged .`               | alle Änderungen rekursiv für ein Commit zurück nehmen            |
| `git restore --source=HEAD~1 file.txt` | gelöschte Datei aus letztem Commit wiederherstellen              |
| `git commit -m "Lorum ipsum"`          | Änderungen in das lokale Repo commiten / eintragen               |
| `git commit -am "Lorum ipsum"`         | Add und Commit zusammen ausführen                                |
| `git commit --amend -m "Lorum ipsum"`  | Letzte Message ändern (**nur bei lokalen Commits empfohlen!**)   |
| `git commit --amend --no-edit`         | Änderungen zum letzten Commit hinzufügen und Message beibehalten |
| `git log`                              | Änderungsverlauf anzeigen                                        |
| `git log --graph --oneline --decorate` | Änderungsverlauf als knappe Aufschlüsselung darstellen           |

| Befehl           | Beschreibung                          |
| ---------------- | ------------------------------------- |
| `git stash`      | Änderungen zwischenspeichern          |
| `git stash list` | Stash auflisten                       |
| `git stash pop`  | Änderungen wiederherstellen           |
| `git stash drop` | Letzte Änderungen vom Stash verwerfen |

## Share & Update

| Befehl                         | Beschreibung                                                       |
| ------------------------------ | ------------------------------------------------------------------ |
| `git remote add [alias] [url]` | Git URL als alias hinzufügen                                       |
| `git fetch [alias]`            | Informationen aller Branchen von Remote synchronisieren            |
| `git merge [alias]/[branch]`   | Änderungen von Remote zusammenführen (kann **Konflikte** auslösen) |
| `git push [alias] [branch]`    | eigene lokale Repo-Version hochladen                               |
| `git pull`                     | fetch und merge vom aktuellen remote branch                        |

## Aufräumen

| Befehl                    | Beschreibung                                                              |
| ------------------------- | ------------------------------------------------------------------------- |
| `git ls-files`            | Alle Dateien anzeigen welche getracked werden                             |
| `git rm --cached -r bin/` | bin Directory aus Tracking entfernen (nicht physisch)                     |
| `git clean -df`           | Ohne Nachfrage unversionierte Dateien löschen (praktisch für Builds etc.) |
