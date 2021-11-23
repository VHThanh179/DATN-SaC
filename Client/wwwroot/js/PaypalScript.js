window.PaypalButton = function () {
    paypal.Buttons({
        createOrder: function (data, actions) {
            //debugger;
            var price = (parseFloat(document.getElementById('totalPrice').innerText) / 22500).toFixed(2);
            // This function sets up the details of the transaction, including the amount and line item details.
            return actions.order.create({               
                purchase_units: [{
                    amount: {
                        value: price
                    }
                }]
            });
        },
        onApprove: function (data, actions) {
            // This function captures the funds from the transaction.
            return actions.order.capture().then(function (details) {
                // This function shows a transaction success message to your buyer.
                alert('Transaction completed by ' + details.payer.name.given_name);
                DotNet.invokeMethodAsync('Client', 'CheckoutWithPaypal').then(data => {
                    console.log(data);
                });
            });
        }
    }).render('#paypal-button-container');
  //This function displays Smart Payment Buttons on your web page.
}
displayMoreInfoShipping = function () {
    var x = document.getElementById("moreInfoShipping");
    x.style.visibility = "visible"
}
noneDisplayMoreInfoShipping = function () {
    var x = document.getElementById("moreInfoShipping");
    x.style.visibility = "hidden";
}

