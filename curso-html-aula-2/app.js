alert("Seja bem vindo!");

function meuNome() {
    alert(document.getElementById("txtNome").value);
}


function validaDataNascimento() {
    if (document.getElementById("txtData").value != "01/01/2010") {
        alert("Sua data de nascimento é diferente da minha!");
    } else {
        alert("Sua data é igual a minha!");
    }
}
