namespace ControlBeeAbstract.Devices;

public interface IMotionDevice : IDevice
{
    void Enable(int channel, bool value);
    bool IsEnabled(int channel);
    bool IsAlarmed(int channel);
    void ClearAlarm(int channel);

    void SetTorque(int channel, double torque);

    void TrapezoidalMove(
        int channel,
        double position,
        double velocity,
        double acceleration,
        double deceleration
    );

    void JerkRatioSCurveMove(int channel, double position, double velocity, double acceleration,
        double deceleration, double accelJerkRatio, double decelJerkRatio);

    void Wait(int channel);
    void Wait(int channel, int timeout);
    bool IsMoving(int channel);
    void SetCommandAndActualPosition(int channel, double position);
    void SetCommandPosition(int channel, double position);
    void SetActualPosition(int channel, double position);
    double GetCommandPosition(int channel);
    double GetActualPosition(int channel);
    double GetCommandVelocity(int channel);
    double GetActualVelocity(int channel);

    void StartECam(
        int tableIndex,
        int masterChannel,
        int slaveChannel,
        double[] masterPositions,
        double[] slavePositions
    );

    void StopECam(int tableIndex);
    bool IsECamEnabled(int tableIndex);
    bool GetHomeSensor(int channel);
    bool GetNegativeLimitSensor(int channel);
    bool GetPositiveLimitSensor(int channel);

    void VelocityMove(int channel, double velocity, double acceleration,
        double deceleration, double accelJerkRatio, double decelJerkRatio);

    void Stop(int channel);
    void EStop(int channel);
    void SearchZPhase(int channel, double velocity, double acceleration, double distance);
}