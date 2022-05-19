var array = [3,1,4,8,6,2,9,5,4,5];


function teilbarvier(array) {
    for(let i = 0; i < array.length; i++)
    {
        if(array[i] % 4 == 0)
        {
            document.getElementById("konsole").innerHTML += array[i];
        }
    }
}
function ungerade(array) {
    let summe = 0;
    for(let i = 0; i < array.length; i++)
    {
        if(array[i] % 2 != 0)
        {
            summe++;
        }
    }
    if(summe != 0)
    {
        document.getElementById("konsole").innerHTML += summe + " mal ist eine ungerade Zahl in dem Array vorhanden";
    }
    else
    {
        document.getElementById("konsole").innerHTML += "Es kommt keine ungerade Zahl in dem Array vor";

    }
}

function gerade(array) {
    let summe = 0;
    for(let i = 0; i < array.length; i++)
    {
        if(array[i] % 2 == 0)
        {
            summe++;
        }
    }
    if(summe != 0)
    {
        document.getElementById("konsole").innerHTML += summe + " mal ist eine gerade Zahl in dem Array vorhanden";
    }
    else
    {
        document.getElementById("konsole").innerHTML += "Es kommt keine gerade Zahl in dem Array vor";

    }
}

function geradeausgabe(array){
    for(let i = 0; i < array.length; i++)
    {
        document.getElementById("konsole").innerHTML += "Ausgabe der gerade Zahlen : ";
        if(array[i] % 2 == 0)
        {
            document.getElementById("konsole").innerHTML += array[i] + " ,";
        }
    }
}

function zweitkleinstestelle(array){
    for(let i = 0; i < array.length; i++)
    {
        
    }
}