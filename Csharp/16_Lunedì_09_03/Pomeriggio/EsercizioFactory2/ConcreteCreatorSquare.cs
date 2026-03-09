public class ConcreteCreatorSquare : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if (type.ToLower() == "square")
            return new Square();

        return null;
    }
}