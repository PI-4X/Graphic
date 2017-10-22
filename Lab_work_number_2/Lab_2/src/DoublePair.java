/**
 * Created by Admin on 22.10.17.
 */
public class DoublePair {
    private double x;
    private double y;
    public DoublePair(double _x, double _y)
    {
        x = _x;
        y = _y;
    }
    public  double getMinValue()
    {
        return x > y ? y : x;
    }
    public  double getMaxValue()
    {
        return x > y ? x : y;
    }

    public void changeValue(DoublePair pair) {
        this.x = pair.x;
        this.y = pair.y;
    }
}
