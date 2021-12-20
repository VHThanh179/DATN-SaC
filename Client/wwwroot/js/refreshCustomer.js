(function () {
    window.RefreshCustomer = {
        refreshData: () => {
            setTimeout(function () {
                window.location.href = "https://localhost:44345/";
            }, 2000);
        }
    };
})();