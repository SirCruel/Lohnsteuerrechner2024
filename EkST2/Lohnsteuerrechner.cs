using System;
using System.Windows.Forms;

namespace EkST
{

    public class Parameter
    {

        /////////////////////////////////////////////////////////////
        ///////////////////// Eingangsparameter /////////////////////

        // 1, wenn die Anwendung des Faktorverfahrens gewählt wurde 
        // (nur in Steuerklasse IV)
        public int AF { get; private set; }

        //Auf die Vollendung des 64. Lebensjahres folgendes Kalenderjahr 
        // (erforderlich, wenn ALTER1=1)
        public int AJAHR { get; private set; }

        // 1, wenn das 64. Lebensjahr vor Beginn des Kalenderjahres vollendet wurde,
        // in dem der Lohnzahlungszeitraum endet(§ 24a EStG), sonst = 0
        // </summary>
        public int ALTER1 { get; private set; }

        // In VKAPA und VMT enthaltene Entschädigungen nach § 24 
        // Nummer 1 EStG sowie tarifermäßigt zu besteuernde Vorteile bei
        // Vermögensbeteiligungen(§ 19a Absatz 4 EStG) in Cent
        public double ENTSCH { get; private set; }

        // eingetragener Faktor mit drei Nachkommastellen
        public float F { get; set; }

        // Jahresfreibetrag für die Ermittlung der Lohnsteuer für die sonstigen 
        // Bezüge sowie für Vermögensbeteiligungen nach § 19a Absatz 1 
        // und 4 EStG nach Maßgabe der elektronischen
        // Lohnsteuerabzugsmerkmale nach § 39e EStG oder der Eintragung
        // auf der Bescheinigung für den Lohnsteuerabzug 2024 in Cent (ggf. 0)
        public double JFREIB { get; private set; }


        // Jahreshinzurechnungsbetrag für die Ermittlung der Lohnsteuer für 
        // die sonstigen Bezüge sowie für Vermögensbeteiligungen nach § 19a
        // Absatz 1 und 4 EStG nach Maßgabe der elektronischen
        // Lohnsteuerabzugsmerkmale nach § 39e EStG oder der Eintragung
        // auf der Bescheinigung für den Lohnsteuerabzug 2024 in Cent (ggf. 0)
        public double JHINZU { get; private set; }

        // Voraussichtlicher Jahresarbeitslohn ohne sonstige Bezüge (d.h. 
        // auch ohne Vergütung für mehrjährige Tätigkeit und ohne die zu
        // besteuernden Vorteile bei Vermögensbeteiligungen, § 19a Absatz 4 
        // EStG) in Cent.Anmerkung: Die Eingabe dieses Feldes(ggf. 0) ist
        // erforderlich bei Eingaben zu sonstigen Bezügen(Felder SONSTB,
        // VMT oder VKAPA). 
        // Sind in einem vorangegangenen Abrechnungszeitraum bereits
        // sonstige Bezüge gezahlt worden, so sind sie dem voraussichtlichen
        // Jahresarbeitslohn hinzuzurechnen.Gleiches gilt für zu besteuernde
        // Vorteile bei Vermögensbeteiligungen (§ 19a Absatz 4 EStG). 
        // Vergütungen für mehrjährige Tätigkeit aus einem vorangegangenen
        // Abrechnungszeitraum werden in voller Höhe hinzugerechnet.
        public double JRE4 { get; private set; }

        // In JRE4 enthaltene Entschädigungen nach § 24 Nummer 1 EStG 
        // und zu besteuernde Vorteile bei Vermögensbeteiligungen(§ 19a
        // Absatz 4 EStG in Cent
        public double JRE4ENT { get; private set; }

        // In JRE4 enthaltene Versorgungsbezüge in Cent (ggf. 0)
        public double JVBEZ { get; private set; }

        // Merker für die Vorsorgepauschale
        // 
        // 0 = der Arbeitnehmer ist in der gesetzlichen Rentenversicherung
        // oder einer berufsständischen Versorgungseinrichtung
        // pflichtversichert oder bei Befreiung von der Versicherungspflicht
        // freiwillig versichert; es gilt die allgemeine
        // Beitragsbemessungsgrenze(BBG West)
        // 
        // 1 = der Arbeitnehmer ist in der gesetzlichen Rentenversicherung
        // oder einer berufsständischen Versorgungseinrichtung
        // pflichtversichert oder bei Befreiung von der Versicherungspflicht
        // freiwillig versichert; es gilt die Beitragsbemessungsgrenze Ost (BBG Ost)
        // 
        // 2 = wenn nicht 0 oder 1
        public int KRV { get; set; }

        // Kassenindividueller Zusatzbeitragssatz bei einem gesetzlich 
        // krankenversicherten Arbeitnehmer in Prozent(bspw. 1,60 für
        // 1,60 %) mit 2 Dezimalstellen.Es ist der volle Zusatzbeitragssatz
        // anzugeben.Die Aufteilung in Arbeitnehmer- und Arbeitgeberanteil
        // erfolgt im Programmablauf.
        public double KVZ { get; set; }

        // Lohnzahlungszeitraum:
        // 1 = Jahr
        // 2 = Monat
        // 3 = Woche
        // 4 = Tag
        public int LZZ { get; set; }

        // Der als elektronisches Lohnsteuerabzugsmerkmal für den 
        // Arbeitgeber nach § 39e EStG festgestellte oder in der Bescheinigung
        // für den Lohnsteuerabzug 2024 eingetragene Freibetrag für den
        // Lohnzahlungszeitraum in Cent

        public double LZZFREIB { get; private set; }


        // Der als elektronisches Lohnsteuerabzugsmerkmal für den 
        // Arbeitgeber nach § 39e EStG festgestellte oder in der Bescheinigung
        // für den Lohnsteuerabzug 2024 eingetragene Hinzurechnungsbetrag
        // für den Lohnzahlungszeitraum in Cent
        public double LZZHINZU { get; private set; }


        // Nicht zu besteuernde Vorteile bei Vermögensbeteiligungen (§ 19a 
        // Absatz 1 Satz 4 EStG) in Cent
        public double MBV { get; private set; }

        // Dem Arbeitgeber mitgeteilte Beiträge des Arbeitnehmers für eine 
        // private Basiskranken- bzw.Pflege-Pflichtversicherung im Sinne des
        // § 10 Absatz 1 Nummer 3 EStG in Cent; der Wert ist unabhängig vom 
        // Lohnzahlungszeitraum immer als Monatsbetrag anzugeben
        public double PKPV { get; set; }

        // 0 = gesetzlich krankenversicherte Arbeitnehmer
        // 1 = ausschließlich privat krankenversicherte Arbeitnehmer ohne
        // Arbeitgeberzuschuss
        // 2 = ausschließlich privat krankenversicherte Arbeitnehmer mit
        // Arbeitgeberzuschuss
        public int PKV { get; set; }

        // 1, wenn bei der sozialen Pflegeversicherung die Besonderheiten in 
        // Sachsen zu berücksichtigen sind bzw.zu berücksichtigen wären
        public int PVS { get; private set; }

        // 1, wenn der Arbeitnehmer den Zuschlag zur sozialen
        // Pflegeversicherung zu zahlen hat
        public int PVZ { get; set; }

        // Religionsgemeinschaft des Arbeitnehmers lt. elektronischer 
        // Lohnsteuerabzugsmerkmale oder der Bescheinigung für den
        // Lohnsteuerabzug 2024 (bei keiner Religionszugehörigkeit = 0)
        public int R { get; private set; }

        // Steuerpflichtiger Arbeitslohn für den Lohnzahlungszeitraum vor
        // Berücksichtigung des Versorgungsfreibetrags und des Zuschlags
        // zum Versorgungsfreibetrag, des Altersentlastungsbetrags und des
        // als elektronisches Lohnsteuerabzugsmerkmal festgestellten oder in 
        // der Bescheinigung für den Lohnsteuerabzug 2024 für den
        // Lohnzahlungszeitraum eingetragenen Freibetrags bzw.
        // Hinzurechnungsbetrags in Cent
        public double RE4 { get; set; }

        //Sonstige Bezüge(ohne Vergütung aus mehrjähriger Tätigkeit)
        //einschließlich nicht tarifermäßigt zu besteuernde Vorteile bei
        //Vermögensbeteiligungen und Sterbegeld bei Versorgungsbezügen
        //sowie Kapitalauszahlungen/Abfindungen, soweit es sich nicht um
        //Bezüge für mehrere Jahre handelt, in Cent(ggf. 0)
        public double SONSTB { get; private set; }

