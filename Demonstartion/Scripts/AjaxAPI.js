$(function () {
    $("#btnGet").click(function () {
        var person = '{Name: "' + $("#txtName").val() + '" }';
        $.ajax({
            type: "POST",
            url: "/api/API/AjaxMethod",
            data: person,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert("Hello: " + response.Name + ".\nCurrent Date and Time: " + response.DateTime);
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
});