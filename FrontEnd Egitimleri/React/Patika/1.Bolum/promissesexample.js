const getComments = () => {

    return new Promise( (resolve , reject) => {
        console.log("Comments");
    
    });
}


getComments().then( () => {console.log("Bitti")}).catch( e => {console.log("Bir hata oluştu. : " , e )});

// Resolve işlem başarı ile gerçekleşmiş al sana data demektir. 
// Reject ise kod çalışırken bir hata ile karşılaşılmıştır


