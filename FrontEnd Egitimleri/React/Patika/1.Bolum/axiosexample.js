import axios from 'axios'

// // Kullanım tipi 1;


const Getdata =async function()
{
    await axios("https://dummyjson.com/products/1").then((sonuc) => {
        console.log(sonuc.data);
    } );
}

// await Getdata();

var deneme =  await axios("https://dummyjson.com/products/2").data; 
console.log(deneme.data);