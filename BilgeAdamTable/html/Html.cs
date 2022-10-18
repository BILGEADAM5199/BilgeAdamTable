//< !DOCTYPE html >
//< html lang = "tr" >
//< head >
//    < meta charset = "UTF-8" >
//    < meta http - equiv = "X-UA-Compatible" content = "IE=edge" >
//    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
//    < title > Document </ title >
//    < link rel = "stylesheet" href = "style.css" >
//    < script >
//        function addRow(eklemeTable) {
//    var table = document.getElementById(eklemeTable);

//    var rowCount = table.rows.length;
//    var row = table.insertRow(rowCount);

//    var cell1 = row.insertCell(0);
//    var element1 = document.createElement("input");
//    element1.type = "item";
//    element1.name = "itmbox[]";
//    cell1.appendChild(element1);

//    var cell2 = row.insertCell(0);
//    cell2.innerHTML = rowCount + 0;

//    var cell3 = row.insertCell(2);
//    var element2 = document.createElement("input");
//    element2.type = "text";
//    element2.name = "txtbox[]";
//    cell3.appendChild(element2);
//}
//    </ script >
//</ head >
//< body contenteditable = "false" >
//    < h1 > Ercan Hocama<br> Sevgiler...</h1>
//    <h3>Akın Kalay Sunar:)</ h3 >
//    < input type = "button" value = "Ekle" onclick = "addRow('eklemeTable')" id = "button" >
//    < table id = "eklemeTable" >
//        < tr >
//            < td > SıraNo:</ td >
//            < td > Item </ td >
//            < td > Qty </ td >
//        </ tr >
//        < tr >
//            < td > 1 </ td >
//            < td >< input type = "item" name = "itm" ></ td >
//            < td >< input type = "text" ></ td >
//        </ tr >
//    </ table >
//</ body >
//</ html >