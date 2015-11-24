var StudentModule = (function () {

    // Return anything that you want to expose outside the closure
    return {
        getStudents: function (callback) {

            $.ajax({
                type: "GET",
                dataType: "json",
                url: "http://conapi2.azurewebsites.net/api/Students",
                success: function (data) {
                    callback(data);
                }
            });

        }
    };

}());