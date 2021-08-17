import java.util.List;
import java.util.ArrayList;
import java.util.Collections;

class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {
        List<Signal> result = new ArrayList<Signal>();

        int n = 0;
        while (number > 0) {     
            boolean hasBit = (number & 1) == 1;              
            if(hasBit && n<=3) result.add(Signal.values()[n]);     
            if(hasBit && n==4) Collections.reverse(result);         
            
            number = number >> 1;            
            n++;            
        }

        return result;
    }

    public static void main(String[] args) {
        new HandshakeCalculator().calculateHandshake(19);
    }

}
