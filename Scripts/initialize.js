function initialize() {
    $('.person').hide().remove();
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        url: "Default.aspx/getAllPersons",
        success: function (data) { successCallback(data); },
        error: function (data) { failureCallback(data); }
    });
}
function successCallback(data) {
    var allresponce = eval(data.d);

    jQuery.each(allresponce, function (i, responce) {
        var temp = getTemplate2();
        temp = temp.replace("[firstname]", responce.FirstName).replace("[lastname]", responce.LastName).replace("[tel]", responce.Telephone).replace("[id]", responce.Id).replace("[id]", responce.Id);
        $('table.psrsonsTable').append(temp);
    });
}

function failureCallback(data) {
    alert('Request failure.');
}
