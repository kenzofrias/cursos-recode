function exibirCategoria(categoria) {
    let elementos = document.getElementsByClassName('produto');
    console.log(elementos);

    for(var i = 0; i < elementos.length; i++){
        console.log(elementos[i].id);

        if(categoria == elementos[i].id){
            elementos[i].style = "display: block";
        }else{
            elementos[i].style = "display: none";
        }
    }
}

let exibirTodos = () =>{
    let elementos = document.getElementsByClassName('produto');
    console.log(elementos);

    for(var i = 0; i < elementos.length; i++){
        elementos[i].style = "display: block";
    }
}

let aumentarImagem = (imagem)=>{
    if(imagem.width == 80){
        imagem.width = 200;
    }else{
        imagem.width = 80;
    }
}