        // In SONSTB enthaltene Entschädigungen nach § 24 Nummer 1 EStG
        // sowie nicht tarifermäßigt zu besteuernde Vorteile bei
        // Vermögensbeteiligungen in Cent
        public double SONSTENT { get; private set; }

        // Sterbegeld bei Versorgungsbezügen sowie
        // Kapitalauszahlungen/Abfindungen, soweit es sich nicht um Bezüge
        // für mehrere Jahre handelt(in SONSTB enthalten), in Cent
        public double STERBE { get; private set; }

        //Steuerklasse: 
        // 1 = I
        // 2 = II
        // 3 = III
        // 4 = IV
        // 5 = V
        // 6 = V
        public int STKL { get; set; }

        // In RE4 enthaltene Versorgungsbezüge in Cent (ggf. 0) ggf. unter 
        // Berücksichtigung einer geänderten Bemessungsgrundlage nach 
        // § 19 Absatz 2 Satz 10 und 11 EStG
        public double VBEZ { get; private set; }

        // Versorgungsbezug im Januar 2005 bzw.für den ersten vollen Monat, 
        // wenn der Versorgungsbezug erstmalig nach Januar 2005 gewährt
        // wurde, in Cent
        public double VBEZM { get; private set; }

        // Voraussichtliche Sonderzahlungen von Versorgungsbezügen im
        // Kalenderjahr des Versorgungsbeginns bei Versorgungsempfängern
        // ohne Sterbegeld, Kapitalauszahlungen/Abfindungen in Cent
        public double VBEZS { get; private set; }

        // In SONSTB enthaltene Versorgungsbezüge einschließlich 
        // Sterbegeld in Cent(ggf. 0)
        public double VBS { get; private set; }

        // Jahr, in dem der Versorgungsbezug erstmalig gewährt wurde; 
        // werden mehrere Versorgungsbezüge gezahlt, wird aus
        // Vereinfachungsgründen für die Berechnung das Jahr des ältesten
        // erstmaligen Bezugs herangezogen; auf die Möglichkeit der
        // getrennten Abrechnung verschiedenartiger Bezüge(§ 39e Absatz 5a
        // EStG) wird im Übrigen verwiesen
        public int VJAHR { get; private set; }

        // Entschädigungen/Kapitalauszahlungen/Abfindungen/
        // Nachzahlungen bei Versorgungsbezügen für mehrere Jahre in Cent
        // (ggf. 0)
        public double VKAPA { get; set; }

        // Entschädigungen und Vergütung für mehrjährige Tätigkeit sowie
        // tarifermäßigt zu besteuernde Vorteile bei Vermögensbeteiligungen
        // (§ 19a Absatz 4 Satz 2 EStG) ohne Kapitalauszahlungen und ohne
        // Abfindungen bei Versorgungsbezügen in Cent(ggf. 0)
        public double VMT { get; private set; }

        // Zahl der Freibeträge für Kinder(eine Dezimalstelle, nur bei
        // Steuerklassen I, II, III und IV)
        public int ZKF { get; private set; }

        // Zahl der Monate, für die im Kalenderjahr Versorgungsbezüge
        // gezahlt werden [nur erforderlich bei Jahresberechnung (LZZ = 1)]
        public int ZMVB { get; set; }

        /////////////////////////////////////////////////////////////
        ///////////////////// Ausgangsparameter /////////////////////

        // Bemessungsgrundlage für die Kirchenlohnsteuer in Cent
        public double BK { get; set; }

        // Bemessungsgrundlage der sonstigen Bezüge (ohne Vergütung für 
        // mehrjährige Tätigkeit) für die Kirchenlohnsteuer in Cent.
        // Hinweis: Negativbeträge, die aus nicht zu besteuernden Vorteilen bei
        // Vermögensbeteiligungen(§ 19a Absatz 1 Satz 4 EStG) resultieren, 
        // mindern BK(maximal bis 0). Der Sonderausgabenabzug für
        // tatsächlich erbrachte Vorsorgeaufwendungen im Rahmen der
        // Veranlagung zur Einkommensteuer bleibt unberührt
        public double BKS { get; set; }

        // Bemessungsgrundlage der Vergütung für mehrjährige Tätigkeit und
        // der tarifermäßigt zu besteuernden Vorteile bei
        // Vermögensbeteiligungen für die Kirchenlohnsteuer in Cen
        public double BKV { get; set; }

        // Für den Lohnzahlungszeitraum einzubehaltende Lohnsteuer in Cent
        public double LSTLZZ { get; set; }

        // Für den Lohnzahlungszeitraum einzubehaltender 
        // Solidaritätszuschlag in Cent
        public double SOLZLZZ { get; set; }

        // Solidaritätszuschlag für sonstige Bezüge (ohne Vergütung für 
        // mehrjährige Tätigkeit in Cent.
        // Hinweis: Negativbeträge, die aus nicht zu besteuernden Vorteilen bei 
        // Vermögensbeteiligungen(§ 19a Absatz 1 Satz 4 EStG) resultieren,
        // mindern SOLZLZZ(maximal bis 0). Der Sonderausgabenabzug für
        // tatsächlich erbrachte Vorsorgeaufwendungen im Rahmen der
        // Veranlagung zur Einkommensteuer bleibt unberührt
        public double SOLZS { get; set; }

        // Solidaritätszuschlag für die Vergütung für mehrjährige Tätigkeit und 
        // der tarifermäßigt zu besteuernden Vorteile bei
        // Vermögensbeteiligungen in Cent
        public double SOLZV { get; set; }

        // Lohnsteuer für sonstige Bezüge (ohne Vergütung für mehrjährige 
        // Tätigkeit und ohne tarifermäßigt zu besteuernde Vorteile bei
        // Vermögensbeteiligungen) in Cent
        // Hinweis: Negativbeträge, die aus nicht zu besteuernden Vorteilen bei
        // Vermögensbeteiligungen(§ 19a Absatz 1 Satz 4 EStG) resultieren, 
        // mindern LSTLZZ(maximal bis 0). Der Sonderausgabenabzug für
        // tatsächlich erbrachte Vorsorgeaufwendungen im Rahmen der
        // Veranlagung zur Einkommensteuer bleibt unberührt.
        public double STS { get; set; }

        // Lohnsteuer für die Vergütung für mehrjährige Tätigkeit und der
        // tarifermäßigt zu besteuernden Vorteile bei Vermögensbeteiligungen in Cent
        public double STV { get; set; }

        // Für den Lohnzahlungszeitraum berücksichtigte Beiträge des 
        // Arbeitnehmers zur privaten Basis-Krankenversicherung und privaten
        // Pflege-Pflichtversicherung(ggf.auch die Mindestvorsorgepauschale)
        // in Cent beim laufenden Arbeitslohn.Für Zwecke der
        // Lohnsteuerbescheinigung sind die einzelnen Ausgabewerte
        // außerhalb des eigentlichen Lohnsteuerberechnungsprogramms zu
        // addieren; hinzuzurechnen sind auch die Ausgabewerte VKVSONST.
        public double VKVLZZ { get; set; }

        // Für den Lohnzahlungszeitraum berücksichtigte Beiträge des
        // Arbeitnehmers zur privaten Basis-Krankenversicherung und privaten
        // Pflege-Pflichtversicherung(ggf.auch die Mindestvorsorgepauschale)
        // in Cent bei sonstigen Bezügen.Der Ausgabewert kann auch negativ
        // sein.Für tarifermäßigt zu besteuernde Vergütungen für mehrjährige
        // Tätigkeiten enthält der PAP keinen entsprechenden Ausgabewert. 
        public double VKVSONST { get; set; }

        // Verbrauchter Freibetrag bei Berechnung des laufenden Arbeitslohns, in Cent
        public double VFRB { get; set; }

        // Verbrauchter Freibetrag bei Berechnung des voraussichtlichen 
        // Jahresarbeitslohns, in Cent
        public double VFRBS1 { get; set; }

        // Verbrauchter Freibetrag bei Berechnung der sonstigen Bezüge, in Cent
        public double VFRBS2 { get; set; }

        // Für die weitergehende Berücksichtigung des Steuerfreibetrags nach 
        // dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag bei der
        // Berechnung des laufenden Arbeitslohns, in Cent
        public double WVFRB { get; set; }

