using System.Drawing;
using System.Formats.Asn1;

namespace ShapeS
{
    internal class Program
    {
        const int TYPE_NUM = 4;     //有多少种形状
        const int OBJ_NUM = 10;     //创建多少个对象
        static void Main(string[] args)
        {
            double sum;
            try
            {
                List<Shape> objlist = createRandomList(OBJ_NUM, out sum);
                printShape(objlist);
                Console.WriteLine($"\nThe sum of these 10 objects' area: {sum:F4}");    //10个对象的面积之和
            } catch (Exception e)
            {
                Console.WriteLine($"错误:{e.Message}");
            }
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void printShape(List<Shape> list)     //打印随机生成的10个对象
        {
            foreach (Shape t in list)
            {
                Console.WriteLine($"type: {t.Name}\t    area: {t.area():F4}");
            }
        }
        
        public static List<Shape> createRandomList(int n, out double sum)   //用随机数随机生成n个对象
        {
            sum = 0;
            int type;
            double can1, can2;
            Random rd = new Random();
            List<Shape> ans = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                type = rd.Next(0, TYPE_NUM);    //0~3
                can1 = rd.NextDouble()*100;     //让随机的小数大小差不多一点
                can2 = rd.NextDouble()*100;
                Shape ss = Factory.createShape((Shapes)type, can1, can2);
                if (!ss.isLegal()) { throw new ArgumentException(message: "ilegal shape~~"); }
                ans.Add(ss);
                sum += ss.area();
            }
            return ans;
        }
    }

    abstract class Shape    //抽象类
    {
        private string name;
        abstract public string Name{ get; set; }
        abstract public double area();
        abstract public bool isLegal();
    }

    class Rectangle: Shape      //长方形
    {
        public string name = "Rectangle";
        private double length;
        private double width;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        { 
            get { return width; }
            set { width = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Rectangle(double x=0, double y=0)
        {
            length = x;
            width = y;
        }
        public override double area()
        {
            return length * width;
        }
        public override bool isLegal()
        {
            if(length <= 0 || width <= 0)   return false;
            return true;
        }
    }

    class Square: Shape     //正方形
    {
        private double length;
        public string name = "Square";
        public double Side
        {
            get { return length; }
            set { length = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Square(double x = 0)
        {
            length = x;
        }
        public override double area()
        {
            return length * length;
        }
        public override bool isLegal()
        {
            if (length <= 0) return false;
            return true;
        }
    }

    class Triangle: Shape       //三角形
    {
        private double length;
        private double height;
        public string name = "Triangle";
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Triangle(double l=0, double h=0)
        {
            length = l;
            height = h;
        }
        public override double area()
        {
            return length * height /2;
        }
        public override bool isLegal()
        {
            if (length <= 0 || height <= 0) return false;
            return true;
        }
    }

    class Circle: Shape     //圆形
    {
        private double radius;
        public string name = "Circle";
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Circle(double r=0)
        {
            radius = r;
        }
        public override double area()
        {
            return radius * radius * double.Pi/2;
        }
        public override bool isLegal()
        {
            if (radius < 0) return false;
            return true;
        }
    }

    class Factory       //简单工厂模式的那个工厂
    {
        public static Shape createShape(Shapes s, double x, double y)
        {
            switch (s)
            {
                case Shapes.RECTANGLE:
                    return new Rectangle(x, y);
                case Shapes.SQUARE:
                    return new Square(x);
                case Shapes.TRIANGLE:
                    return new Triangle(x, y);
                case Shapes.CIRCLE:
                    return new Circle(x);
                default:
                    throw new ArgumentException(message: "Invalid value");
            }
        }
    }
    enum Shapes     //所有形状的枚举，编号为默认的0~3
    {
        RECTANGLE, SQUARE, TRIANGLE, CIRCLE
    };
}