using System;
using Xunit;

namespace CircleSquareTest
{//xUnit
    
    public class CircleSquareTest
    {
        
        [Fact]
        public void CircleSquare1_SuccsessTest()
        {
            
            //Arrange - ����� �������� ����� � ��������� ���������. 
            double r = 2;
            double expected = Math.PI * Math.Pow(r, 2);

            //Act - ����. ������ ����������� 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - ��������� ����������� (True, False)
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void CircleSquare1_NegativeRadiusTest()
        {

           
            double r = -2;

            //Act - ����. ������ ����������� 
            SkrugaDBTest.CircleSquare circle = new SkrugaDBTest.CircleSquare();
            double actual = circle.CircleSquare1(r);

            //Assert - ��������� ����������� (True, False)
            Assert.Equal(0, actual);
        }
    }
}
