var a = 5;
console.log(a);

var a = 30; // var anahtar kelimesi ile aynı sayfada aynı scope içeriisnde değişkenler tekrar oluşturulabiliyor. tanımlanabiliyor. Eski değişken silindi.
console.log(a);

a = 40;  // oluşturulmuş bir değere sonradan değer atayabilirsin.
console.log(a); 


let name = "Berkay";
// let name = "AKAR"; // let ile bir daha değişken oluşturamazsın 
console.log(name);
name = "Akar";
console.log(name);


// const constandeger; // ilk atamada değer mecbur verilmek zorunda ve atanan değer bir daha değiştirilemez. ama object tipi ise içerisindeki verilere müdahale edeileiblir
// ama tip olarak değişemez. Zaten genelde modellerde tanımlanır ki tip sabitlemesi yapabilmek için ;
const constandeger = "ilkatama" ;
// constandeger = "asdas"; // hata verir primitive değişken değişemez ama referanst tipte de sadece tip değişemez içeriisndeki verilere müdahale edileiblir.
console.log(constandeger)




const array = [1,2,3,4,5,6];
const array2 = [1,2,3];
array.pop();
array.pop();
array.push("Berkay");
array.push("AKAR");
console.log(array);
array = array2;
console.log(array);

