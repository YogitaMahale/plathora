var datatable;
$(document).ready(function () {


    loadtable();
});

function loadtable() {
    datatable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/User/GetALL"
            // "type": "GET",
            //"datatype": "json"
        },
        "columns": [
            { "data": "name", "width": "30% " },

            { "data": "email", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            //{ "data": "company.name", "width": "15%" },
            { "data": "role", "width": "15%" },
            {
                "data": {
                    id: "id", lockoutEnd: "lockoutEnd"
                },
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        return `
<div class="text-center">

    <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Lockunlock('${data.id}')>
       <i class="fas fa-lock-open"></i> 
    </a>

<a href="/Admin/User/Edit/${data.id}" class="btn btn-sm btn-success text-white" style="cursor:pointer">
    <i class="fas fa-edit"></i>
         
    </a>

 
 <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Delete("/Admin/User/Delete/${data.id}")>
        <i class="far fa-trash-alt"></i> 
    </a>
</div>`



                    }
                    else {
                        return `
<div class="text-center">

    <a  class="btn btn-success text-white" style="cursor:pointer" onclick=Lockunlock('${data.id}')>
       <i class="fas fa-lock"></i> 
    </a>

<a href="/Admin/User/Edit/${data.id}" class="btn btn-sm btn-success text-white" style="cursor:pointer">
   <i class="fas fa-edit"></i>
         
    </a>

 
    <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Delete("/Admin/User/Delete/${data.id}")>
        <i class="far fa-trash-alt"></i> 
    </a>
</div>`
                    }




                }, "width": "40%"

            }

        ]
        , "bDestroy": true
    });
}

function Lockunlock(id) {

    $.ajax({
        type: "POST",
        url: '/Admin/User/Lockunlock',
        data: JSON.stringify(id),
        contentType: "application/json",

        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                //dataTable.ajax.reload();
                $('#tblData').DataTable().ajax.reload();
            }
            else {
                toastr.error(data.message);
            }
        }
    });


}

function Delete(url) {
    swal({
        title: "Are you sure you want to delete?",
        text: "You will not be able to restore the data",
        icon: "warning",
        buttons: true,
        dangerMode: true

    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                      /*  dataTable.ajax.reload()*/;
                        $('#tblData').DataTable().ajax.reload()
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }


    });

} 

//if (lockout > today) {
//    return `
//<div class="text-center">

//    <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Lockunlock('${data.id}')>
//       <i class="fas fa-lock-open"></i> Unlock
//    </a>

//<a href="/Admin/User/Edit/${data.id}" class="btn btn-sm btn-success text-white" style="cursor:pointer">
//    <i class="fas fa-edit"></i>
//         Edit
//    </a>

 
// <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Delete("/Admin/User/Delete/${data.id}")>
//        <i class="far fa-trash-alt"></i> Delete
//    </a>
//</div>`



//}
//else {
//    return `
//<div class="text-center">

//    <a  class="btn btn-success text-white" style="cursor:pointer" onclick=Lockunlock('${data.id}')>
//       <i class="fas fa-lock"></i> Lock
//    </a>

//<a href="/Admin/User/Edit/${data.id}" class="btn btn-sm btn-success text-white" style="cursor:pointer">
//   <i class="fas fa-edit"></i>
//         Edit
//    </a>

 
//    <a  class="btn btn-danger text-white" style="cursor:pointer" onclick=Delete("/Admin/User/Delete/${data.id}")>
//        <i class="far fa-trash-alt"></i> Delete
//    </a>
//</div>`
//}