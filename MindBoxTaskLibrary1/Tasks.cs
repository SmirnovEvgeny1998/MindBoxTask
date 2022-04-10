using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTaskLibrary1
{
    public class Tasks
	{
		//Вычисление площади круга.
		public double CalculateCircleArea(double radius)
		{
			return Math.PI * radius * radius;
		}
		//Вычисление площади треугольника.
		public double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
		{
			double triangleHalfPerimetr = (firstSide + secondSide + thirdSide) * 0.5;
			double squaredTriangleArea = triangleHalfPerimetr * (triangleHalfPerimetr - firstSide) * (triangleHalfPerimetr - secondSide) * (triangleHalfPerimetr - thirdSide);
			return Math.Sqrt(squaredTriangleArea);
		}
		//Я не совсем понял, что означает "Легкость добавления других фигур" и предположил, что требуется добавить методы вычисления для других фигур.
		//Вычисление площади кольца. Требуются внешний и внутренний радиус кольца, сначала вводится внешний, потом внутренний.
		public double CalculateRingArea(double outRadius, double inRadius)
		{
			return Math.PI * (Math.Pow(outRadius, 2) - Math.Pow(inRadius, 2));
		}
		//Вычисление площади четырехугольников. Требуются диагонали четырехугольника и угол между ними.
		public double CalculateQuadrilateralArea(double firstDiagonal, double secondDiagonal, double angle)
		{
			double radian = angle * Math.PI / 180;
			return 0.5 * firstDiagonal * secondDiagonal * Math.Sin(radian);
		}
		//Вычисление площади эллипсов. Требуются две полуоси.
		public double CalculateEllipseArea(double firstSemiaxe, double secondSemiaxe)
		{
			return Math.PI * firstSemiaxe * secondSemiaxe;
		}
		//Вычисление площади правильного многоугольника. Требуются количество сторон многоугольника, их длинна.
		public double CalculateRegularPolygonArea(double quantity, double length)
		{
			double radian = 180 / quantity * Math.PI / 180;
			return (quantity * length * length) / (4 * Math.Tan(radian));
		}
		//Вычисление площади любого многоугольника. Требуются пары координат х и у для каждой вершины поочередно(a,b,c,d,e...итд).
		public double CalculateAnyFigureArea(params double[] newarray)
		{
			int length = newarray.Length;
			double firstPart = 0;
			double secondPart = 0;
			for (int i = 0; i < length; i++)
            {
				if (i % 2 == 0)
				{
					if (i + 3 <= length)
					{
						firstPart += newarray[i] * newarray[i + 3];
					}
					else
                    {
						firstPart += newarray[i] * newarray[1];
                    }
				}
				else
				{
					if (i + 3 <= length)
					{
						secondPart += newarray[i] * newarray[i + 1];
					}
					else
					{
						secondPart += newarray[i] * newarray[0];
					}
				}
			}
			return Math.Abs(firstPart - secondPart) * 0.5;
		}
		//Является ли треугольник прямоугольным. Если число не целое, требуется 5 или больше цифр после запятой.
		public bool IsTriangleRight(double firstSide, double secondSide, double thirdSide)
		{
			double[] sides = {firstSide, secondSide, thirdSide};
			double longSide = 0;
			double shortSide = 0;
			double middleSide = 0;
			for (int i = 0; i < 3; i++)
			{
				if (longSide < sides[i])
				{
					longSide = sides[i];
					shortSide = longSide;
				}
			}
			for (int i = 0; i < 3; i++)
			{
				if (shortSide > sides[i])
				{
					shortSide = sides[i];
				}
			}
			for (int i = 0; i < 3; i++)
			{
				if (sides[0] != sides[1] & sides[1] != sides[2] & sides[2] != sides[0])
				{
					if (sides[i] < longSide & sides[i] > shortSide)
                    {
						middleSide = sides[i];
                    }
				}
				else
                {
					middleSide = shortSide;
                }
			}
			if (Math.Round(longSide * longSide, 3) - Math.Round(shortSide * shortSide, 3) == Math.Round(middleSide * middleSide, 3))
            {
				return true;
            }
			else
            {
				return false;
            }
		}
	}
}