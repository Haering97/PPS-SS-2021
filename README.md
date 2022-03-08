# PPS-SS-2020


# Exposé

## 1 Problemfeld & Kontext

Aufgrund der steigenden Bevölkerungszahlen [UN DESA (Population Division), 2019: 6], steigt der weltweite Nahrungsbedarf und das kann auf dem begrenzten Platz der Erde zu Hungersnöten führen.
Landwirtschaft 4.0 könnte eine Möglichkeit sein, dieses Problem zu bewältigen, es bedeutet, dass Landwirte anfangen ihre Produktionsprozesse zu digitalisieren um damit eine Kosteneinsparung bzw. Ertragssteigerung zu erzielen, ähnlich der Industrie 4.0. Diese Digitalisierung strebt eine Automatisierung vieler landwirtschaftlicher Prozesse an, jedoch werden 2021 erst vereinzelt Ansätze durchgeführt und erforscht und es werden Zwischenlösungen gebraucht um auch heute schon mithilfe der gewonnenen Daten die Effizienz zu steigern. 
Außerdem ist Augmented Reality(im Folgenden abgekürzt als AR), 2021 ein Markt der jedes Jahr weiter wächst und bei dem sich immer neue Anwendungsgebiete finden lassen.[ARtillery Intelligence zitiert nach de.statista.com 2020: 7]


<img src="https://github.com/Haering97/PPS-SS-2021/blob/main/ReadMe%20Assets/artilleryStat.png" alt="Mobile AR market revenue worldwide 2019-2024,[Quelle 1]" width="600"/>


Augmented Reality beschreibt die computergestützte Erweiterung der Realitätswahrnehmung, jedoch sind die Preise der aktuellen Endgeräte, in Form von Head Mounted Displays(im Folgenden abgekürzt als HMD) noch sehr hoch. [Bank of America; Merrill Lynch zitiert nach de.statista.com 2016: 9]

## 2 Ziel

Ziel ist es nun die anhand der digitalisierten Landwirtschaft erhaltenen Daten wie, Bodenfeuchtigkeit, Temperatur, Luftfeuchtigkeit, mithilfe von Augmented Reality zu visualisieren. Elementar ist, dass die Darstellung in Anzahl und Größe skalierbar bleibt damit das System auch für größere landwirtschaftliche Betriebe nutzbar ist.
In dem geschaut wird, ob die Technologie auch ohne HMD, sondern mit Smartphone- bzw. Tabletapps sinnvoll nutzbar ist, wird versucht den Übergang zu Landwirtschaft 4.0 zu unterstützen und voranzutreiben.

## 3 Fragestellung

Lassen sich Sensordaten mithilfe von AR auf mobilen Endgeräten effizienter darstellen als mit herkömmlichen Darstellungsmöglichkeiten wie 2-Dimensionalen Benutzeroberflächen?

## 4 Ressourcen

Neben Apple hat auch Google zum Thema Augmented Reality ein eigenes Enwicklungstoolkit erstellt. Apples ARKit und Googles ARCore. Im Rahmen dieses Projektes werde ich mich aller Voraussicht nach, aufgrund meines Android Smartphones und der günstigeren Entwicklungsmöglichkeiten, dazu entscheiden mit ARCore zu arbeiten.
Das Projekt wird mithilfe der Laufzeit- und Entwicklungsumgebung Unity umgesetzt, denn diese bietet mithilfe der eigenen AR-Foundation ein gutes Framework, um mit ARCore eine Android-App zu entwickeln.

## 5 Motivation & Bezug zur Medieninformatik

Größtenteils kommt die Motivation für das Thema Augmented Reality aus eigenem Interesse, jedoch auch, weil AR in seinen Möglichkeiten 2021 noch lange nicht ausgeschöpft ist und erwartet wird, dass es in Zukunft immer mehr Einfluss auf unser Leben haben wird.

Medieninformatiker eignen sich besonders gut zur Analyse dieses Problems, da sie nicht nur allgemeine Kenntnisse über Algorithmen und Programmierung besitzen, sondern auch weil Grundkenntnisse in Mensch-Computer-Interaktion und Datenhaltung Teil des Sachverstandes sind. Medieninformatiker sind auch mit der Funktionsweise verschiedener Endgeräte vertraut. Diese Wissensbereiche sind eine gute Grundlage für die Erfüllung der verschiedenen Aufgaben, die sich bei der Konzeption und Analyse ergeben.

## 6 Arbeitsergebnis

Als Ergebnis des Praxisprojektes soll ein Prototyp in Form einer nativen Android-App entstehen, diese soll mithilfe von AR landwirtschaftliche Sensordaten visualisieren. Ohne den Einsatz von AR wären entweder eine Vielzahl von einzelnen Displays oder eine komplizierte Darstellungsform nötig um große Mengen an Sensordaten zu visualisieren. Genau hier soll Abhilfe geschaffen werden und mithilfe der App für jede Pflanze einzeln die Daten im 3-Dimensionalen Raum in Nähe der zugehörigen Pflanze visualisiert werden. Dies geschieht mithilfe von speziellen Markern, welche in der echten Welt bei einzelnen Pflanzen platziert werden, um eine Zuordnung zu schaffen und um dem System einen örtlichen Anhaltspunkt zu geben. Damit fungieren sie als virtueller Anker und ermöglichen eine präzise Positionierung virtueller Inhalte in der realen Welt.

## Literaturverzeichnis

ARtillery Intelligence (2020): Mobile AR market revenue worldwide 2019-2024, zitiert nach de.statista.com, (online) 
<https://www.statista.com/statistics/282453/mobile-augmented-reality-market-size> [18.05.2021]
    
    
Bank of America; Merrill Lynch (2016): AR Average selling price (ASP) of augmented reality (AR) standalone head-mounted displays (HMD) from 2015 to 2020, zitiert nach de.statista.com, (online)
<https://www.statista.com/statistics/682817/ar-standalone-hmd-average-selling-price> [13.05.2021]
    
    
UN DESA (Population Division) (2019): World Population Prospects: the 2019 Revision, zitiert nach de.statista.com, (online)
<https://de.statista.com/statistik/daten/studie/1717/umfrage/prognose-zur-entwicklung-der-weltbevoelkerung>[13.05.2021]
