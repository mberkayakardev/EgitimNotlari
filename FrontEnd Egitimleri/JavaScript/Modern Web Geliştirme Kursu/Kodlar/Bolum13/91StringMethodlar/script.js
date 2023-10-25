let value;

const firstname = "Berkay";
const LastName = "Akar";
const Langs = "C#,Java,JavaScript,Python";

value = firstname + LastName; // iki string toplanabilir.  
console.log(value);

value = firstname.concat(LastName); // bu şekilde de bir birleştirme sağlanabilir. 
console.log(value);

value = LastName.concat(LastName,LastName,LastName,LastName,LastName); // bu şekilde de bir birleştirme sağlanabilir.  istenilen kadar parametre verilebilmektedir. 
console.log(value);

value += " artı esittir operator"; // += operatörü ile de bir birleştirme sağlanabilir. 
console.log(value);

value += 6; // string ile number direkt olarak ta toplanabilir. 
console.log(value);

console.log("Firstname stringi uzunluğu :",firstname.length); // Stringlerin uzunluk bilgisi bu şekilde alınmaktadır. 

console.log(Langs.toUpperCase() , " - ", Langs.toLowerCase()); // ToUpper, ToLower ile aynı işi görmektedir c# taki büyük harf küçük harf dönüşümü

console.log(firstname[0], firstname[1], firstname[2]); // index numaraları ile erişim. 0 da B , 1 De e O indexte hangi karakter varsa o bilgi bize gelir. 

console.log(firstname.indexOf("a"), firstname.indexOf("q") ) ; // içerisine verilen karakterin hangi index sırasında olduğunu belirtecektir. bulursa index değeri döner, bulamazsa  -1 döner
// c# taki gibi case sensetive dir. 
 
console.log(firstname.charAt(0) ) // index numarası ile erişilmekteidr. aslında firstname[1] ile charat(1) aynı şey

console.log(Langs.split(",")); // split içerisine verilen karaktere göre bizlere bir array vermektedir. 

console.log(Langs.replace("Java",".NET")); // ilk ifade aranan , 2. ifade ise aranan yerine değişecek olan ifade 

console.log(Langs.includes(".NET") , Langs.includes("Java") ); // string bir ifadenin içerisinde şu ifade varmı tarzında bir değer dönmektedir.  // c#taki contains ile aynıdır. // Bulursa True , Bulamazsa FAlse döner.  