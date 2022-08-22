$(document).ready(function () {
    var send = $("#send-button");
   
    
    send.click(function (e) {
        e.preventDefault(); // <==stop page refresh==>
        console.log("in composing email");
        var data = $("#ComposingEmail").serialize();
        console.log(data);
    });
});