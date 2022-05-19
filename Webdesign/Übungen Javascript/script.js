writeLine("hallo");
writeLine("<br>");
writeLine("<br>");
leseGeldBetrag("123123");
writeLine("<br>");
writeLine("<br>");
entferneZiffernUndSonderzeichen("+++++-,.0123456789Hallo hat alles geklappt? Keine der angegebenen Sonderzeichen?");
writeLine("<br>");
writeLine("<br>");
dollarZuEuro("100");
writeLine("<br>");
writeLine("<br>");
leseGeldbetragInEuro("$200");
writeLine("<br>");
writeLine("<br>");
istDollar("200 Dollar");
writeLine("<br>");
writeLine("<br>");
istEuro("200 Euro");


function ZeigVersKonsole() 
{
    var x = document.getElementById("konsole");
    if (x.style.display === "none") {
      x.style.display = "block";
    } else {
      x.style.display = "none";
    }
}                                           //Funktion zum Versecken/Zeigen der Konsole
function writeLine(konsolenAusgabe) {
    document.querySelector("#konsole").innerHTML += konsolenAusgabe;
}                                           //Writeausgabe wird in Konsole div Element geschrieben

function leseGeldBetrag(eingabeText){       //String wird zur Number umgewandelt mit 2 Nachkommastellen
    document.getElementById("konsole").innerHTML += Number.parseFloat(eingabeText).toFixed(2);
}
function entferneZiffernUndSonderzeichen(eingabeText){  //Ziffern und bestimmte Sonderzeichen werden entfernt
    let ausgabe = eingabeText;
    ausgabe = ausgabe.replaceAll("+"," ");
    ausgabe = ausgabe.replaceAll("-"," ");
    ausgabe = ausgabe.replaceAll(","," ");
    ausgabe = ausgabe.replaceAll("."," ");
    for(var i = 0; i < 10; i++)
    {
        ausgabe = ausgabe.replace(`${i}`," ");
    }
    ausgabe.trim();
    document.getElementById("konsole").innerHTML += ausgabe;
}

function istEuro(eingabeText)
{
    let x = "euro"; 
    if(eingabeText.location.href.indexOf(x) > -1) 
    {
        document.getElementById("konsole").innerHTML += eingabeText.toPrecision(2) + " Euro eingegeben";
    }
}
function istDollar(eingabeText)
{

}
function dollarZuEuro(dollarBetrag)     //Übergebener Betrag wird von Dollar in Euro umgerechnet
{
    dollarBetrag *= 0.83;
    document.getElementById("konsole").innerHTML += dollarBetrag;
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
        betrag += " €. Betrag wurde automatisch umgewandelt";
    }
    else
    {
        betrag += " $. Betrag wurde nicht umgewandelt";
    }
    document.getElementById("konsole").innerHTML += betrag;
}
