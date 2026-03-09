public class Program
{
    static void Main(string[] args)
    {
        bool continua = true;

        while (continua)
        {
            ShapeCreator creator;

            Console.WriteLine("Quale forma vuoi disegnare?");
            Console.WriteLine("[1] Cerchio");
            Console.WriteLine("[2] Quadrato");
            Console.WriteLine("[3] Esci");
            Console.Write("Scelta: ");
            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    creator = new ConcreteCreatorCircle();
                    if (creator != null)
                    {
                        IShape shape = creator.CreateShape("circle");
                        shape.Draw();
                    }
                    break;

                case "2":
                    creator = new ConcreteCreatorSquare();
                    if (creator != null)
                    {
                        IShape shape = creator.CreateShape("square");
                        shape.Draw();
                    }
                    break;

                case "3":
                    Console.WriteLine("Uscita...");
                    continua = false;
                    break;

                default:
                    throw new Exception("Forma non valida");
            }
        }
    }
}