 export function Topla(sayi1, sayi2) {
    return sayi1 + sayi2;         // sayi1 ve sayi2 toplamını döndürür
  }

  export  function Cikar(sayi1, sayi2) {
    return sayi1 - sayi2;         // sayi1 ve sayi2 toplamını döndürür
  }
 
  export function Carp (sayi1, sayi2)
  {
    return sayi1 * sayi2
  }

  export  function Bol (sayi1 , sayi2){
    if (sayi1 == 0)
        console.log("ilk sayi sifir olamaz");
    else if (sayi2 ==0)
    console.log("ikinci sayi sifir olamaz");
    else 
        return sayi1/sayi2;

  }

  export  var model = {isim : "Berkay" , Soyisim : "Akar " , dersler : ["Fizik" , "Kimya" , "Matematik" , "Cografya"]};



// export {
//   Topla,
//   Cikar,
//   Carp,
//   Bol,
//   model
// };



// tek tek export etmek yerine anonymous type geçerek te yapabilirdik

// export {
//     Topla,
//     Cikar,
//     Carp,
//     Bol
// }

// yukarıdaki ifade de çalışırdı. 


