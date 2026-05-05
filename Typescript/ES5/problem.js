var Customer = {
  customerId: 2383,
  contactName: "Manish Kaushik",
  city: "Raipur",
  printCustomerInfo: function () {
    console.log(this);
    setTimeout(()=>{
       console.log(this);
       console.log("Customer " + this.contactName + " with Id " + this.customerId + " lives in city " + this.city + "!"); 
    },2000);
  }
//   printCustomerInfo: function () {
//     console.log(this);
//     setTimeout(function () {
//          console.log(this);
//         console.log("Customer " + this.contactName + " with Id " + this.customerId + " lives in city " + this.city + "!");
//     }.bind(this), 2000);
//   },
//   printCustomerInfo: function () {
//     console.log(this);
//     var _self=this;
//     setTimeout(function () {
//          console.log(_self);
//         console.log("Customer " + _self.contactName + " with Id " + _self.customerId + " lives in city " + _self.city + "!");
//     }, 2000);
//   },
};

Customer.printCustomerInfo();

//function with function keyword, it is binded with this context. This scope is dynamic
