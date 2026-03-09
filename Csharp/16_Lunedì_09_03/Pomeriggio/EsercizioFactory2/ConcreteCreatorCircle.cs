public class ConcreteCreatorCircle : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if (type.ToLower() == "circle")
            return new Circle();

        return null;
    }
}