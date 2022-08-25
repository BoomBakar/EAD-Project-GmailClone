//const { post } = require("jquery");

$(document).ready(function () {
    var send = $("#send-button");
   
    $(document).unbind('click').click(function (event) {
        var element = event.target;

        if (element.classList.contains("EmailOpener")) {
            
            if (element.tagName == "H3" || element.tagName == "H4" || element.tagName == "p") {
                var form = element.parentElement.parentElement.parentElement;
            } else if (element.tagName == 'DIV') {
                if (element.classList.contains("EmailOpenerParent")) {
                    var form = element.parentElement;
                } else {
                    var form = element.parentElement.parentElement;
                }
                
            }
            var input = document.getElementById("curUserEmail").value;
            form.children[2].setAttribute("value", input);
            var child = form.children[3];
            console.log(child);
            child.click();
            
        }
       
    });
    send.unbind('click').click(function (e) {
        e.preventDefault(); // <==stop page refresh==>
        console.log("in composing email");
        var data = $("#ComposingEmail").serialize();

        $.ajax({
            method: 'POST',
            url: "/Message/CreateThread",
            data: data,
            success: function (data) {
                console.log("done creating thread");
                $("#RedirectToInbox").trigger("click");
            }, error: function () {
                alert("error in ajax");     
            }



        });
    });
});

