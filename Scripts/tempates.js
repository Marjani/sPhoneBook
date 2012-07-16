
function getTemplate() {
    var temp = '<div class="persons">';
    temp += '<p> <span class="firstname">First Name :</span> <span> [firstname]</span> </p>';
    temp += '<p> <span class="lastname">Last Name :</span> <span> [lastname]</span> </p>';
    temp += '<p> <span class="tel">Telephone :</span> <span> [tel]</span> </p>';
    temp += '</div>';
    return temp;
}

function getTemplate2() {
    var temp = '<tr class="person" id="[id]">';
    temp += '<td><span> [firstname]</span> </td>';
    temp += '<td><span> [lastname]</span> </td>';
    temp += '<td><span> [tel]</span> </td>';
    temp += '<td><a href="javascript:deletePerson([id]);">Del</a></td>';
    temp += '</tr>';
    return temp;
}