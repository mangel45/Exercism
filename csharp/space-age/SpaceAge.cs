using System;

public class SpaceAge
{
    private double EARTH_AGE;   
    private const double EARTH_ORBITAL_PERIOD = 31557600;
    private const double MERCURY_ORBITAL_PERIOD = 0.2408467;
    private const double VENUS_ORBITAL_PERIOD = 0.61519726;        
    private const double MARS_ORBITAL_PERIOD = 1.8808158;        
    private const double JUPITER_ORBITAL_PERIOD = 11.862615;
    private const double SATURN_ORBITAL_PERIOD = 29.447498;
    private const double URANUS_ORBITAL_PERIOD = 84.016846;
    private const double NEPTUNE_ORBITAL_PERIOD = 164.79132;

    public SpaceAge(int seconds)
    {
        EARTH_AGE = seconds/EARTH_ORBITAL_PERIOD;
    }

    public double OnEarth()
    {                
        return EARTH_AGE;
    }

    public double OnMercury()
    {            
        return EARTH_AGE/MERCURY_ORBITAL_PERIOD;
    }

    public double OnVenus()
    {        
        return EARTH_AGE/VENUS_ORBITAL_PERIOD;
    }

    public double OnMars()
    {                        
        return EARTH_AGE/MARS_ORBITAL_PERIOD;
    }

    public double OnJupiter()
    {        
        return EARTH_AGE/JUPITER_ORBITAL_PERIOD;
    }    

    public double OnSaturn()
    {        
        return EARTH_AGE/SATURN_ORBITAL_PERIOD;
    }

    public double OnUranus()
    {        
        return EARTH_AGE/URANUS_ORBITAL_PERIOD;
    }

    public double OnNeptune()
    {        
        return EARTH_AGE/NEPTUNE_ORBITAL_PERIOD;
    }
}