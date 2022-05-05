writeLine("hallo");
writeLine("<br>");
writeLine("<br>");
leseGeldBetrag("123123");
writeLine("<br>");
writeLine("<br>");
entferneZiffernUndSonderzeichen("+-,.0123456789Hallo hat alles geklappt? Keine der angegebenen Sonderzeichen?");
writeLine("<br>");
writeLine("<br>");

writeLine("<br>");
writeLine("<br>");

writeLine("<br>");
writeLine("<br>");

writeLine("<br>");
writeLine("<br>");
dollarZuEuro("100");


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

function leseGeldBetrag(eingabeText){
    eingabeText / 1;
    document.getElementById("konsole").innerHTML += eingabeText;
}
function entferneZiffernUndSonderzeichen(eingabeText){
    let ausgabe = eingabeText;
    ausgabe = ausgabe.trim("0"-"9");
    ausgabe = ausgabe.trim(".",",","+","-");
    document.getElementById("konsole").innerHTML += ausgabe;
    //replace mit whitespace und danach trim!!!!!!!!!!!!!!!
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
function dollarZuEuro(dollarBetrag)
{
    dollarBetrag *= 0.83;
    document.getElementById("konsole").innerHTML += dollarBetrag;
}
function leseGeldbetragInEuro(eingabeText)
{
    leseGeldBetrag()
}
