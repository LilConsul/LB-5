using System;
using System.Collections.Generic;

namespace LB_5 {
    public class Table {
        public List<Point> Points = new List<Point>();

        public void add(Point point) {
            Points.Add(point);
        }

        public void Generate(double a, double b, double h) {
            try {
                var x = a;
                while (x < b) {
                    var cos = new CosX(x);
                    add(new Point(
                        x:Math.Round(x, 4), 
                        actual:Math.Round(cos.Actual(), 4), 
                        series:Math.Round(cos.Recursive(), 4), 
                        recursive:Math.Round(cos.Series(), 4)));
                    x += h;
                }
            }
            catch (Exception e) {
            }
        }
    }
}