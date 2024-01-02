import slugify from "slugify"; 
import {Topla,Cikar,Carp,Bol , model} from "./berkay.js"; 


// Dosya import edildi. 

var degisken = slugify("BERKAY AKAR 1966");
console.log(degisken);
var degisken = slugify("BERKAY AKAR BALIKESİR" , ".");
console.log(degisken);

console.log("Berkay Modul Testi : ");
console.log("Topla : ", 5,2, Topla(5,2));
console.log("Çıkar : ", 5,2,Cikar(5,2));
console.log("Çarp : ",Carp(5,2));
console.log("Böl : ",Bol(5,2));
console.log("Model : ",model);


// tek tek export etmek yerine anonymous type geçerek te yapabilirdik

// export {
//     Topla,
//     Cikar,
//     Carp,
//     Bol
// }

// yukarıdaki ifade de çalışırdı. 

