public class Hamming {
    String leftStrand;
    String rightStrand;
    int distance = -1;

    public Hamming(String leftStrand, String rightStrand) {       
        this.leftStrand = leftStrand;
        this.rightStrand = rightStrand;

        if (this.leftStrand.isEmpty() && this.rightStrand.isEmpty())
            return;

        if (this.leftStrand.isEmpty()) 
            throw new IllegalArgumentException("left strand must not be empty.");        
        
        if (this.rightStrand.isEmpty()) 
            throw new IllegalArgumentException("right strand must not be empty.");                

        if(this.leftStrand.length() != this.rightStrand.length()) 
            throw new IllegalArgumentException("leftStrand and rightStrand must be of equal length.");
        
        getHammingDistance();
    }

    public int getHammingDistance() {
        if (distance >= 0) 
            return distance;

        distance = 0;
        for(int i=0; i<leftStrand.length(); i++) {
            if(leftStrand.charAt(i) != rightStrand.charAt(i))
                distance++;
        }
        return distance;
    }
}
