namespace LB_5 {
    public class Point {
        private double _x, _actual, _series, _recursive;

        public Point(double x, double actual, double series, double recursive) {
            _x = x;
            _actual = actual;
            _series = series;
            _recursive = recursive;
        }

        public string GetInfo() {
            return "x = " + X +
                   "\tРекурсивно: " + Recursive +
                   "\tІтераційно: " + Series +
                   "\tМатематично: " + Actual;
        }
        
        public double X {
            get => _x;
            set => _x = value;
        }
        
        public double Actual {
            get => _actual;
            set => _actual = value;
        }

        public double Series {
            get => _series;
            set => _series = value;
        }

        public double Recursive {
            get => _recursive;
            set => _recursive = value;
        }
    }
}