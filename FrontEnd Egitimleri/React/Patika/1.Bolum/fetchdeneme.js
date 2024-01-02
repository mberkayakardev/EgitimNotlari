
// fetch('https://dummyjson.com/products/1')
// .then(res => res.json())
// .then(json => console.log(json));


// fetch('https://dummyjson.com/products/1').then(res => fonksyion1(res)).then( (sonuc) => {console.warn(sonuc)} );


var fonksyion1 = (res) => {
   var degisken = res.json();
   return degisken;
}



// fetch('https://dummyjson.com/products/1').then(res1 => fonksyion1(res1)).then( (sonuc1) => {console.warn(sonuc1); return null} ).
// then( (x) => 
//     fetch("https://dummyjson.com/products/2")).then( (y) =>y.json()).then((z) => {console.log(z)});


// aşağıdaki kod görüldüğü gibi 3 tane iç içe olması ilçin bir önrektir 
// fetch('https://dummyjson.com/products/1').
// then(res1 => fonksyion1(res1)).
// then( (sonuc1) => {console.warn(sonuc1);
//     fetch("https://dummyjson.com/products/2").
//     then( (y) =>y.json()).
//     then((z) => {console.log(z);
//         fetch("https://dummyjson.com/products/2").
//         then( (q) => q.json()).
//         then( (z) => {console.log(z);})
//     });
// });



const f1 = () => {
    fetch('https://dummyjson.com/products/1').
    then(res1 => fonksyion1(res1)).
    then( (sonuc1) => {console.log(sonuc1);})};

const f2 = () => {
    fetch('https://dummyjson.com/products/2').
    then(res1 => fonksyion1(res1)).
    then( (sonuc1) => {console.log(sonuc1);
})};

const f3 = () => {
    fetch('https://dummyjson.com/products/3').
    then(res1 => fonksyion1(res1)).
    then( (sonuc1) => {console.log(sonuc1);
})};



async function f4() {
    
     await f1();
     await f2();

}


f4();









 


    