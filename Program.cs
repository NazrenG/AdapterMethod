namespace Adapter
{
    public interface Rectangle
    {
        public void setLength(int length);
        public void setWidth(int width);
        public void printAreaOfRectangle();
    }

    public class TennisCourt : Rectangle
    {
        public int length;
        public int width;

        public void setLength(int lenth) { this.length = lenth; }
        public void setWidth(int width) { this.width = width; }
        public void printAreaOfRectangle()
        { //do work
        }
    }

    public interface Square
    {
        public void setSide(int side);
        public void printAreaOfSquare();
    }

    public class Chessboard : Square
    {
        public int setLength;

        public void setSide(int side) { this.setLength = side; }
        public void printAreaOfSquare()
        { //do work 
        }

    }

    public  class RectangleAdapter : Square
    {
        private Rectangle? rect;

        public RectangleAdapter(Rectangle? rect)
        {
            this.rect = rect;
        }

        public void printAreaOfSquare()
        { 
            rect.printAreaOfRectangle();
        }

        public void setSide(int side)
        {
            rect.setWidth(side);
            rect.setLength(side);
        }
    }

 

}
