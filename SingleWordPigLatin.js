function pigLatin(string) {
  var result;

  string = string.toLowerCase();
  if (!/^[a-zA-Z]+$/.test(string)) {
    result = null;
  }
  else if (/^[aeiou]/.test(string)) {
    result = string + 'way';
  }
  else {
    var regExResult = /^[bcdfghjklmnpqrstvwxyz]+/.exec(string);
    var start = regExResult.index;
    var end = regExResult[0].length;

    var firstSlice = string.slice(start, end);
    var secondSlice = string.slice(end);
    result = secondSlice + firstSlice + 'ay';
  }

  return result;
}