var deger;

deger = String(123);
console.log(deger, typeof (deger));

deger = String(3.14);
console.log(deger, typeof (deger));

deger = String(true);
console.log(deger, typeof (deger) , deger[0] , deger[1]);

deger = String(false);
console.log(deger, typeof (deger) , deger[0] , deger[1]);

deger = String(function() {console.log()});
console.log(deger, typeof (deger));

deger = String([1,2,3,4,5]);
console.log(deger, typeof (deger));

deger = [1,2].toString();
console.log(deger, typeof (deger));

deger = ([1,2]).toString();
console.log(deger, typeof (deger));

deger = (5).toString()
console.log(deger, typeof (deger));

// veri tiplerini sayılara çevirme 

var deger = Number(123);
var deger = Number(null);
var deger = Number(undefined);




console.log(deger, typeof (deger));
