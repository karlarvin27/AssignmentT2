$(document).ready(function () {
    loadDataTable();
});

fuction loadDataTable(){
    dataTable = $('#tblData').DataTable({
        "ajax": url:'/admin/product/getall'},
        "columns": [
         { data: 'Product/Services Name', "width": "15%"},
         { data: 'Price', "width": "15%" },
         { data: 'Description', "width": "15%" },
         { data: 'Category', "width": "15%" }
        ]
    });
}
