//
// This is only a SKELETON file for the 'Pangram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isPangram = (sentence) => {  
  let ALPHABET = new Array(26).fill(0);  
  sentence = sentence.toLowerCase();  
  for(let c of sentence) 
    ALPHABET[c.charCodeAt(0)- 'a'.charCodeAt(0)] = 1;     
  return ALPHABET.every(r => r==1);
};
