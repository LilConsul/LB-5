using System;
using System.ComponentModel;

public class CosX : Component {
    private readonly double min = 0.00001;
    private readonly double x;
    private readonly double sqrX;

    public CosX(double x) {
        this.x = x;
        this.sqrX = x * x;
    }

    private void Recurs_helper(ref double sum, double curr, int n, int mul) {
        curr = curr * sqrX / n++ / n++;
        sum += mul * curr;
        mul = -mul;
        if(curr > min || curr < -min)
            Recurs_helper(ref sum, curr, n, mul);
    }

    public double Actual() {
        return Math.Cos(x);
    }
    public double Series() {
        double sum = 1, curr = 1;
        int n = 1, mul = -1;
        while (curr > min || curr < -min) {
            curr = curr * sqrX / n++ / n++;
            sum += mul * curr;
            mul = -mul;
        }

        return sum;
    }

    public double Recursive() {
        double sum = 1;
        Recurs_helper(ref sum, 1, 1, -1);
        return sum;
    }
}