// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log('page is fully loaded');

    function updateQty(uid, pid) {
        let x = uid+pid
        
        console.log(x);
    }

    $('.updateCartQty').change((e) => {
        console.log(e.target.getAttribute("data-uid"))
        console.log(e.target.getAttribute("data-pid"))
        console.log(e.target.value)

        $.post("/Carts/Edit",
            {
                ApplicationUserId: e.target.getAttribute("data-uid"),
                ProductID: e.target.getAttribute("data-pid"),
                Quantity: e.target.value
            },
            function (data, status) {

        });
    })
});