<!--
author:   3M+L

email:    your@mail.org

version:  0.0.1

language: en

narrator: US English Male


translation: Português  translations/Portuguese.md

translation: Deutsch translations/German.md

import: https://raw.githubusercontent.com/liaTemplates/algebrite/master/README.md

import: https://raw.githubusercontent.com/liaTemplates/rextester/master/README.md
-->

# C# Questions

**Git and GitHub**

**1. Der Befehl `git pull` realisiert zwei Schritte:**

    [( )] `git branch` und `git merge`
    [(X)] `git fetch` und `git merge`
    [[?]] Der kombinierte Befehl bezieht sich auf die Interaktion mit dem Remote-Repository und dessen ggf. vor dem aktuellen lokalen Repository liegenden Versionen.
    ***********************************************************************

                                    {{1}}
    Mit `git pull` werden die aktuellen Änderungen des Branches, die auf dem Remote-Repository
    liegen abgerufen und in das lokale Repository mit `git merge` übernommen.

    ***********************************************************************

**2. Exklusives Bearbeiten (Sequentialisierung): Kreuze in der richtigen Reihenfolge an!**

    [[1.] [2.] [3.]]
    [( )  (X)  ( ) ]       Modify
    [(X)  ( )  ( ) ]       Lock
    [( )  ( )  (X) ]       Unlock
    ***********************************************************************

    Bei der Sequentialisierung handelt es sich um die pessimistische Versionsverwaltung, bei der einzelne Dateien vor einer Änderung durch den Benutzer gesperrt und nach Abschluss selbiger wieder freigegeben werden.

    ***********************************************************************


**3. Kollaboratives Arbeiten mit Mischen: Kreuze in der richtigen Reihenfolge an!**

    [[1.] [2.] [3.]]
    [(X)  ( )  ( ) ]       Copy
    [( )  ( )  (X) ]       Merge
    [( )  (X)  ( ) ]       Modify
    ***********************************************************************

    Hierbei handelt es sich um die optimistische Versionsverwaltung, bei der gleichzeitige Änderungen durch mehrere Benutzer an einer Datei möglich sind, da diese Änderungen anschließend automatisch oder manuell zusammengeführt werde (*Merge*).

    ***********************************************************************


**4. Vervollständige die Definition:**

    Ein Paar von Änderung aus Dokument 1 bzw. Dokument 2 gegenüber einem Ausgangsdokument kann unverträglich sein, wenn die Abbildung beider Änderungen in einem gemeinsamen Dokument nicht möglich ist. In diesem Fall spricht man von...

    [( )] einer Versionsdoppelung
    [( )] einem Repository-Fehler
    [(X)] einem Konflikt
    ***********************************************************************

    Im Falle eines Konflikts muss eine der betroffenen Änderungen weggelassen werden. Welche das sein soll kann anhand von *Interaktivem* oder *Nicht-interaktivem Mischen* entschieden werden.

    ***********************************************************************


**5. Wobei wird ein Entwickler unmittelbar in den Mischprozess eingebunden?**

    [(X)] Interaktives Mischen
    [( )] Nicht-interaktives Mischen
    [[?]] Was bedeutet das Wort *interaktiv*?
    [[?]] *Interaktion* = Wechselbeziehung zwischen Handlungspartnern
    ***********************************************************************

    Denkbare Entscheidungen für die Lösung eines Konflikts durch *Interaktives Mischen* wären die Übernahme einer der Änderungen, keiner Änderung oder die Übernahme einer modifizierten Änderung

    ***********************************************************************

**6. Kreuze die zugehörige Definition an!**

    [[2-Wege-Mischen] [3-Wege-Mischen]]
    [       ( )              (X)      ]       Mischen von Dokumenten gemeinsamen Ursprungs
    [       (X)              ( )      ]       Mischen unabhängiger Dokumente
    [[?]] Beim 2-Wege-Mischen ist die Erzeugung eines neuen Dokuments das Ziel, während beim 3-Wege-Mischen eine weiterentwickelte Version des ursprünglichen Dokuments entstehen soll. Übertrage dieses Wissen auf die Ausgangsdokumente um die richtigen Definitionen zuordnen zu können.
    ***********************************************************************

    Beim *2-Wege-Mischen* werden die gemeinsamen Komponenten und die individuellen Teilmengen voneinander unabhängiger Dokumente vereint.
    Beim *3-Wege-Mischen* werden (möglichst) alle Änderungen am Ursprungsdokument in eine weiterentwickelte Version des selbigen integriert.

    ***********************************************************************


