// String - immutable (could not be changed, only coppied to other variables)
var primitiveStr = 'John';
var objectStr = new String('John');

console.log(typeof primitiveStr); // string
console.log(typeof objectStr); // object

// str.concat
var firstname = 'Krasi';
var lastname = 'Stoyanov';

var fullname = firstname.concat(' ', lastname);

console.log(fullname);

// str.replace
var text = '     \n\n\t132165132 Telerik Telerik, Telerik Telerik, Telerik\t\n\n     ';

var replace = text.replace('Telerik', 'T');

console.log(replace); // 132165132 T Telerik Telerik Telerik Telerik

// str.search
var search = text.search(/[A-z]+/);

console.log(search);

// str.indexOf
var indexOf = text.indexOf('6');

console.log(indexOf);

// str.lastIndexOF
var lastIndexOf = text.lastIndexOf('k');

console.log(lastIndexOf);

// str.split
var words = text.split(/[ ,]/g);

console.log(words);

// str.trim
var removeWhiteSpaces = text.trim();

console.log(removeWhiteSpaces);

// str.substr(start, count)
var newText = 'Hello, I am John!';

console.log(newText.substr(4, 7)); // o, I am

// str.substring(start, end)
console.log(newText.substring(4, 7)); // o, 

// str.valueOf
var john = 'John';

console.log(john);