        // Für die weitergehende Berücksichtigung des Steuerfreibetrags nach 
        // dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag bei der
        // Berechnung der sonstigen Bezüge, in Cent
        public double WVFRBM { get; set; }

        // Für die weitergehende Berücksichtigung des Steuerfreibetrags nach 
        // dem DBA Türkei verfügbares ZVE über dem Grundfreibetrag bei der
        // Berechnung des voraussichtlichen Jahresarbeitslohns, in Cent
        public double WVFRBO { get; set; }

        /////////////////////////////////////////////////////////////
        ///////////////////// interne Felder ////////////////////////

        // Altersentlastungsbetrag in Euro, Cent (2 Dezimalstellen)
        public double ALTE { get; set; }

        // Arbeitnehmer-Pauschbetrag/Werbungskosten-Pauschbetrag in Euro
        public double ANP { get; set; }

        // Auf den Lohnzahlungszeitraum entfallender Anteil von Jahreswerten auf ganze Cent abgerundet
        public double ANTEIL1 { get; set; }

        // Auf den Lohnzahlungszeitraum entfallender Anteil von Jahreswerten auf ganze Cent abgerundet
        public double BBGKVPV { get; set; }

        // Allgemeine Beitragsbemessungsgrenze in der allgemeinen Rentenversicherung in Euro
        public double BBGRV { get; set; }

        // Bemessungsgrundlage für Altersentlastungsbetrag in Euro, Cent (2 Dezimalstellen)
        public double BMG { get; set; }

        // Differenz zwischen ST1 und ST2 in Euro
        public double DIFF { get; set; }

        // Entlastungsbetrag für Alleinerziehende in Euro
        public double EFA { get; set; }

        // Versorgungsfreibetrag in Euro, Cent (2 Dezimalstellen)
        public double FVB { get; set; }

        // Versorgungsfreibetrag in Euro, Cent (2 Dezimalstellen) für die Berechnung der Lohnsteuer für den sonstigen Bezug
        public double FVBSO { get; set; }

        // Zuschlag zum Versorgungsfreibetrag in Euro
        public double FVBZ { get; set; }

        // Zuschlag zum Versorgungsfreibetrag in Euro für die Berechnung der Lohnsteuer beim sonstigen Bezug
        public double FVBZSO { get; set; }

        // Grundfreibetrag in Euro
        public double GFB { get; set; }

        // Maximaler Altersentlastungsbetrag in Euro
        public double HBALTE { get; set; }

        // Maßgeblicher maximaler Versorgungsfreibetrag in Euro
        public double HFVB { get; set; }

        // Maßgeblicher maximaler Zuschlag zum Versorgungsfreibetrag in Euro, Cent(2 Dezimalstellen)
        public double HFVBZ { get; set; }

        // Maßgeblicher maximaler Zuschlag zum Versorgungsfreibetrag in Euro, Cent(2 Dezimalstellen)
        // für die Berechnung der Lohnsteuer für den sonstigen Bezug
        public double HFVBZSO { get; set; }

        // Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        public double HOCH { get; set; }

        // Nummer der Tabellenwerte für Versorgungsparameter
        public int J { get; set; }

        // Jahressteuer nach § 51a EStG, aus der Solidaritätszuschlag und Bemessungsgrundlage für die
        // Kirchenlohnsteuer ermittelt werden, in Euro
        public double JBMG { get; set; }

        // Auf einen Jahreslohn hochgerechneter LZZFREIB in Euro, Cent (2 Dezimalstellen)
        public double JLFREIB { get; set; }

        // Auf einen Jahreslohn hochgerechneter LZZHINZU in Euro, Cent (2 Dezimalstellen)
        public double JLHINZU { get; set; }

        // Jahreswert, dessen Anteil für einen Lohnzahlungszeitraum in UPANTEIL errechnet werden soll, in Cent
        public double JW { get; set; }

        // Nummer der Tabellenwerte für Parameter bei Altersentlastungsbetrag
        public int K { get; set; }

        // Merker für Berechnung Lohnsteuer für mehrjährige Tätigkeit
        // 0 = normale Steuerberechnung
        // 1 = Steuerberechnung für mehrjährige Tätigkeit
        // 2 = Ermittlung der Vorsorgepauschale ohne Entschädigungen i.S.d. § 24 Nummer 1 EStG
        public int KENNVMT { get; set; }

        // Summe der Freibeträge für Kinder in Euro
        public double KFB { get; set; }

        // Beitragssatz des Arbeitgebers zur Krankenversicherung unter Berücksichtigung des durchschnittlichen
        // Zusatzbeitragssatzes für die Ermittlung des Arbeitgeberzuschusses(5 Dezimalstellen)
        public double KVSATZAG { get; set; }

        // Beitragssatz des Arbeitnehmers zur Krankenversicherung (5 Dezimalstellen)
        public double KVSATZAN { get; set; }

        // Kennzahl für die Einkommensteuer-Tarifarten:
        // 1 = Grundtarif
        // 2 = Splittingverfahren
        public int KZTAB { get; set; }

        // Jahreslohnsteuer in Euro
        public double LSTJAHR { get; set; }

        // Zwischenfelder der Jahreslohnsteuer in Cent
        public double LST1 { get; set; }
        public double LST2 { get; set; }
        public double LST3 { get; set; }
        public double LSTOSO { get; set; }
        public double LSTSO { get; set; }

        // Mindeststeuer für die Steuerklassen V und VI in Euro
        public double MIST { get; set; }

        // Beitragssatz des Arbeitgebers zur Pflegeversicherung (6 Dezimalstellen)
        public double PVSATZAG { get; set; }

        // Beitragssatz des Arbeitnehmers zur Pflegeversicherung (6 Dezimalstellen)
        public double PVSATZAN { get; set; }

        //Beitragssatz des Arbeitnehmers in der allgemeinen gesetzlichen Rentenversicherung (4 Dezimalstellen)
        public double RVSATZAN { get; set; }

        // Rechenwert in Gleitkommadarstellung
        public double RW { get; set; }

        // Sonderausgaben-Pauschbetrag in Euro
        public double SAP { get; set; }

        // Freigrenze für den Solidaritätszuschlag in Euro
        public double SOLZFREI { get; set; }

        // Solidaritätszuschlag auf die Jahreslohnsteuer in Euro, Cent (2 Dezimalstellen)
        public double SOLZJ { get; set; }

        // Zwischenwert für den Solidaritätszuschlag auf die Jahreslohnsteuer in Euro, Cent (2 Dezimalstellen)
        public double SOLZMIN { get; set; }

        // Bemessungsgrundlage des Solidaritätszuschlags zur Prüfung der Freigrenze beim Solidaritätszuschlag für sonstige Bezüge
        // (ohne Vergütung für mehrjährige Tätigkeit) in Euro
        public double SOLZSBMG { get; set; }

        // Zu versteuerndes Einkommen für die Ermittlung der Bemessungsgrundlage des Solidaritätszuschlags zur Prüfung der Freigrenze
        // beim Solidaritätszuschlag für sonstige Bezüge(ohne Vergütung für mehrjährige Tätigkeit) in Euro, Cent(2 Dezimalstellen)
        public double SOLZSZVE { get; set; }

        // Bemessungsgrundlage des Solidaritätszuschlags für die Prüfung der Freigrenze beim Solidaritätszuschlag
        // für die Vergütung für mehrjährige Tätigkeit in Euro
        public double SOLZVBMG { get; set; }

        // Tarifliche Einkommensteuer in Euro
        public double ST { get; set; }

        // Tarifliche Einkommensteuer auf das 1,25-fache ZX in Euro
        public double ST1 { get; set; }

        // Tarifliche Einkommensteuer auf das 0,75-fache ZX in Euro
        public double ST2 { get; set; }

        // Zwischenfeld zur Ermittlung der Steuer auf Vergütungen für mehrjährige Tätigkeit in Euro
        public double STOVMT { get; set; }

        // Tabelle für die Prozentsätze des Versorgungsfreibetrags
        public double TAB1 { get; set; }

        // Tabelle für die Höchstbeträge des Versorgungsfreibetrags
        public double TAB2 { get; set; }

        // Tabelle für die Zuschläge zum Versorgungsfreibetrag
        public double TAB3 { get; set; }

        // Tabelle für die Prozentsätze des Altersentlastungsbetrags
        public double TAB4 { get; set; }

