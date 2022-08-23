//const { post } = require("jquery");

$(document).ready(function () {
    var send = $("#send-button");
   
    
    send.click(function (e) {
        e.preventDefault(); // <==stop page refresh==>
        console.log("in composing email");
        var data = $("#ComposingEmail").serialize();

        $.ajax({
            method: 'POST',
            url: "/Message/CreateThread",
            data: data,
            success: function (data) {
                console.log("done creating thread");
            }, error: function () {
                alert("error in ajax");     
            }



        });
    });
});