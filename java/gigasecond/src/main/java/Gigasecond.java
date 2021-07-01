import java.time.LocalDate;
import java.time.LocalDateTime;

public class Gigasecond {
    private LocalDateTime moment;
    private static final long GIGASECOND = 1_000_000_000; //10E9;    

    public Gigasecond(LocalDate moment) {
        this(moment.atStartOfDay());
    }

    public Gigasecond(LocalDateTime moment) {
        this.moment = LocalDateTime.of(moment.toLocalDate(), moment.toLocalTime()).plusSeconds(GIGASECOND);        
    }

    public LocalDateTime getDateTime() {
        return moment;
    }
}
