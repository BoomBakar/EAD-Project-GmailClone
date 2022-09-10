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

        } else if (element.classList.contains("Send-Reply")) {
            event.preventDefault();
            var parent = element.parentElement.parentElement.parentElement.parentElement;
            var formdata = new FormData();
            var messageNode = parent.children[1].children[0].cloneNode(true);
            messageNode.setAttribute("id", "");
            

            console.log(parent);
            console.log(parent.children[4]);
            formdata.append("threadId", parent.children[4].value);
            formdata.append("SenderEmail", parent.children[5].value);
            formdata.append("RecieverEmail", parent.children[6].value);
            formdata.append("msg", parent.children[7].children[0].children[0].children[0].value);            

            $.ajax({
                method: 'POST', 
                url: "/Message/CreateReply",
                data: formdata,
                contentType: false,
                processData: false,
                success: function (data) {
                    console.log("done creating reply");
                    messageNode.children[1].children[0].innerHTML = formdata["SenderEmail"];
                    messageNode.children[2].children[0].innerHTML = formdata["msg"];
                    parent.children[1].appendChild(messageNode);
                }, error: function () {
                    alert("error in ajax");
                }
            });

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
    document.getElementById('livesearchtags').addEventListener('keyup', function (e) {
        //Run LiveSearch on ever key up 
        LiveSearch();
    });
    function LiveSearch() {
        //Get the input value
        let value = document.getElementById('livesearchtags').value;

        $.ajax({
            type: "POST",
            // You can use the absolute url eg www.site.com/MyControllerName/LiveTagSearch or the relative path live below  
            url: "/Message/LiveTagSearch",
            // Attach the value to a parameter called search
            data: { search: value },
            datatype: "html",
            success: function (data) {
                // Insert the returned search results html into the result element 
                $('#result').html(data);
            }
        });
    }
});

