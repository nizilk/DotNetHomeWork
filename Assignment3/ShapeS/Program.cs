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
            double sum=0;
            List<Shape> objlist = new List<Shape>();
            try
            {
                for (int i = 0; i < OBJ_NUM; i++)
                {
                    Shape ss = Factory.createRandomShape(TYPE_NUM);
                    objlist.Add(ss);
                    sum += ss.getArea();
                }
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
                Console.WriteLine($"type: {t.Name}\t    area: {t.getArea():F4}");
            }
        }
    }

    interface Shape    //抽象类
    {
        string Name{ get; }
        double getArea();
        bool isLegal();
    }

    public class Rectangle: Shape      //长方形
    {
        public string name = "Rectangle";
        private double length;
        private double width;
        public double Length { get; set; }
        public double Width { get; set; }
        public string Name
        {
            get { return name; }
        }
        public Rectangle(double x=0, double y=0)
        {
            length = x;
            width = y;
        }
        public double getArea()
        {
            return length * width;
        }
        public bool isLegal()
        {
            return (length > 0 && width > 0);
        }
    }

    public class Square: Shape     //正方形
    {
        private double length;
        public string name = "Square";
        public double Length { get; set; }
        public string Name
        {
            get { return name; }
        }
        public Square(double x = 0)
        {
            length = x;
        }
        public double getArea()
        {
            return length * length;
        }
        public bool isLegal()
        {
            return (length > 0);
        }
    }

    public class Triangle: Shape       //三角形
    {
        private double length;
        private double height;
        public string name = "Triangle";
        public double Length { get; set; }
        public double Height { get; set; }
        public string Name
        {
            get { return name; }
        }
        public Triangle(double l=0, double h=0)
        {
            length = l;
            height = h;
        }
        public double getArea()
        {
            return length * height /2;
        }
        public bool isLegal()
        {
            return (length > 0 && height > 0);
        }
    }

    public class Circle: Shape     //圆形
    {
        private double radius;
        public string name = "Circle";
        public double Radius { get; set; }
        public string Name
        {
            get { return name; }
        }
        public Circle(double r=0)
        {
            radius = r;
        }
        public double getArea()
        {
            return radius * radius * double.Pi/2;
        }
        public bool isLegal()
        {
            return (radius > 0);
        }
    }

    class Factory       //简单工厂模式的那个工厂
    {
        public static Shape createRandomShape(int typeNum)
        {
            int type;
            double can1, can2;
            Random rd = new Random();
            type = rd.Next(0, typeNum);    //0~3
            can1 = rd.NextDouble() * 100;     //让随机的小数大小差不多一点
            can2 = rd.NextDouble() * 100;
            return createShape((ShapeType)type, can1, can2);
        }

        public static Shape createShape(ShapeType s, double x, double y)
        {
            Shape re;
            switch (s)
            {
                case ShapeType.RECTANGLE:
                    re = new Rectangle(x, y);
                    break;
                case ShapeType.SQUARE:
                    re = new Square(x);
                    break;
                case ShapeType.TRIANGLE:
                    re = new Triangle(x, y);
                    break;
                case ShapeType.CIRCLE:
                    re = new Circle(x);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid value");
            }
            if (!re.isLegal()) throw new ArgumentException(message: "Invalid value");
            return re;
        }
    }
    public enum ShapeType     //所有形状的枚举，编号为默认的0~3
    {
        RECTANGLE, SQUARE, TRIANGLE, CIRCLE
    };
}