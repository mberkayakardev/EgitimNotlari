let value;

const value1 = 10;
const value2 = 4;

// Aritmetik Operatörler 

value = value1 + value2;    
value = value1 - value2;
value = value1 * value2;    
value = value1 / value2;    
value = value1 % value2; // Mod operatörü (value 1 in value 2 ye bölümünden kalan ı verecektir.) 10 un 4 e bölümünden kalan 2 dir.

// Math Sınıfı 

value = Math.PI // bizlere pi sayısını verecektir. 3.141592......
value = Math.E // 2.7182......

value = Math.round(3.6);  // son sayı 5 ve 5 ten büyük ise bir üst basamağa yuvarlar, değilse aşağı yuvarlar ve bizlere tam sayı verir. 
value = Math.round(3.51); // 4
value = Math.round(3.50); // 4
value = Math.round(3.49);  // 3

value = Math.ceil(3.2); // ceil gelen büyün ifadeleri bir üst basamaktaki tam sayıya yuvarlar. rounddaki gibi 5 ve 5 ten büyük olma yada küçük olma durumuna bakmaksızın.  // 4
value = Math.ceil(3); // küsütarında bir ifade olmadığı için sabit kalır // 3
value = Math.ceil(3.0); // küsürat yok sabit kalır // 3 
value = Math.ceil(3.01); // küsürat var bir üst basamağa yuvarlar  // 4

value = Math.floor(3.1); // 3  // küsüratlı sayıları bir alta yuvarlar. tamsa aynı şekilde kalır. 
value = Math.floor(3.99); // 3
value = Math.floor(3); // 3 
value = Math.floor(2.9999); //2 

// Floor , Ceil ve Round ondalıklı sayılara etki eder. 

value = Math.sqrt(25); // Karekök aldırır. // 5
value = Math.sqrt(16); // 4 

value = Math.abs(-22); // Mutlak değer // 22
value = Math.abs(-14); // 14 
value = Math.abs(0); // 0
value = Math.abs(5); // 5 

value = Math.pow(5,2); // üst almaya yarar. // 25 
value = Math.pow(25,1/2); //  5
value = Math.pow(125,(1/3)); //  5

value= Math.min(1,2,3,4,5,6) // maximum ve minimum değerleri getirir. Parametre olarak sadece virgüller ile sayılar alır. içeriisne dizi vs atamazsın
value= Math.max(1,2,3,4,5,6)

value = Math.random() // rastgele sayı üretir. 0 ile 1 arası değer üretir. 0 dahildir. 1 dahil değildir. 
value = Math.random() * 50  // rastgele sayı üretir. 50 ile 0 arası değer üretir. 0 dahildir. 50 dahil değildir.
value = Math.random() * 50 + 3   // rastgele sayı üretir. 50 ile 3 arası değer üretir. 3 dahildir. 50 dahil değildir. 
value = Math.floor( Math.random() * 50 + 3 )  // 3 ile 53 arasında sayı üretilecektir. Tam sayılar üretilecekit üstte ondalıklı sayılar üretilecektir. 
 

console.log(value);