**7. Welche Form der Versionsverwaltung findet noch heute in manchen Büroanwendungen (bspw. *Word*) Verwendung?**

    [( )] Verteilte Versionsverwaltung
    [( )] Zentrale Versionsverwaltung
    [(X)] Lokale Versionsverwaltung
    [[?]] Die genannten Anwendungen speichern die Versionen eines Dokuments in der Datei des Dokuments selbst - dabei handelt es sich um eine `?` Speicherung.

**C# Concepts**

**1. Welches Programmierparadigma findet bei folgendem Codefragment Anwendung:**

```python
print("Berechne die Summe von Zahlenreihen")
max_value = 10
sum = 0
for i in range(0, max_value + 1):
    sum += i
    print("{:>2d}".format(i) + "{:>5d}".format(sum))
```
@Rextester.eval(@Python)

    [(X)] Imperative Programmierung
    [( )] Logische Programmierung
    [( )] Objektorientierte Programmierung
    [[?]] Wohl in der Vorlesung nicht aufgepasst? :-)


**2. Welches Programmierparadigma findet man in folgendem Codefragment:**

```python
def mapArr(arr, func):
    return [func(elem) for elem in arr]

print("Berechne die Quadratzahl von jeder Zahl in der Liste")
arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
arr_squared = mapArr(arr, lambda x: x**2)
print(arr_squared)
```
@Rextester.eval(@Python)

    [( )] Objektorientierte Programmierung
    [( )] Prozedurale Programmierung
    [(X)] Funktionale Programmierung
    [[?]] Google mal Haskell :-D


**3. Das .NET Framework beinhaltet nicht nur Common Language Runtime (CLR) sondern auch die Entwicklungswerkzeuge und Klassenbibliotheken.**

    [[falsch|(richtig)]]

**4. Die Ausgabe aus einem C#-Programm ist unter anderem mit der folgenden Anweisung möglich:**

    [( )] System.out.print();
    [( )] print();
    [(X)] System.Console.WriteLine();
    [( )] printf();

**5. Im Ergebnis des Compilierens eines C#-Programms entsteht**

    [( )] ein Namespace
    [(X)] ein Assembly
    [( )] eine ausführbare Methode
    [( )] eine ausführbare Klasse

**6. Bei Console.WriteLine() sind Console und WriteLine**

    [( )] Namespace und Member
    [(X)] Klasse und Methode
    [( )] Assembly und Klasse

**Element**

**1. Warum macht es Sinn Schlüsselwörter der Sprache C\# als Variablennamen zu nutzen? Wie kann das realisiert werden**

    [(X)] vorangestelltes "@"
    [( )] Unterstriche vor dem Namen
    [[?]] ... , um Variablennamen, die in C# Schlüsselworte sind, aber in Assemblies enthalten sind, die mit anderen Programmiersprachen erzeugt wurden, abzudecken


**2. Das erste Zeichen eines Variablennamens in C\# kann sein:**

    [(X)] `_`
    [(X)] Buchstabe
    [( )] Zahl
    [( )] `§`
    [( )] `#`
    [( )] `*`
    [[?]] genau 2 Antworten sind richtig.

**3. Division durch Null ist nicht möglich und erzeugt immer einen Fehler!**

[( )] true
[(X)] false

**4. Welcher Schreibstil ist in C\# zu bevorzugen?**

[( )] `this_way_of_typing`
[(X)] `ThisWayOfTyping`
[[?]] Results indicate that *camel casing* leads to higher accuracy among all subjects regardless of training, and those trained in camel casing are able to recognize identifiers in the camel case style faster than identifiers in the underscore style.

**5. Was sagt die Anzahl an Schlüsselwörtern über eine Programmiersprache aus? Hat C\# mehr Schlüsselwörter als C?**

[(X)] C# $>$ C
[( )] C $>$ C#

**6. Die Datentypen werden in C\# in zwei grundsätzlichen Kategorien zusammengefasst. Die erste Gruppe umfasst - Structs , Ints, Characters, die zweit Klassen, Arrays, Delegates. Benennen Sie die Oberbegriffe:**

[[Werttypen]]
[[Referenztypen]]
