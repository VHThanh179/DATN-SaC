(function () {
    window.RefreshUser = {
        refreshData: () => {
            setTimeout(function () {
                window.location.href = "https://localhost:44384/";
            }, 2000);
        }
    };
})();