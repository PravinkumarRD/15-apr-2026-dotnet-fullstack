//Constructor Function
/*function Person(fname, lname, city) {
  //public members
  this.firstName = fname;
  this.lastName = lname;
  this.city = city;

  this.printPersonInfo = function () {
    console.log("Person " + this.firstName + " " + this.lastName + " lives in city " + this.city + "!");
  }
//private members
  var age = 20;
}

var p1=new Person("Pravinkumar","R. D.","Pune");
p1.printPersonInfo();
*/
class Employee {
  constructor(fname, lname, city) {
    this.firstName = fname;
    this.lastName = lname;
    this.city = city;
  }
  #_age = 20;
  firstName;
  lastName;
  city;
  printEmployeeInfo() {
    return `Employee ${this.firstName} ${this.lastName} lives in city ${this.city} !`;
  }
}

const e1=new Employee("Pravinkumar","R. D.","Pune");
console.log(e1.printEmployeeInfo());
console.log(typeof Employee)