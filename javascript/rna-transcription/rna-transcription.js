//
// This is only a SKELETON file for the 'RNA Transcription' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

const TRANSCRIPTION = {  
  "G": "C",
  "C": "G",
  "T": "A",
  "A": "U"
}

export const toRna = (rna) => Array.from(rna).map(r => TRANSCRIPTION[r]).join('').toString();  
