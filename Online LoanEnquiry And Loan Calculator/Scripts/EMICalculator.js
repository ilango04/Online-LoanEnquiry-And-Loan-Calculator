var flag = 0,amount,tenure,interestRate,result=0;
function ValidateAmount() {
    amount = document.getElementById("txtAmount").value;
    var regex = /^[0-9]+$/;
    if (amount.length == 0)                                                            //validation for empty textbox
    {
        document.getElementById("errorAmount").innerHTML = "Enter an Amount";
    }
    else if (!amount.match(regex)) {
        document.getElementById("errorAmount").innerHTML = "Invalid Amount";
    }
    else                                                                           //valid card number 
    {
        amount = Number(amount);
        flag++;
    }
}
function ValidateTenure() {
    tenure = document.getElementById("txtTenure").value;
    var regex = /^[0-9]+$/;
    if (tenure.length == 0)                                                            //validation for empty textbox       
    {
        document.getElementById("errorTenure").innerHTML = "Enter a Tenure";
    }
    else if (!tenure.match(regex)) {
        document.getElementById("errorTenure").innerHTML = "Invalid Tenure";
    }
    else                                                                           //valid security code 
    {
        tenure = Number(tenure);
        flag++;
    }
}
function ValidateInterestRate() {
    interestRate = document.getElementById("txtRate").value;
    var regex = /^[0-9]+$/;
    if (interestRate.length == 0) {                                                           //validation for empty textbox 
        document.getElementById("errorRate").innerHTML = "Enter a Rate";
    }
    else if (!interestRate.match(regex)) {
        document.getElementById("errorRate").innerHTML = "Invalid Rate";
    }
    else                                                                           //valid name  
    {
        interestRate = Number(interestRate);
        flag++;
    }
}
function CalculateEMI() {
    result =(amount * interestRate) * (Math.pow((1 + interestRate),tenure) / (Math.pow((1 + interestRate),tenure) - 1));
    document.getElementById("txtEMI").innerHTML = "EMI is " + result;
}
function ToCalculate() {
    ValidateAmount();
    ValidateTenure();
    ValidateInterestRate();
    if (flag == 3) {
        CalculateEMI();
    }
}