        // Tabelle für die Höchstbeträge des Altersentlastungsbetrags
        public double TAB5 { get; set; }

        // Bemessungsgrundlage für den Versorgungsfreibetrag in Cent
        public double VBEZB { get; set; }

        // Bemessungsgrundlage für den Versorgungsfreibetrag in Cent für den sonstigen Bezug
        public double VBEZBSO { get; set; }

        // Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        public double VERGL { get; set; }

        // Höchstbetrag der Mindestvorsorgepauschale für die Kranken- und Pflegeversicherung in Euro, Cent(2 Dezimalstellen)
        public double VHB { get; set; }

        // Jahreswert der berücksichtigten Beiträge zur privaten BasisKrankenversicherung und privaten Pflege-Pflichtversicherung
        // (ggf. auch die Mindestvorsorgepauschale) in Cent
        public double VKV { get; set; }

        // Vorsorgepauschale mit Teilbeträgen für die Rentenversicherung sowie die gesetzliche Kranken- und soziale Pflegeversicherung nach
        // fiktiven Beträgen oder ggf.für die private Basiskrankenversicherung und private Pflege-Pflichtversicherung in Euro, Cent (2 Dezimalstellen)
        public double VSP { get; set; }

        // Vorsorgepauschale mit Teilbeträgen für die Rentenversicherung sowie der Mindestvorsorgepauschale für die Kranken- und
        // Pflegeversicherung in Euro, Cent(2 Dezimalstellen)
        public double VSPN { get; set; }

        // Zwischenwert 1 bei der Berechnung der Vorsorgepauschale in Euro, Cent(2 Dezimalstellen)
        public double VSP1 { get; set; }

        // Zwischenwert 2 bei der Berechnung der Vorsorgepauschale in Euro, Cent(2 Dezimalstellen)
        public double VSP2 { get; set; }

        // Vorsorgepauschale mit Teilbeträgen für die gesetzliche Krankenund soziale Pflegeversicherung nach fiktiven Beträgen oder ggf. für 
        // die private Basiskrankenversicherung und private PflegePflichtversicherung in Euro, Cent(2 Dezimalstellen)
        public double VSP3 { get; set; }

        // Erster Grenzwert in Steuerklasse V/VI in Euro
        public double W1STKL5 { get; set; }

        // Zweiter Grenzwert in Steuerklasse V/VI in Euro
        public double W2STKL5 { get; set; }

        // Dritter Grenzwert in Steuerklasse V/VI in Euro
        public double W3STKL5 { get; set; }

        // Zu versteuerndes Einkommen gem. § 32a Absatz 1 und 5 EStG in Euro, Cent(2 Dezimalstellen)
        public double X { get; set; }

        // Gem. § 32a Absatz 1 EStG(6 Dezimalstellen)
        public double Y { get; set; }

        // Auf einen Jahreslohn hochgerechnetes RE4 in Euro, Cent (2 Dezimalstellen) nach Abzug der Freibeträge nach § 39b Absatz 2 Satz 3 und 4 EStG
        public double ZRE4 { get; set; }

        // Auf einen Jahreslohn hochgerechnetes RE4 in Euro, Cent (2 Dezimalstellen)
        public double ZRE4J { get; set; }

        // Auf einen Jahreslohn hochgerechnetes RE4, ggf. nach Abzug der Entschädigungen i.S.d. § 24 Nummer 1 EStG in Euro, Cent (2 Dezimalstellen)
        public double ZRE4VP { get; set; }

        // Feste Tabellenfreibeträge (ohne Vorsorgepauschale) in Euro, Cent (2 Dezimalstellen)
        public double ZTABFB { get; set; }

        // Auf einen Jahreslohn hochgerechnetes VBEZ abzüglich FVB in Euro, Cent (2 Dezimalstellen)
        public double ZVBEZ { get; set; }

        // Auf einen Jahreslohn hochgerechnetes VBEZ in Euro, Cent (2 Dezimalstellen)
        public double ZVBEZJ { get; set; }

        // Zu versteuerndes Einkommen in Euro, Cent (2 Dezimalstellen)
        public double ZVE { get; set; }

        // Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        public double ZX { get; set; }

        // Zwischenfeld zu X für die Berechnung der Steuer nach § 39b Absatz 2 Satz 7 EStG in Euro
        public double ZZX { get; set; }
    }

    public class Lohnsteuerrechner
    {
        private Parameter par;

        public Lohnsteuerrechner(Parameter param)
        {
            this.par = param;
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Parameter param = new Parameter();
            // Setzen Sie die notwendigen Anfangswerte für param

            Lohnsteuerrechner steuerrechner = new Lohnsteuerrechner(param);
            Application.Run(new Form1(steuerrechner));
        }
        /// <summary>
        /// Steuerung
        /// </summary>
        public void LST2024()
        {
            MPARA();
            MRE4JL();

            par.VBEZBSO = 0;

            par.KENNVMT = 0;

            MRE4();
            MRE4ABZ();
            MBERECH();
            MSONST();
            MVMT();
        }

        /// <summary>
        /// Zuweisung von Werten für bestimmte Sozialversicherungsparameter
        /// </summary>
        public void MPARA()
        {

            // Parameter Rentenversicherung
            if (par.KRV < 2)
            {
                if (par.KRV == 0)
                {
                    par.BBGRV = 90600;
                }
                else
                {
                    par.BBGRV = 89400;
                }

                par.RVSATZAN = 0.093;
            }

            par.BBGKVPV = 62100;

            // Parameter Krankenversicherung/ Pflegeversicherung
            par.KVSATZAN = par.KVZ / 2 / 100 + 0.07;
            par.KVSATZAG = 0.008 + 0.07;

            if (par.PVS == 1)
            {
                par.PVSATZAN = 0.022;
                par.PVSATZAG = 0.012;
            }
            else
            {
                par.PVSATZAN = 0.017;
                par.PVSATZAG = 0.017;
            }

            if (par.PVZ == 1)
            {
                par.PVSATZAN += 0.006;
            }

            // Grenzwerte für die Steuerklassen V/ VI
            par.W1STKL5 = 13279;
            par.W2STKL5 = 33380;
            par.W3STKL5 = 222260;

            // Grundfreibetrag
            par.GFB = 11604;

            //Freigrenze SolZ
            par.SOLZFREI = 18130;
        }

        /// <summary>
        /// Ermittlung des Jahresarbeitslohns nach
        /// § 39b Absatz 2 Satz 2 EStG
        /// </summary>
        public void MRE4JL()
        {
            if (par.LZZ == 1)
            {
                par.ZRE4J = par.RE4 / 100;
                par.ZVBEZJ = par.VBEZ / 100;
                par.JLFREIB = par.LZZFREIB / 100;
                par.JLHINZU = par.LZZHINZU / 100;
            }
            else if (par.LZZ == 2)
            {
                par.ZRE4J = par.RE4 * 12 / 100;
                par.ZVBEZJ = par.VBEZ * 12 / 100;
                par.JLFREIB = par.LZZFREIB * 12 / 100;
                par.JLHINZU = par.LZZHINZU * 12 / 100;
            }
            else if (par.LZZ == 3)
            {
                par.ZRE4J = par.RE4 * 360 / 7 / 100;
                par.ZVBEZJ = par.VBEZ * 360 / 7 / 100;
                par.JLFREIB = par.LZZFREIB * 360 / 7 / 100;
                par.JLHINZU = par.LZZHINZU * 360 / 7 / 100;
            }
            else
            {
                par.ZRE4J = par.RE4 * 360 / 100;
                par.ZVBEZJ = par.VBEZ * 360 / 100;
                par.JLFREIB = par.LZZFREIB * 360 / 100;
                par.JLHINZU = par.LZZHINZU * 360 / 100;
            }

            if (par.AF == 0)
            {
                par.F = 1;
            }

        }

