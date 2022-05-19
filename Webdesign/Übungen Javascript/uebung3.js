document.querySelector("#id").addEventListener("click",
    function (event){

        myFunction(event, this);
    
});             //Vorlage für Eventmanagement


/*

Für die uebung 3 kommen folgende Events in Frage:

-change
-click
-focus
-focusout
-load

*/

/*
Aufgabe 1:

Fügen Sie in Ihrer HTML Seite eine Überschrift ein: „Die Bib-Bank“.
• Darunter eine kleinere Überschrift: „Überweisung“.
• Fügen Sie in Ihrer HTML Seite ein InputField mit id = „betragseingabe“ ein. Es soll auch ein Label geben mit der Schrift: „Bitte Geldbetrag eingeben:“
• Über dem InputField soll es einen roten Kasten mit der Meldung: „Überweisungslimit erreicht!“ geben. Dieser soll aber unsichtbar sein!
• Darunter soll es einen Button (id=“überweisungsButton“) mit der Schrift „Überweisung abschließen“ geben.
• Fügen Sie folgende Eventlistener hinzu:

function fügeEventListenerZurBetragsEingabe()
{
// algo
}

function fügeEventListenerZumOkButton() {
//algo
}
*/


function leseGeldBetrag(eingabeText){       //String wird zur Number umgewandelt mit 2 Nachkommastellen
    document.getElementById("konsole").innerHTML += Number.parseFloat(eingabeText).toFixed(2);
}
function leseGeldbetragInEuro(eingabeText)  //LeseGeldBetrag() wird verwendet und dann (falls euro) in Euro umgewandelt
{
    var betrag = leseGeldBetrag(eingabeText);
    var euro = betrag.indexOf("$");
    if(euro!=-1)
    {
        betrag = betrag.replace("$"," ");
        betrag = betrag.trim(); 
        betrag = parseFloat(betrag);
        betrag *= 0.96; /*Wechselkurs vom 12.05.2022*/
        betrag += " €. Betrag wurde umgewandelt";
    }
    else
    {
        betrag += " Betrag wurde nicht umgewandelt, ist Euro";
    }
    return Number.parseFloat(betrag).toFixed(2);
}
function fügeEventListenerZurBetragsEingabe()
{
    document.getElementById("ueberweisungsButton").addEventListener("click", 
                    function changeOne(){
                        let uebergabe = "";
                        uebergabe += document.getElementById("betragseingabe").value;
                        let money = leseGeldbetragInEuro(uebergabe);
                        money = num.toString();
                        money += "<br>"
                        money += "Überweisung abgeschlossen";
                        document.getElementById("konsole").innerHTML += money;
                    });
}
function fügeEventListenerZumOkButton() 
{

}