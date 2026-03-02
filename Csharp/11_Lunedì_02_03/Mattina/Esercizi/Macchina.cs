class Macchina
{
    public string motore;
    public float velocitaMac;
    public int sospensioniMax, nrModifiche;

    public Macchina()
    {
        motore = "Base";
        velocitaMac = 0;
        sospensioniMax = 0;
        nrModifiche = 0;
    }


    public override string ToString()
    {
        return $"Motore: {motore}, Velocità Macchina: {velocitaMac}, Sospensioni Macchina: {sospensioniMax}, Numero modifiche macchina: {nrModifiche}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Macchina altro)
        {
            return this.motore == altro.motore && this.velocitaMac == altro.velocitaMac && this.sospensioniMax == altro.sospensioniMax && this.nrModifiche == altro.nrModifiche;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(motore, velocitaMac, sospensioniMax, nrModifiche);
    }
}
    