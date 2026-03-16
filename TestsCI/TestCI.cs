using System.ComponentModel;
using System.Drawing;
using ClassLibrary1;

namespace Test
{
    public class TestCI
    {
        [Fact]
        public void CreateRectangle()
        {
            ClassLibrary1.Rectangle rec = new ClassLibrary1.Rectangle();
            Assert.NotNull(rec);
        }

        [Fact]
        public void CreateTriangle()
        {
            ClassLibrary1.Triangle tri = new ClassLibrary1.Triangle();
            Assert.NotNull(tri);
        }

        [Fact]
        public void RectangleArea_check()
        {
            ClassLibrary1.Rectangle rectangle = new ClassLibrary1.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Area();

            Assert.Equal(20, res);
        }

        [Fact]
        public void RectangleArea_checkException() // комментарий для пуллреквеста в репу
        {
            ClassLibrary1.Rectangle rectangle = new ClassLibrary1.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Area());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }

        [Fact]
        public void RectanglePerimetre_check()
        {
            ClassLibrary1.Rectangle rectangle = new ClassLibrary1.Rectangle();

            rectangle.Width = 10;
            rectangle.Height = 2;

            double res = rectangle.Perimeter();

            Assert.Equal(24, res);
        }

        [Fact]
        public void RectanglePerimetre_checkException()
        {
            ClassLibrary1.Rectangle rectangle = new ClassLibrary1.Rectangle();

            rectangle.Width = 0;
            rectangle.Height = -2;

            var ex = Assert.Throws<ArgumentException>(() => rectangle.Perimeter());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }
    }
}