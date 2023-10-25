// Tekli Yorum Satırı 

/*
    Çoklu yorum satırı 
*/ 


var a = 20;
var b = 40;
console.log(a,b);

// iki tür veri tipi 2 ye ayrılır primitive ( ilkel ) object ( reference )

// 1. ilkel veri tipleri :

// 1.1. Sayılar 

var a = 10 ;
var b = 25 ; 
var c = 3.14 ; 
console.log(typeof(a) , typeof(b) , typeof(c));

// 1.2. String 

var a = "Berkay";
var b = 'Berkay';
console.log(a+b , "Virgüllü : ",  a,b);
console.log( typeof(a+b) , typeof(a) ,typeof(b));


// 1.3. Boolean 
// Koşullarda kullanılacaktır. 

var a = true;
var b = false;
var c = 1==1;
var d = 1!=2;
console.log (a,b,c,d);
console.log ( typeof(a) , typeof(b), typeof(c) , typeof(d) );


// 1.4. Null Veri Tipi 

var a = null; // a nın boş bir değer taşıdığını belirtir. 
console.log ("a nın değeri " , a , " a nın tipi ", typeof(a));
// primitive bir veri tipi olmasına rağmen object şeklinde yazmaktadır. bu aslında bir bug. 
// Boş değer işte bildiğimiz c# taki gibi


// 1.5. Undefined;
// bir değişken oluşturulduğunda değer verilmediğinde undefined olarak karşımıza çıkacaktır.

var q;
console.log(q , typeof(q));


// 2. Referans veri tipleri :

// 2.1. Arraylar

var numbers = [1,2,3,4,5] ;// birden fazla değeri biriktirmek için kullandığımız veri tipleridir  arraylar
console.log(numbers, typeof(numbers) , numbers[0] , numbers.length); // Referans tiptir

// 2.2. Kendi Objelerimiz

var personel = { name :"Berkay", 
                surname : "Akar", 
                age : 24,
                lesson : ["Türkçe", "Matametik", "Fizik", "Cografya"]
};
console.log(typeof(personel), personel, personel.name , personel.surname, personel.lesson, personel.lesson[0]);

// 2.3. DateObject 

var date = new Date();
console.log(date, typeof(date),date.getFullYear(), "getdate çiktisi : " , date.getDay());


// 2.4. Fonkisyonlar
// Fonkisyonlar bir verilere atanabilir.

var fonkisyonum = function(){
    console.log("selamlama");
};

fonkisyonum();
fonkisyonum; // bu şekil bir çağırım yoktur.


console.log(fonkisyonum(),
            typeof(fonkisyonum), 
            typeof(fonkisyonum()), 
            fonkisyonum // Console.log içerisinde bu şekilde basaran text şeklinde fonkisyon içeriğin gözükür. 
            );


