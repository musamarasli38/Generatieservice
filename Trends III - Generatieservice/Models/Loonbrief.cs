using System;

public class Class1 : Loonbrief
{
    public double Salaris { get; set; }
    public int Werkuren { get; set; }
    public enum BurgerlijkeStaat
    {
        Alleenstaand,
        Getrouwd,
        Samenwonend
    }
    public int PersonenTenLaste { get; set; }   
}