        /// <summary>
        /// Ermittlung der Freibeträge nach § 39b Absatz 2 Satz 3 EStG
        /// </summary>
        public void MRE4()
        {
            if (par.ZVBEZJ == 0)
            {
                par.FVBZ = 0;
                par.FVB = 0;
                par.FVBZSO = 0;
                par.FVBSO = 0;
            }
            else
            {
                if (par.VJAHR < 2006)
                {
                    par.J = 1;
                }

                else if (par.VJAHR < 2040)
                {
                    par.J = par.VJAHR - 2004;
                }

                else
                {
                    par.J = 36;
                }

                if (par.LZZ == 1)
                {
                    par.VBEZB = par.VBEZM * par.ZMVB + par.VBEZS;
                    par.TAB2 = TABJ(2, TAB123);
                    par.HFVB = par.TAB2 / 12 * par.ZMVB;
                    par.TAB3 = TABJ(3, TAB123);
                    par.FVBZ = par.TAB3 / 12 * par.ZMVB;
                    par.FVBZ = Math.Ceiling(par.FVBZ); // aufrunden auf ganze Euro
                }

                else
                {
                    par.VBEZB = par.VBEZM * 12 + par.VBEZS;
                    par.TAB2 = TABJ(2, TAB123);
                    par.TAB3 = TABJ(3, TAB123);
                    par.HFVB = par.TAB2;
                    par.FVBZ = par.TAB3;
                    par.FVBZ = Math.Ceiling(par.FVBZ); // aufrunden auf ganze Euro
                }

                par.TAB1 = TABJ(1, TAB123);
                par.FVB = par.VBEZB * par.TAB1 / 100;
                par.FVB = Math.Ceiling(par.FVB * 100)/100; // aufrunden auf ganze Cent

                if (par.FVB > par.HFVB)
                {
                    par.FVB = par.HFVB;
                }

                if (par.FVB > par.ZVBEZJ)
                {
                    par.FVB = par.ZVBEZJ;
                }

                par.FVBSO = (par.FVB + par.VBEZBSO * par.TAB1 / 100);
                par.FVBSO = Math.Ceiling(par.FVBSO * 100)/100; // aufrunden auf ganze Cent

                if (par.FVBSO > par.TAB2)
                {
                    par.FVBSO = par.TAB2;
                }

                par.HFVBZSO = (par.VBEZB + par.VBEZBSO) / 100 - par.FVBSO;

                par.FVBZSO = par.FVBZ + par.VBEZBSO / 100;
                par.FVBZSO = Math.Ceiling(par.FVBZSO); // aufrunden auf ganze Euro

                if (par.FVBZSO > par.HFVBZSO)
                {
                    par.FVBZSO = par.HFVBZSO;
                    par.FVBZSO = Math.Ceiling(par.FVBZSO); // aufrunden auf ganze Euro
                }

                if (par.FVBZSO > par.TAB3)
                {
                    par.FVBZSO = par.TAB3;
                }

                par.HFVBZ = par.VBEZB / 100 - par.FVB;

                if (par.FVBZ > par.HFVBZ)
                {
                    par.FVBZ = par.HFVBZ;
                    par.FVBZ = Math.Ceiling(par.FVBZ); // aufrunden auf ganze Euro
                }
            }
            // Ermittlung des Altersentlastungsbetrags
            MRE4ALTE();
        }

        /// <summary>
        /// Altersentlastungsbetrag (§ 39b Absatz 2 Satz 3 EStG)
        /// </summary>
        private void MRE4ALTE()
        {
            if (par.ALTER1 == 0)
            {
                par.ALTE = 0;
            }
            else
            {
                if (par.AJAHR < 2006)
                {
                    par.K = 1;
                }
                else if (par.AJAHR < 2040)
                {
                    par.K = par.AJAHR - 2004;
                }
                else
                {
                    par.K = 36;
                }
                par.BMG = par.ZRE4J - par.ZVBEZJ;

                par.TAB4 = TABK(1, TAB45);
                par.ALTE = par.BMG * par.TAB4;
                par.ALTE = Math.Ceiling(par.ALTE);  // aufrunden auf ganze Euro
                par.TAB5 = TABK(2, TAB45);
                par.HBALTE = par.TAB5;

                if (par.ALTE > par.HBALTE)
                {
                    par.ALTE = par.HBALTE;
                }
            }
        }

        /// <summary>
        /// Abzug der Freibeträge nach § 39b Absatz 2
        /// Satz 3 und 4 EStG vom Jahresarbeitslohn
        /// </summary>
        public void MRE4ABZ()
        {
            par.ZRE4 = par.ZRE4J - par.FVB - par.ALTE - par.JLFREIB + par.JLHINZU;

            if (par.ZRE4 < 0)
            {
                par.ZRE4 = 0;
            }

            par.ZRE4VP = par.ZRE4J;

            if (par.KENNVMT == 2)
            {
                par.ZRE4VP = par.ZRE4VP - par.ENTSCH / 100;
            }

            par.ZVBEZ = par.ZVBEZJ - par.FVB;

            if (par.ZVBEZ < 0)
            {
                par.ZVBEZ = 0;
            }
        }

        /// <summary>
        /// Ermittlung der Jahreslohnsteuer auf laufende Bezüge
        /// </summary>
        public void MBERECH()
        {
            // Ermittlung der festen Tabellenfreibeträge (ohne Vorsorgepauschale)
            MZTABFB();
            par.VFRB = (par.ANP + par.FVB + par.FVBZ) * 100;

            // Ermittlung der Jahreslohnsteuer für die Lohnsteuerberechnung
            MLSTJAHR();
            par.WVFRB = (par.ZVE - par.GFB) * 100;

            if (par.WVFRB < 0)
            {
                par.WVFRB = 0;
            }

            par.LSTJAHR = par.ST * par.F;

            // Ermittlung des Anteils der Jahreslohnsteuer für den Lohnzahlungszeitraum
            UPLSTLZZ();

            // Ermittlung des Anteils der berücksichtigten Vorsorgeaufwendungen für den Lohnzahlungszeitraum
            UPVKVLZZ();

            if (par.ZKF > 0)
            {
                // Berechnung der Tabellenfreibeträge mit Freibeträgen für Kinder für die Bemessungsgrundlage KiSt und SOLZ
                par.ZTABFB = par.ZTABFB + par.KFB;
                MRE4ABZ();

                // Ermittlung der Jahreslohnsteuer mit Freibeträgen für Kinder als Jahresbemessungsgrundlage KiSt und SOLZ
                MLSTJAHR();

                par.JBMG = par.ST * par.F;
            }
            else
            {
                par.JBMG = par.LSTJAHR;
            }

            // Ermittlung des Solidaritätszuschlags mit Aufteilung von SOLZJ und JBMG auf den Lohnzahlungszeitraum
            MSOLZ();
        }

        /// <summary>
        /// Ermittlung der festen Tabellenfreibeträge (ohne Vorsorgepauschale)
        /// </summary>
        private void MZTABFB()
        {
            par.ANP = 0;

            if (par.ZVBEZ >= 0)
            {
                if (par.ZVBEZ < par.FVBZ)
                {
                    par.FVBZ = par.ZVBEZ;
                }
            }

            // Mögliche Begrenzung des Zuschlags zum Versorgungsfreibetrag, und Festlegung und Begrenzung Werbungskosten - Pauschbetrag für Versorgungsbezüge
            if (par.STKL < 6)
            {
                if (par.ZVBEZ > 0)
                {
                    if ((par.ZVBEZ - par.FVBZ) < 102)
                    {
                        par.ANP = par.ZVBEZ - par.FVBZ;
                        par.ANP = Math.Ceiling(par.ANP); // aufrunden auf ganze Euro
                    }
                    else
                    {
                        par.ANP = 102;
                    }
                }
            }
            else
            {
                par.FVBZ = 0;
                par.FVBZSO = 0;
            }

            //Festlegung Arbeitnehmer-Pauschbetrag für aktiven Lohn mit möglicher Begrenzung
            if (par.STKL < 6)
            {
                if (par.ZRE4 > par.ZVBEZ)
                {
                    if ((par.ZRE4 - par.ZVBEZ) < 1230)
                    {
                        par.ANP = par.ANP + par.ZRE4 - par.ZVBEZ;
                        par.ANP = Math.Ceiling(par.ANP); // aufrunden auf ganze Euro
                    }
                    else
                    {
                        par.ANP += 1230;
                    }
                }
            }
            par.KZTAB = 1;

            if (par.STKL == 1)
            {
                par.SAP = 36;
                par.KFB = par.ZKF * 9312;
            }
            else if (par.STKL == 2)
            {
                par.EFA = 4260;
                par.SAP = 36;
                par.KFB = par.ZKF * 9312;
            }
            else if (par.STKL == 3)
            {
                par.KZTAB = 2;
                par.SAP = 36;
                par.KFB = par.ZKF * 9312;
            }
            else if (par.STKL == 4)
            {
                par.SAP = 36;
                par.KFB = par.ZKF * 4656;
            }
            else if (par.STKL == 5)
            {
                par.SAP = 36;
                par.KFB = 0;
            }
            else
            {
                par.KFB = 0;
            }
            // Berechnung der Tabellenfreibeträge ohne Freibeträge für Kinder für die Lohnsteuerberechnung
            par.ZTABFB = par.EFA + par.ANP + par.SAP + par.FVBZ;
        }

