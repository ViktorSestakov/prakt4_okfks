using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Test
{
    public class TestTriangleCI
    {
        [Fact]
        public void CreateTriangle() // крутой комменатрий для пулл реквеста!
        {
            ClassLibrary1.Triangle tri = new ClassLibrary1.Triangle();
            Assert.NotNull(tri);
        }

        [Fact]
        public void TriangleArea_Check()
        {
            Triangle tri = new Triangle();
            tri.SideA = 5;
            tri.SideB = 5;
            tri.SideC = 5;

            Assert.Equal(10.825317547305483, tri.Area());
        }

        [Fact]
        public void TriangleArea_CheckEx()
        {
            Triangle tri = new Triangle();
            tri.SideA = -5;
            tri.SideB = 5;
            tri.SideC = 5;

            var ex = Assert.Throws<ArgumentException>(() => tri.Area());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }

        [Fact]
        public void TrianglePerimetre_Check()
        {
            Triangle tri = new Triangle();
            tri.SideA = 5;
            tri.SideB = 5;
            tri.SideC = 5;

            Assert.Equal(15, tri.Perimeter());
        }

        [Fact]
        public void TrianglePerimetre_CheckEx()
        {
            Triangle tri = new Triangle();
            tri.SideA = -5;
            tri.SideB = 5;
            tri.SideC = 5;

            var ex = Assert.Throws<ArgumentException>(() => tri.Perimeter());

            Assert.Contains("Недопустимые числа!", ex.Message.ToString());
        }
    }
}
