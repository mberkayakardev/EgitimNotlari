 // verilen parametredeki ms cinsinden süre bitince verilen fonkisyon çalışır. (func, ms cinsinden süre )

setTimeout(() => {
    console.log("ilk set time out dolmuştur ");
}, 3000 );

// setTimeout(costumfunction, 6000);


// verilen süre sonra sürekli olarak bu fonkisyon çalışmaktadır.
setInterval(costumfunction2, 500);


function costumfunction(){
    console.log("Costumfunct (settimeout2) çalıştı");
}

function costumfunction2(){
    console.log("setinterval çalişti" , new Date().getDate());
}

