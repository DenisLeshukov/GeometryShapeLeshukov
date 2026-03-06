using GeometryShape;

namespace GeometryShapeTest
{
    public class ShapeTest
    {
        [Fact]
        public void CheckPerimeterWithRectangleWith5WidthAnd5HeightFakeTest ()
        {
            double width = 5;
            double height = 5;
            var shape = new Rectangle(width, height);
            double result = (width + height+2) * 2;
            Assert.Equal(result, shape.Perimeter( ));
        }
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
        [Fact]
        public void CheckAreaWithTriangleWithSides5()
        {
            double sidea = 5;
            double sideb = 5;
            double sidec = 5;
            var shape = new Triangle(sidea,sideb,sidec);
            double p = (sidea + sideb + sidec) / 2;
            double result = Math.Sqrt(p * (p - sidea) * (p - sideb) * (p - sidec));
            Assert.Equal(result, shape.Area( ));
        }
        [Fact]
        public void CheckPerimeterWithTriangleWithSides5 ()
        {
            double sidea = 5;
            double sideb = 5;
            double sidec = 5;
            var shape = new Triangle(sidea, sideb, sidec);
            double result = sidea + sideb + sidec;
            Assert.Equal(result, shape.Perimeter( ));
        }
        [Fact]
        public void CheckAreaWithTriangleWithExceptionClessAsumB ()
        {
            double sidea = 2;
            double sideb = 5;
            double sidec = 10;
            var shape = new Triangle(sidea, sideb, sidec);
           
            Assert.Throws<ArgumentOutOfRangeException>(
                  () => shape.Area( )
                  );
        }
        [Fact]
        public void CheckPerimeterWithTriangleWithExceptionClessAsumB ()
        {
            double sidea = 2;
            double sideb = 5;
            double sidec = 10;
            var shape = new Triangle(sidea, sideb, sidec);

            Assert.Throws<ArgumentOutOfRangeException>(
                  () => shape.Perimeter( )
                  );
        }
        [Fact]
        public void CheckPerimeterWithTriangleWithExceptionlessZeroSide ()
        {
            double sidea = -5;
            double sideb = 5;
            double sidec = 5;
            var shape = new Triangle(sidea, sideb, sidec);

            Assert.Throws<ArgumentOutOfRangeException>(
                  () => shape.Perimeter( )
                  );
        }
        [Fact]
        public void CheckAreaWithTriangleWithExceptionlessZeroSide ()
        {
            double sidea = -5;
            double sideb = 5;
            double sidec = 5;
            var shape = new Triangle(sidea, sideb, sidec);

            Assert.Throws<ArgumentOutOfRangeException>(
                  () => shape.Area( )
                  );
        }
        



    }
}