"# RSS_Feed_Reader" 

# RSS Feed Reader by ElevenSpins <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Feed-icon.svg/256px-Feed-icon.svg.png" width="30">


## Funktion

Das Projekt "RSS_Feed_Reader" ist ein Schulprojekt für die Robert-Bosch-Schule in Ulm.
Die Aufgabe war es ein 10h Projekt umzusetzen.

RSS = Rich Site Summary

## Bibliothek

Es wurde die Klassenbibliothek "FeedReader" von codehellow verwendet.
Dokumentation dazu unter: https://github.com/codehollow/FeedReader 

## Aufbau RSS Datei

```xml
<?xml version="1.0" encoding="utf-8"?>

<rss version="2.0">

  <channel>
    <title>Titel des Feeds</title>
    <link>URL der Webpräsenz</link>
    <description>Kurze Beschreibung des Feeds</description>
    <language>Sprache des Feeds (z. B. "de-de")</language>
    <copyright>Autor des Feeds</copyright>
    <pubDate>Erstellungsdatum("Tue, 8 Jul 2008 2:43:19")</pubDate>
    <image>
      <url>URL einer einzubindenden Grafik</url>
      <title>Bildtitel</title>
      <link>URL, mit der das Bild verknüpft ist</link>
    </image>

    <item>
      <title>Titel des Eintrags</title>
      <description>Kurze Zusammenfassung des Eintrags</description>
      <link>Link zum vollständigen Eintrag</link>
      <author>Autor des Artikels, E-Mail-Adresse</author>
      <guid>Eindeutige Identifikation des Eintrages</guid>
      <pubDate>Datum des Items</pubDate>
    </item>

    <item>
      ...
    </item>

  </channel>

</rss>
```

## RSS-Feed URLs

www.heise.de/rss/heise-top-atom.xml  
www.heise.de/rss/heise-atom.xml  
https://www.heise.de/rss/heiseplus-atom.xml  
etc...

## Zweck

Dieses Programm ermöglicht es einem RSS Feeds abzurufen und diese zu lesen.

## Credits

@ElevenSpins
@codehellow
