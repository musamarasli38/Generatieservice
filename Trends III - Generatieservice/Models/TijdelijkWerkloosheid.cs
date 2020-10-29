using System;

public abstract class TijdelijkWerkloosheid : Report
{
    public bool Aanvraag { get; set; }
    public string Rekeningnummer { get; set; }
    public bool Overschrijving { get; set; }
    public string Telefoonnummer { get; set; }
    public string Email { get; set; }


}
