function logComHora(textoQualquer){
    let data = new Date();

    let hora = data.getHours();
    let minuto = data.getMinutes();
    let segundo = data.getSeconds();

    let dia = data.getDay();
    let mes = data.getMonth();
    let ano = data.getFullYear();

    let horaDefinida = hora + ':' + minuto + ':' + segundo;
    let dataCompleta = dia + '/' + mes + '/' + ano;

    console.log('São ' + horaDefinida + ' do dia ' + dataCompleta + ': ' + textoQualquer);
}

logComHora("Tenha um bom dia!");

//conteúdo

logComHora("Tenha um ótimo dia sr(a).");