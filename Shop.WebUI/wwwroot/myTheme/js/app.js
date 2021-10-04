var productImg = document.getElementById("productImg");

var smallImage = document.getElementsByClassName("small-img");

smallImage[0].onclick = function(){
    productImg.src = smallImage[0].src;
}
smallImage[1].onclick = function(){
    productImg.src = smallImage[1].src;
}
smallImage[2].onclick = function(){
    productImg.src = smallImage[2].src;
}
smallImage[3].onclick = function(){
    productImg.src = smallImage[3].src;
}