        /// <summary>
        /// Ermittlung Jahreslohnsteuer
        /// </summary>
        private void MLSTJAHR()
        {
            // Ermittlung der Vorsorgepauschale
            UPEVP();

            // Ermittlung der Steuer bei Vergütung für mehrjährige Tätigkeit
            if (par.KENNVMT != 1)
            {
                par.ZVE = par.ZRE4 - par.ZTABFB - par.VSP;
                UPMLST();
            }
            else
            {
                par.ZVE = par.ZRE4 - par.ZTABFB - par.VSP - par.VMT / 100 - par.VKAPA / 100;

                // Sonderfall des negativen verbleibenden zvE nach § 34 Absatz 1 Satz 3 EStG
                if (par.ZVE < 0)
                {
                    par.ZVE = (par.ZVE + par.VMT / 100 + par.VKAPA / 100) / 5;
                    UPMLST();
                    par.ST = par.ST * 5;
                }
                else
                {
                    // Steuerberechnung ohne Einkünfte nach § 34 EStG
                    UPMLST();
                    par.STOVMT = par.ST;

                    // Steuerberechnung mit Einkünften nach § 34 ESt
                    par.ZVE = par.ZVE + (par.VMT + par.VKAPA) / 500;
                    UPMLST();
                    par.ST = (par.ST - par.STOVMT) * 5 + par.STOVMT;
                }
            }
        }

        private void UPVKVLZZ()
        {
            // Ermittlung des Jahreswertes der berücksichtigten privaten Kranken- und Pflegeversicherungsbeiträge
            UPVKV();
            par.JW = par.VKV;

            // Ermittlung des Anteils der berücksichtigten privaten Kranken- und Pflegeversiche- rungsbeiträge für den Lohnzahlungszeitraum
            UPANTEIL();
            par.VKVLZZ = par.ANTEIL1;
        }
        private void UPVKV()
        {

            if (par.PKV > 0)
            {
                if (par.VSP2 > par.VSP3)
                {
                    par.VKV = (par.VSP2 * 100);
                }
                else
                {
                    par.VKV = (par.VSP3 * 100);
                }
            }
            else
            {
                par.VKV = 0;
            }
        }
        private void UPLSTLZZ()
        {
            par.JW = par.LSTJAHR * 100;
            // Ermittlung des Anteils der Jahreslohnsteuer für den Lohnzahlungszeitraum
            UPANTEIL();
            par.LSTLZZ = par.ANTEIL1;
        }
        private void UPMLST()
        {
            if (par.ZVE < 1)
            {
                par.ZVE = 0;
                par.X = 0;
            }
            else
            {
                par.X = par.ZVE / par.KZTAB;
                par.X = Math.Floor(par.X); // abrunden auf ganze Euro
            }

            if (par.STKL < 5)
            {
                UPTAB24();
            }
            else
            {
                MST5_6();
            }
        }

        /// <summary>
        /// Vorsorgepauschale (§ 39b Absatz 2 Satz 5 Nummer 3 und Absatz 4 EStG) 
        /// </summary>
        private void UPEVP()
        {
            if (par.KRV > 1)
            {
                par.VSP1 = 0;
            }
            else
            {
                if (par.ZRE4VP > par.BBGRV)
                {
                    par.ZRE4VP = par.BBGRV;
                }
                par.VSP1 = par.ZRE4VP * par.RVSATZAN;
            }

            par.VSP2 = 0.12 * par.ZRE4VP;

            if (par.STKL == 3)
            {
                par.VHB = 3000;
            }
            else
            {
                par.VHB = 1900;
            }

            if (par.VSP2 > par.VHB)
            {
                par.VSP2 = par.VHB;
            }

            par.VSPN = par.VSP1 + par.VSP2;
            par.VSPN = Math.Ceiling(par.VSPN); // aufrunden auf ganze Euro
            MVSP();

            if (par.VSPN > par.VSP)
            {
                par.VSP = par.VSPN;
            }
        }

        /// <summary>
        /// Vorsorgepauschale (§ 39b Absatz 2 Satz 5 Nummer 3 EStG) Vergleichsberechnung zur Mindestvorsorgepauschale
        /// </summary>
        private void MVSP()
        {
            if (par.ZRE4VP > par.BBGKVPV)
            {
                par.ZRE4VP = par.BBGKVPV;
            }
            if (par.PKV > 0)
            {
                if (par.STKL == 6)
                {
                    par.VSP3 = 0;
                }
                else
                {
                    par.VSP3 = par.PKPV * 12 / 100;

                    if (par.PKPV == 2)
                    {
                        par.VSP3 = par.VSP3 - par.ZRE4VP * (par.KVSATZAG + par.PVSATZAG);
                    }
                }
            }
            else
            {
                par.VSP3 = par.ZRE4VP * (par.KVSATZAN + par.PVSATZAN);
            }
            par.VSP = par.VSP3 + par.VSP1;
            par.VSP = Math.Ceiling(par.VSP); // aufrunden auf ganze Euro
        }

        /// <summary>
        /// Lohnsteuer für die Steuerklassen V und VI (§ 39b Absatz 2 Satz 7 EStG)
        /// </summary>
        private void MST5_6()
        {
            par.ZZX = par.X;

            if (par.ZZX > par.W2STKL5)
            {
                par.ZX = par.W2STKL5;
                UP5_6();

                if (par.ZZX > par.W3STKL5)
                {
                    par.ST = (par.ST + (par.W3STKL5 - par.W2STKL5) * 0.42);
                    par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
                    par.ST = (par.ST + (par.ZZX - par.W3STKL5) * 0.45);
                    par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
                }
                else
                {
                    par.ST = (par.ST + (par.ZZX - par.W2STKL5) * 0.42);
                    par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
                }
            }
            else
            {
                par.ZX = par.ZZX;
                UP5_6();
                if (par.ZZX > par.W1STKL5)
                {
                    par.VERGL = par.ST;
                    par.ZX = par.W1STKL5;
                    UP5_6();
                    par.HOCH = (par.ST + (par.ZZX - par.W1STKL5) * 0.42);
                    par.HOCH = Math.Floor(par.HOCH); // abrunden auf ganze Euro

                    if (par.HOCH < par.VERGL)
                    {
                        par.ST = par.HOCH;
                    }
                    else
                    {
                        par.ST = par.VERGL;
                    }
                }
            }
        }
        private void UP5_6()
        {
            par.X = par.ZX * 1.25;
            UPTAB24();
            par.ST1 = par.ST;
            par.X = par.ZX * 0.75;
            UPTAB24();
            par.ST2 = par.ST;
            par.DIFF = (par.ST1 - par.ST2) * 2;
            par.MIST = par.ZX * 0.14;
            par.MIST = Math.Floor(par.MIST); // abrunden auf ganze Euro

            if (par.MIST > par.DIFF)
            {
                par.ST = par.MIST;
            }
            else
            {
                par.ST = par.DIFF;
            }
        }

        /// <summary>
        /// Solidaritätszuschlag
        /// </summary>
        private void MSOLZ()
        {
            par.SOLZFREI = par.SOLZFREI * par.KZTAB;

            if (par.JBMG > par.SOLZFREI)
            {
                par.SOLZJ = par.JBMG * 5.5 / 100;
                par.SOLZJ = Math.Floor((par.SOLZJ) * 100)/100; // abrunden auf ganze Cent
                par.SOLZMIN = (par.JBMG - par.SOLZFREI) * 11.9 / 100;

                if (par.SOLZMIN < par.SOLZJ)
                {
                    par.SOLZJ = par.SOLZMIN;
                }
                par.JW = par.SOLZJ * 100;
                UPANTEIL();
                par.SOLZLZZ = par.ANTEIL1;
            }
            else
            {
                par.SOLZLZZ = 0;
            }

            // Aufteilung des Betrages nach § 51a EStG auf den LZZ für die Kirchensteuer
            if (par.R > 0)
            {
                par.JW = par.JBMG * 100;
                UPANTEIL();
                par.BK = par.ANTEIL1;
            }
            else
            {
                par.BK = 0;
            }
        }

