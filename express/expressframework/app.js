const express=require('express');
const service=express();


service.listen(3000,()=>{
    console.log("The service is listening");
})