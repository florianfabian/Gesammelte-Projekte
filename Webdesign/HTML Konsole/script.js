
//Skriptfolge aller Funktionen

writeLine("<b id='titel' class='titel'>KONSOLENAUSGABE EINIGER FUNKTIONEN</b><br><br>");
    schreibeEinigeZahlen();
                                                    writeLine("<br><br>");
    schreibeVieleZahlen();
                                                    writeLine("<br><br>");
    schreibeZahlenBis(5);
                                                    writeLine("<br><br>");
    schreibeSummeBis(10);
                                                    writeLine("<br><br>");
    schreibeFakultaet(9);
                                                    writeLine("<br><br>");
    schreibeQuadratZahlenFolge(13);
                                                    writeLine("<br><br>");
    schreibeBinaerZahlenFolge(8);
                                                    writeLine("<br><br>");
    schreibeBinaerZahlenFolgeRueckwaerts(8);
                                                    writeLine("<br><br>");
    schreibeFibonacciFolge(8);
                                                    writeLine("<br><br>");
    readLine("Bitte geben Sie Ihren Namen ein: ");
                                                    writeLine("<br><br>");
    writeErrorLine();
                                                    writeLine("<br><br>");



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
function schreibeEinigeZahlen() {
    writeLine("<b>Einige Zahlen    | schreibeEinigeZahlen():</b><br> 4,   14,   44");
}                                           //Einige Zahlen werden in der Konsole ausgegeben
function schreibeVieleZahlen() {
    writeLine("<b>Einfach nur viele Zahlen   | schreibeVieleZahlen(): </b><br>")
    for(let i= 0; i <= 20; i++)
    {
        writeLine(i);
        if(i!=20)
        {
        writeLine(", ")
        }
    }
}                                           //Viele Zahlen werden in der Konsole ausgegeben
function schreibeZahlenBis(n){
    writeLine("<b>Zahlen bis " + n + "    | schreibeVieleZahlen("+ n +")</b>:<br> ");
    for(let i=0; i<=n; i++)
    {
        writeLine(i);
        if(i!=n)
        {
        writeLine(", ")
        }
    }
}                                           //Zahlen bis Parameter "n" werden in der Konsole ausgegeben
function schreibeSummeBis(n){
    var c = 0;
    for(let i=0; i<=n; i++)
    {
        c = c + i;
    }
    writeLine("<b>Summe bis " + n + " | schreibeSummeBis("+ n +")</b>:<br> ");
    writeLine(c);
}                                           //Summe der Zahlen bis Parameter "n" werden in der Konsole ausgegeben
function schreibeFakultaet(n){
    writeLine("<b>Fakultät von " + n + " | schreibeFakultaet("+ n +")</b>:<br> ");
    var c = 1;
    for(let i=1; i<=n; i++)
    {
        c = i * c;
    }
    writeLine(c);
}                                           //Fakultät des Parameters "n" wird ausgegeben
function schreibeQuadratZahlenFolge(n){
    writeLine("<b>Quadratzahlenfolge bis " + n + " | schreibeQuadratZahlenFolge("+ n +")</b>:<br> ");
    for(let i=0; i<=n; i++)
    {
        c = i * 2;
        writeLine(c);
        if(i!=n)
        {
        writeLine(", ")
        }
    }
}                                           //Quadratzahlenfolge bis Parameter "n" wird ausgegeben
function schreibeBinaerZahlenFolge(n){
    writeLine("<b>Binärzahlenfolge bis Potenz " + n + " | schreibeBinaerZahlenFolge("+ n +")</b>:<br> ");
    for(let i=0; i<=n; i++)
    {
        c = Math.pow(2, i);
        writeLine(c);
        if(i!=n)
        {
        writeLine(", ")
        }
    }
}                                           //Binärzahlenfolge bis Parameter "n" wird ausgegeben
function schreibeBinaerZahlenFolgeRueckwaerts(n){
    writeLine("<b>Binärzahlenfolge rückwärts von Potenz " + n + " | schreibeBinaerZahlenFolgeRueckwaerts("+ n +")</b>:<br> ");
    for(let i=n; i>=0; i--)
    {
        c = Math.pow(2, i);
        writeLine(c);
        if(i!=0)
        {
        writeLine(", ")
        }
    }
}                                           //Binärzahlenfolge von Parameter "n" bis 0 wird ausgegeben
function schreibeFibonacciFolge(n){
    writeLine("<b>Fibonaccizahlen mit Ryhtmus fib(" + n + ") | schreibeFibonacciFolge("+ n +")</b>:<br> ");
    var a = 0;
    var b = 1;
    for(let i=0; i<=n; i++)
    {
        temp = a;
        a = b;
        b = temp + b;
        writeLine(a);
        if(i!=n)
        {
        writeLine(", ")
        }
    }
}                                           //Fibonaccifolge wird im Rythmus des Parameters "n" ausgegeben
function readLine(aufforderungsText){
    c = window.prompt(aufforderungsText, "");
    writeLine("<b>Ihr Name ist | readLine("+ c +"): </b> <br>" + c);
}                                           //Besucher der Website muss Eingabe tätigen
function writeErrorLine(){
    writeLine("<b>writeErrorLine():</b><br>")
    writeLine("<b><font color=red>ERROR ERROR ERROR ERROR ERROR </font></b> <br>");
}                                           //Error wird ausgegeben, Design nicht ausgelagert