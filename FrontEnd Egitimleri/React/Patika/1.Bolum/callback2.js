const fonkisyon = function(){
    console.log("Selamin aleyküm");
}

// fonkisyon();


// bu fonkisyonu başka bir fonkisyona parametre olarak gönderip kurala göre çalıştırmaya çalışalım.
const fonkisyon2 = function(cm, donmesayisi){
    
    for (let i = 0 ; i < donmesayisi ; i++)
    {
        wait(2000); // beklettim;
        console.log("Bir saniye bekledi");
        cm();
    }
}

fonkisyon2(fonkisyon,5);
 
function wait(ms){
    var start = new Date().getTime();
    var end = start;
    while(end < start + ms) {
      end = new Date().getTime();
   }
 }

 