function addPerson() {
    var fname = $('input#fname').val();
    var lname = $('input#lname').val();
    var tel = $('input#tel').val();
    if (lname == "") {
        alert("Last Name is Required!");
        return;
    }
    jsonData = '{ "fname":"' + fname.valueOf() + '", "lname": "' + lname.valueOf() + '" , "tel": "' + tel.valueOf() + '" }';
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "Default.aspx/addPerson",
        data: jsonData,
        success: function (data) { successCallback1(data, fname, lname, tel); },
        error: function (data) { failureCallback1(data); }
    });
}
function successCallback1(data, fname, lname, tel) {
    //initialize();
    var ID = eval(data.d);
    var temp = getTemplate2();
    temp = temp.replace("[firstname]", fname).replace("[lastname]", lname).replace("[tel]", tel).replace("[id]", ID).replace("[id]", ID);
    $('table.psrsonsTable tr:last-child').after(temp).fadeIn();
}
function failureCallback1(data) {
    alert("failed");
}