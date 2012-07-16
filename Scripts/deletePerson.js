function deletePerson(id) {
    var jsonData = "{'Id':'" + id + "'}";
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "Default.aspx/deletePerson",
        data: jsonData,
        success: function (data) { successCallback2(data, id); },
        error: function (data) { failureCallback(data); }
    });
}
function successCallback2(data, id) {
    $("tr.person#" + id).fadeOut();
}

function failureCallback2(data) {
    alert('Request failure.');
}