using system;
namespace ncc_lab_prameshwor
{
    class circle
    {
        private double radius = 7.87;
        //property
        public double Radius
        {
            //get accessor
            get
            {
                return radius;
            }
            //set accessor
            set
            {
                radius = value;
            }
        }
        //getter method
        public double getradius()
        {
            return radius;
        }
        //setter method
        public void setradius(double radius)
        {
            this.radius = radius;
        }
    }
    internal class propertydemo
    {
        static void Main(string[] args)
        {
            circle c1 = new circle();
            //c1.setradius(12.5);
            c1.Radius = 12.45;
            //  Console.WriteLine("value of radius= " + c1.getradius());
            Console.WriteLine("value of radius= " + c1.Radius);
        }
    }
}
