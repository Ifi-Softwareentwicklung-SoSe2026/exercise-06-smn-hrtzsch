<!--

author:   Volker Göhler
email:    volker.goehler@informatik.tu-freiberg.de
version:  0.0.1
language: de
narrator: Deutsch Female

edit: true
date: 2026-06-19

comment:  Übung Softwareentwicklung 06 -- Template

import: https://raw.githubusercontent.com/liascript-templates/plantUML/master/README.md

link:   https://raw.githubusercontent.com/vgoehler/LiaScript_CSS_Provider/refs/heads/main/dist/university.css

tags: [Sommersemester2026, Softwareentwicklung, Übung06]

-->

[![LiaScript Course](https://raw.githubusercontent.com/LiaScript/LiaScript/master/badges/course.svg)](https://liascript.github.io/course/?https://raw.githubusercontent.com/Ifi-Softwareentwicklung-SoSe2026/exercise-06-smn-hrtzsch/refs/heads/main/README.md)

# Aufgabe 06

Softwareentwicklung SoSe2026
============================

## Aufgabe

## **User Story: Digitale Flächenverwaltungsplattform für Bauvorhaben**

Als Bauamtsmitarbeiter möchte ich eine digitale Plattform zur Verwaltung von Bauflächen und Bauvorhaben nutzen, damit ich Bauanträge effizient bearbeiten, Flächen zuweisen und den Fortschritt von Bauprojekten nachverfolgen kann.

### **Akzeptanzkriterien**

1. **Grundlegende Flächenverwaltung**
====================

- Das System muss Grundstücke und Bauflächen verwalten können (Flurstücknummer („0015 00012 001/002“ (Flur 0015, Flurstück 00012, Teilfläche 001/002)), Größe, Lage, aktuelle Nutzung (Gewerbe, Landwirtschaft, Forst, Wohnnutzung, Brachfläche, ...), Bebaubarkeit (ja, nein, auflagen). Ein Grundstück kann mehrere Bauflächen enthalten.
- Jede Fläche muss mit Metadaten wie B-Plan-Nummer ("BP-2022-089 – Wohngebiet Leipzig-Nord"), Bodenrichtwert ($500 €/m^2$) und Eigentümer verknüpft sein.
- Flächen müssen als `frei`, `reserviert` oder `bebaut` markiert werden können.

2. **Bauvorhaben verwalten**
====================

- Das System muss Bauvorhaben anlegen und verknüpfen können mit:
  - Antragsteller (Name, Kontaktdaten, Firma)
  - Geplante Nutzung (Wohngebäude, Gewerbe, Infrastruktur)
  - Zeitplan (Beginn, Fertigstellung)
  - Status (Antrag eingereicht, genehmigt, abgelehnt, in Bearbeitung, abgeschlossen)
- Jedes Bauvorhaben muss einer oder mehreren Flächen zugeordnet werden können.

## Initialer Arbeitsablauf

Maria erstellt automatisch ein Assignment-Issue, sobald Ihr Repository durch GitHub Classroom angelegt wurde.

Bearbeiten Sie zuerst dieses Maria-Issue:

1. Erstellen Sie einen eigenen Branch.
2. Ändern Sie den LiaScript-Course-Link oben in dieser `README.md`, sodass er auf Ihr studentisches Repository zeigt.
3. Legen Sie ein leeres C#-Konsolenprojekt an:

   ```bash
   dotnet new console -n Baufflaechenverwaltung
   ```

4. Erstellen Sie eine Pull Request nach `main` und verknüpfen Sie diese mit dem Maria-Issue über `Closes #<Issue-Number>`.
5. Warten Sie auf die automatische Review von Lisa und arbeiten Sie Feedback auf demselben Branch ein.
6. Nach dem Merge erstellen Sie ein eigenes Issue für Kevin.

## Kevin aktivieren

Kevin wird in dieser Übung über ein Label aktiviert.

Erstellen Sie nach der vorbereitenden PR ein neues GitHub-Issue:

- Das Issue muss von Ihnen als Studierende formuliert werden.
- Das Issue muss das Label `kevin` erhalten.
- Das Issue soll Kevin konkret beauftragen, die User Story und Akzeptanzkriterien aus dieser `README.md` in C# umzusetzen.
- Kevin erstellt anschließend eine Pull Request nach `main`.

Kevin bearbeitet keine Issues von Maria oder Jürgen direkt. Sie müssen diese Anforderungen erst in ein eigenes, konkret formuliertes Kevin-Issue übersetzen.

## Lisa Review

Lisa reviewed Pull Requests automatisch.

- Für C#-Pull-Requests wartet Lisa auf den GitHub Actions Workflow `dotnet-build`.
- Die CI-Logs und die Konsolenausgabe werden in Lisas Review-Kontext einbezogen.
- Wenn Lisa Änderungen anfordert, arbeiten Sie oder Kevin das Feedback auf demselben Branch ein.
- Ein Merge nach `main` erfolgt erst nach positiver Review.

## Jürgen Issues und Triage

Nach Kevins erster Umsetzung erstellt Jürgen weitere Issues. Diese sind bewusst teilweise unscharf formuliert.

Ihre Aufgabe ist dann:

- Anforderungen aus Jürgens Issues verstehen und trennen.
- Issues mit passenden Labels kategorisieren.
- Priorität, Aufwand und Abhängigkeiten einschätzen.
- Bei Bedarf ein neues, konkretes Kevin-Issue erstellen und mit `kevin` labeln.
- Nicht alles muss sofort umgesetzt werden; begründen Sie, was zurückgestellt oder nicht bearbeitet wird.

## UML-Dokumentation

Falls im Verlauf der Jürgen-Issues ein UML-Klassendiagramm gefordert wird, ergänzen Sie es in diesem Abschnitt.

```text @plantUML
@startuml

@enduml
```
@plantUML.eval(png)

## Aufgabenmaterial

- [Agent-Workflow und interne Aufgabenstruktur](task.md)