        /// <summary>
        /// Anteil von Jahresbeträgen für einen LZZ (§ 39b Absatz 2 Satz 9 EStG)
        /// </summary>
        private void UPANTEIL()
        {
            if (par.LZZ == 1)
            {
                par.ANTEIL1 = par.JW;
            }
            else if (par.LZZ == 2)
            {
                par.ANTEIL1 = par.JW / 12;
                par.ANTEIL1 = Math.Floor((par.ANTEIL1) * 100) / 100; // abrunden auf ganze Cent
            }
            else if (par.LZZ == 3)
            {
                par.ANTEIL1 = par.JW * 7 / 360;
                par.ANTEIL1 = Math.Floor((par.ANTEIL1) * 100) / 100; // abrunden auf ganze Cent
            }
            else
            {
                par.ANTEIL1 = par.JW / 360;
                par.ANTEIL1 = Math.Floor((par.ANTEIL1) * 100) / 100; // abrunden auf ganze Cent
            }
        }

        /// <summary>
        /// Berechnung sonstiger Bezüge ohne Vergütung für mehrjährige Tätigkeit
        /// </summary>
        public void MSONST()
        {
            par.LZZ = 1;
            if (par.ZMVB == 0)
            {
                par.ZMVB = 12;
            }
            if (par.SONSTB == 0 && par.MBV == 0)
            {
                par.VKVSONST = 0;
                par.LSTSO = 0;
                par.STS = 0;
                par.SOLZS = 0;
                par.BKS = 0;
            }
            else
            {
                MOSONST();
                UPVKV();
                par.VKVSONST = par.VKV;
                par.ZRE4J = (par.JRE4 + par.SONSTB) / 100;
                par.ZVBEZJ = (par.JVBEZ + par.VBS) / 100;
                par.VBEZBSO = par.STERBE;
                MRE4SONST();
                MLSTJAHR();
                par.WVFRBM = (par.ZVE - par.GFB) * 100;

                if (par.WVFRBM < 0)
                {
                    par.WVFRBM = 0;
                }
                UPVKV();
                par.VKVSONST = par.VKV - par.VKVSONST;
                par.LSTSO = (par.ST * 100);

                //Anmerkung: Negative Lohnsteuer auf sonstigen Bezug wird nicht zugelassen.
                par.STS = (par.LSTSO - par.LSTOSO) * par.F;
                par.STS = Math.Floor(par.STS); // abrunden auf ganze Euro
                STSMIN();
            }
        }

        /// <summary>
        /// Berechnung des SolZ auf sonstige Bezüge
        /// </summary>
        private void STSMIN()
        {
            if (par.STS < 0)
            {
                if (par.MBV == 0) { }
                else
                {
                    par.LSTLZZ = par.LSTLZZ + par.STS;
                    if (par.LSTLZZ < 0)
                    {
                        par.LSTLZZ = 0;
                    }

                    par.SOLZLZZ = par.SOLZLZZ + par.STS * 5.5 / 100;

                    if (par.SOLZLZZ < 0)
                    {
                        par.SOLZLZZ = 0;
                    }

                    par.BK = par.BK + par.STS;

                    if (par.BK < 0)
                    {
                        par.BK = 0;
                    }
                }
                par.STS = 0;
                par.SOLZS = 0;
            }
            else
            {
                MSOLZSTS();
            }
            if (par.R > 0)
            {
                par.BKS = par.STS;
            }
            else
            {
                par.BKS = 0;
            }
        }

        /// <summary>
        /// Berechnung des SolZ auf sonstige Bezüge
        /// </summary>
        private void MSOLZSTS()
        {
            if (par.ZKF > 0)
            {
                par.SOLZSZVE = par.ZVE - par.KFB;
            }
            else
            {
                par.SOLZSZVE = par.ZVE;
            }
            if (par.SOLZSZVE < 1)
            {
                par.SOLZSZVE = 0;
                par.X = 0;
            }
            else
            {
                par.X = par.SOLZSZVE / par.KZTAB;
                par.X = Math.Floor(par.X); // abrunden auf ganze Euro
            }
            if (par.STKL < 5)
            {
                UPTAB24();
            }
            else
            {
                MST5_6();
            }

            par.SOLZSBMG = par.ST * par.F;
            par.SOLZSBMG = Math.Floor(par.SOLZSBMG); // abrunden auf ganze Euro

            if (par.SOLZSBMG > par.SOLZFREI)
            {
                par.SOLZS = par.STS * 5.5 / 100;
                par.SOLZS = Math.Floor((par.SOLZS) * 100) / 100; // abrunden auf ganze Cent
            }
            else
            {
                par.SOLZS = 0;
            }
        }

        /// <summary>
        /// Berechnung der Vergütung für mehrjährige Tätigkeit nach § 39b Absatz 3 Satz 9 und 10 EStG
        /// </summary>
        public void MVMT()
        {
            if (par.VKAPA < 0)
            {
                par.VKAPA = 0;
            }
            if ((par.VMT + par.VKAPA) > 0)
            {
                // Steuerberechnung ohne Vergütung für mehrjährige Tätigkeit
                if (par.LSTSO == 0)
                {
                    MOSONST();

                    par.LST1 = par.LSTSO;
                }
                else
                {
                    par.LST1 = par.LSTSO;
                }
                // Vergleichsberechnung der Vergütung für mehrjährige Tätigkeit als sonstiger Bezug
                par.VBEZBSO = (par.STERBE + par.VKAPA);
                par.ZRE4J = (par.JRE4 + par.SONSTB + par.VMT + par.VKAPA) / 100;
                par.ZVBEZJ = (par.JVBEZ + par.VBS + par.VKAPA) / 100;
                par.KENNVMT = 2;
                MRE4SONST();

                MLSTJAHR();
                par.LST3 = (par.ST * 100);

                //Steuerberechnung mit Vergütung für mehrjährige Tätigkeit
                MRE4ABZ();
                par.ZRE4VP = par.ZRE4VP - par.JRE4ENT / 100 - par.SONSTENT / 100;
                par.KENNVMT = 1;
                MLSTJAHR();
                par.LST2 = (par.ST * 100);

                par.STV = par.LST2 - par.LST1;
                par.LST3 = par.LST3 - par.LST1;

                if (par.LST3 < par.STV)
                {
                    par.STV = par.LST3;
                }
                if (par.STV < 0)
                {
                    //Anmerkung: Negative Steuer auf mehrjährigen Bezug wird nicht zugelassen.
                    par.STV = 0;
                }
                else
                {
                    par.STV = par.STV * par.F;
                    par.STV = Math.Floor(par.STV); // abrunden auf ganze Euro
                }

                par.SOLZVBMG = par.STV / 100 + par.JBMG;

                if (par.SOLZVBMG > par.SOLZFREI)
                {
                    par.SOLZV = par.STV * 5.5 / 100;
                    par.SOLZV = Math.Floor((par.SOLZV) * 100) / 100; // abrunden auf ganze Cent
                }
                else
                {
                    par.SOLZV = 0;
                }
                if (par.R > 0)
                {
                    par.BKV = par.STV;
                }
                else
                {
                    par.BKV = 0;
                }
            }
            par.STV = 0;
            par.SOLZV = 0;
            par.BKV = 0;
        }

        /// <summary>
        /// Sonderberechnung ohne sonstige Bezüge für Berechnung bei sonstigen Bezügen oder Vergütung für mehrjährige Tätigkeit
        /// </summary>
        private void MOSONST()
        {
            par.ZRE4J = par.JRE4 / 100;
            par.ZVBEZJ = par.JVBEZ / 100;
            par.JLFREIB = par.JFREIB / 100;
            par.JLHINZU = par.JHINZU / 100;
            MRE4();
            MRE4ABZ();
            par.ZRE4VP = par.ZRE4VP - par.JRE4ENT / 100;
            MZTABFB();
            par.VFRBS1 = (par.ANP + par.FVB + par.FVBZ) * 100;
            MLSTJAHR();
            par.WVFRBO = (par.ZVE - par.GFB) * 100;
            if (par.WVFRBO < 0)
            {
                par.WVFRBO = 0;
            }
            par.LSTSO = (par.ST * 100);
        }

