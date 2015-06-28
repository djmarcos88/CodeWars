function pigLatin(string) {
  var result;

  console.log(!/^[a-zA-Z]+$/.test(string));
  if (!/^[a-zA-Z]+$/.test(string)) {
    result = null;
  }
  else if (/^[aeiou]/.test(string)) {
    result = string + 'way';
  }
  else {
    //comment deleted
  }

  return result;
}
