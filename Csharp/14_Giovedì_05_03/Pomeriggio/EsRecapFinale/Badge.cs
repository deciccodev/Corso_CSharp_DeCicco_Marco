public class Badge
{
    private int _codiceBadge;
    private bool _isActive;

    public int CodiceBadge
    {
        get { return _codiceBadge;}
    }

    public bool IsActive
    {
        get { return _isActive;}
        set { _isActive = value;}
    }

    public Badge(int _codiceBadge)
    {
        if (_codiceBadge <= 0)
            throw new Exception("Codice badge non valido!");
        
        this._codiceBadge = _codiceBadge;
        _isActive = true;
    }
}