namespace ControlBeeAbstract.Constants;

public class JerkRatioSCurveMoveParameter
{
    public int Channel { get; set; }
    public double Position { get; set; }
    public double Velocity { get; set; }
    public double Acceleration { get; set; }
    public double Deceleration { get; set; }
    public double AccelJerkRatio { get; set; }
    public double DecelJerkRatio { get; set; }
}
