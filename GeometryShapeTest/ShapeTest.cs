using GeometryShape;

namespace GeometryShapeTest
{
    public class ShapeTest
    {
        [Fact]
        public void CheckPerimeterWithRectangleWith5WidthAnd5Height ()
        {
            double width = 5;
            double height = 5;
            var shape = new Rectangle(width, height);
            double result = (width + height) * 2;
            Assert.Equal(result, shape.Perimeter( ));
        }
        [Fact]
        public void CheckPerimeterWithRectangleWith0WidthAnd5Height ()
        {
            double width = 0;
            double height = 5;
            var shape = new Rectangle(width, height);
            double result = (width + height) * 2;
            Assert.Throws<ArgumentOutOfRangeException>(
                 () => shape.Perimeter( )
                 );
        }
        [Fact]
        public void CheckAreaWithRectangleWith0WidthAnd5Height ()
        {
            double width = 0;
            double height = 5;
            var shape = new Rectangle(width, height);
            double result = width*height;
            Assert.Throws<ArgumentOutOfRangeException>(
                  () => shape.Area( )
                  );
        }
        [Fact]
        public void CheckAreaWithRectangleWith5WidthAnd5Height ()
        {
            double width = 5;
            double height = 5;
            var shape = new Rectangle(width, height);
            double result = width*height;
            Assert.Equal(result, shape.Area( ));
        }


        
        
    }
}