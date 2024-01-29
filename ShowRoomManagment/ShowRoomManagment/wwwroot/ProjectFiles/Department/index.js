


$(document).ready(function () {
  
    loadData();

});

function loadData() {
    $.ajax({
        url: 'http://localhost:5215/api/Department/GetDepartments',
        type: "GET",
        data: null,

        success: function (resp) {
            console.log(resp);
        }
    });
}

