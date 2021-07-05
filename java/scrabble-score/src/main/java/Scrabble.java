class Scrabble {    
    String word;
    int[] VALUES  = new int[] { 1, 3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10 };
    int score = 0;
        
    Scrabble(String word) {
        this.word = word.toLowerCase();      
    }

    int getScore() {
        if(score != 0) return score;

        for(int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';
            score += VALUES[index];
        }            
        return score;
    }    
}
