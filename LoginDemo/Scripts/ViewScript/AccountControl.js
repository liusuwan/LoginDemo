$(document).ready(function () {
    $("#btn-login").click(function () {
     $.ajax({type: "Get",
             url: "/Account/DoLogin",
             data: {name: 'jack',password:'123456',},
             success: function (msg) {
             if(msg)
             {
             alert("ok");
             }
             }
             });
    });
});