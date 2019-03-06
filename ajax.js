$.ajax({
    url: 'API_URL',
    type: 'METHOD', //GET, POST, PUT, DELETE = CRUD --- OPTION
    data: 'username=user1;',
    contentType: "application/json", //MIME Type
    dataType: 'jsonp', //html, tex, json, jsonp
    success: function(data) {

        ///what to happen when success
    },
    error: function(e) {
        //called when is an error
    }
});