        /// <summary>
        /// Sonderberechnung mit sonstigen Bezügen für Berechnung bei sonstigen Bezügen oder Vergütung für mehrjährige Tätigkeit
        /// </summary>
        private void MRE4SONST()
        {
            MRE4();
            par.FVB = par.FVBSO;
            MRE4ABZ();
            par.ZRE4VP = par.ZRE4VP + par.MBV / 100 - par.JRE4ENT / 100 - par.SONSTENT / 100;
            par.FVBZ = par.FVBZSO;
            MZTABFB();
            par.VFRBS2 = (par.ANP + par.FVB + par.FVBZ) * 100 - par.VFRBS1;
        }

        /// <summary>
        /// Tarifliche Einkommensteuer (§ 32a EStG)
        /// </summary>
        private void UPTAB24()
        {
            if (par.X < (par.GFB + 1))
            {
                par.ST = 0;
            }
            else if (par.X < 17006)
            {
                par.Y = ((par.X - par.GFB) / 10000);
                par.RW = (par.Y * 922.98);
                par.RW = par.RW + 1400;
                par.ST = par.RW * par.Y;
                par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
            }
            else if (par.X < 66761)
            {
                par.Y = ((par.X - 17005) / 10000);
                par.RW = (par.Y * 181.19);
                par.RW = par.RW + 2397;
                par.RW = par.RW * par.Y;
                par.ST = (par.RW + 1025.38);
                par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
            }
            else if (par.X < 277826)
            {
                par.ST = (par.X * 0.42 - 10602.13);
                par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
            }
            else
            {
                par.ST = (par.X * 0.45 - 18936.88);
                par.ST = Math.Floor(par.ST); // abrunden auf ganze Euro
            }
            par.ST = par.ST * par.KZTAB;
        }

        /// <summary>
        /// Array als Maßgebender Prozentsatz, Höchstbetrag des Versorgungsfreibetrags und Zuschlag zum Versorgungsfreibetrag gem. § 19 Absatz 2 EStG
        /// </summary>
        public static double[,] TAB123 = {
            { 2005, 1, 0.400, 3000, 900 },
            { 2006, 2, 0.384, 2880, 864 },
            { 2007, 3, 0.368, 2760, 828 },
            { 2008, 4, 0.352, 2640, 792 },
            { 2009, 5, 0.336, 2520, 756 },
            { 2010, 6, 0.320, 2400, 720 },
            { 2011, 7, 0.304, 2280, 684 },
            { 2012, 8, 0.288, 2160, 648 },
            { 2013, 9, 0.272, 2040, 612 },
            { 2014, 10, 0.256, 1920, 576 },
            { 2015, 11, 0.240, 1800, 540 },
            { 2016, 12, 0.224, 1680, 504 },
            { 2017, 13, 0.208, 1560, 468 },
            { 2018, 14, 0.192, 1440, 432 },
            { 2019, 15, 0.176, 1320, 396 },
            { 2020, 16, 0.160, 1200, 360 },
            { 2021, 17, 0.152, 1140, 342 },
            { 2022, 18, 0.144, 1080, 324 },
            { 2023, 19, 0.136, 1020, 306 },
            { 2024, 20, 0.128, 960, 288 },
            { 2025, 21, 0.120, 900, 270 },
            { 2026, 22, 0.112, 840, 252 },
            { 2027, 23, 0.104, 780, 234 },
            { 2028, 24, 0.096, 720, 216 },
            { 2029, 25, 0.088, 660, 198 },
            { 2030, 26, 0.080, 600, 180 },
            { 2031, 27, 0.072, 540, 162 },
            { 2032, 28, 0.064, 480, 144 },
            { 2033, 29, 0.056, 420, 126 },
            { 2034, 30, 0.048, 360, 108 },
            { 2035, 31, 0.040, 300, 90 },
            { 2036, 36, 0.032, 240, 72 },
            { 2037, 33, 0.024, 180, 54 },
            { 2038, 34, 0.016, 120, 36 },
            { 2039, 35, 0.008, 60, 18 },
            { 2040, 36, 0.000, 0, 0 }
        };

        /// <summary>
        /// Array als Maßgebender Prozentsatz und Höchstbetrag des Altersentlastungsbetrags gem. § 24a EStG
        /// </summary>
        public static double[,] TAB45 = {
            { 2005, 1, 0.400, 1900 },
            { 2006, 2, 0.384, 1824 },
            { 2007, 3, 0.368, 1748 },
            { 2008, 4, 0.352, 1672 },
            { 2009, 5, 0.336, 1596 },
            { 2010, 6, 0.320, 1520 },
            { 2011, 7, 0.304, 1444 },
            { 2012, 8, 0.288, 1368 },
            { 2013, 9, 0.272, 1292 },
            { 2014, 10, 0.256, 1216 },
            { 2015, 11, 0.240, 1140 },
            { 2016, 12, 0.224, 1064 },
            { 2017, 13, 0.208, 988 },
            { 2018, 14, 0.192, 912 },
            { 2019, 15, 0.176, 836 },
            { 2020, 16, 0.160, 760 },
            { 2021, 17, 0.152, 722 },
            { 2022, 18, 0.144, 684 },
            { 2023, 19, 0.136, 646 },
            { 2024, 20, 0.128, 608 },
            { 2025, 21, 0.120, 570 },
            { 2026, 22, 0.112, 532 },
            { 2027, 23, 0.104, 494 },
            { 2028, 24, 0.096, 456 },
            { 2029, 25, 0.088, 418 },
            { 2030, 26, 0.080, 380 },
            { 2031, 27, 0.072, 342 },
            { 2032, 28, 0.064, 304 },
            { 2033, 29, 0.056, 266 },
            { 2034, 30, 0.048, 228 },
            { 2035, 31, 0.040, 190 },
            { 2036, 32, 0.032, 152 },
            { 2037, 33, 0.024, 114 },
            { 2038, 34, 0.016, 76 },
            { 2039, 35, 0.008, 38 },
            { 2040, 36, 0.000, 0 }
        };

        public double TABJ(int tabIndex, double[,] TAB123)
        {
            // Gültigkeit von J prüfen
            if (par.J <= 0 || par.J > TAB123.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(par.J), "J ist außerhalb des Bereichs des Arrays.");
            }

            // Suche die Zeile, in der die zweite Spalte (J) dem gesuchten Wert entspricht.
            for (int i = 0; i < TAB123.GetLength(0); i++)
            {
                if (TAB123[i, 1] == par.J)
                {
                    // Wenn gefunden, gib den Wert aus der Spalte (TAB1, TAB2 oder TAB3) zurück.
                    switch (tabIndex)
                    {
                        case 0: return TAB123[i, 0]; // Jahr des Versorgungsbeginns
                        case 1: return TAB123[i, 2]; // TAB1 // Satz
                        case 2: return TAB123[i, 3]; // TAB2 // Höchstbetrag
                        case 3: return TAB123[i, 4]; // TAB3 // Zuschlag
                        default: throw new ArgumentOutOfRangeException(nameof(tabIndex), "Ungültiger Wert für tabIndex.");
                    }
                }
            }
            // Wenn J im Array nicht gefunden wurde
            throw new Exception($"Keine Zeile mit dem Wert J = {par.J} gefunden.");
        }

        public double TABK(int tabIndex, double[,] TAB45)
        {
            // Gültigkeit von K prüfen
            if (par.K <= 0 || par.K > TAB45.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(nameof(par.K), "K ist außerhalb des Bereichs des Arrays.");
            }

            // Sucht die Zeile, in der die zweite Spalte (K) dem gesuchten Wert entspricht.
            for (int i = 0; i < TAB45.GetLength(0); i++)
            {
                if (TAB45[i, 1] == par.K)
                {
                    // gibt den Wert aus der Spalte (TAB4 oder TAB5) zurück.
                    switch (tabIndex)
                    {
                        case 0: return TAB45[i, 0]; // Auf die Vollendung des 64. Lebensjahres folgendes Kalenderjahr
                        case 1: return TAB45[i, 2]; // TAB4 // Satz
                        case 2: return TAB45[i, 3]; // TAB5 // Höchstbetrag
                        default: throw new ArgumentOutOfRangeException(nameof(tabIndex), "Ungültiger Wert für tabIndex.");
                    }
                }
            }
            // Wenn K im Array nicht gefunden wurde
            throw new Exception($"Keine Zeile mit dem Wert K = {par.K} gefunden.");
        }

    }
}
