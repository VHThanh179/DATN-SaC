(function () {
    window.RefeshProducts = {
        refreshData: () => {
            var link = "https://localhost:44384/productlist";
            setTimeout(function () { window.location.href = link; }, 3000);
        }
    };
})();