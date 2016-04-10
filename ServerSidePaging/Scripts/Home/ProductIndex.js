$(function () {
    var productListVM = {
        dt: null,

        init: function () {
            dt = $('#data-table').DataTable({
                "serverSide": true,
                "processing": true,
                "ajax": "/home/datatableget",
                "columns": [
                    { "title": "Product Id", "data": "ProductId", "searchable": false },
                    { "title": "Name", "data": "Name" },
                    { "title": "Description", "data": "Description" },
                    { "title": "Category", "data": "Category" }
                ],
                "lengthMenu": [[2, 5, 10, 25], [2, 5, 10, 25]]
            });
        },

        refresh: function () {
            dt.ajax.reload();
        }
    }

    $('#refresh-button').on("click", productListVM.refresh);

    /////////////////////////////////////////////////////////////////
    // Let's kick it all off
    productListVM.init();
})
