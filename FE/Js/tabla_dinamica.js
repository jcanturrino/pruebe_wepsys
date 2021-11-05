function genera_tabla(nom, ape, cor) {
    // Obtener la referencia del elemento body
    var body = document.getElementsByTagName("body")[0];
  
    // Crea un elemento <table> y un elemento <tbody>
    var tabla   = document.createElement("table");
    var tblBody = document.createElement("tbody");

    for (var i = 0; i < 2; i++) {
      
      var hilera = document.createElement("tr");

      var celda = document.createElement("td");
      var textoCelda = document.createTextNode(nom + " "+ ape + " "+ cor);
      celda.appendChild(textoCelda);
      hilera.appendChild(celda);

      tblBody.appendChild(hilera);
    }
  
    tabla.appendChild(tblBody);
  
    body.appendChild(tabla);
}