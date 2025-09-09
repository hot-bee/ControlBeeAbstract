using ControlBeeAbstract.Constants;
using Dict = System.Collections.Generic.Dictionary<string, object?>;

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

    void OnBeforeInitialize(int channel);

    void JerkRatioSCurveMove(int channel, double position, double velocity, double acceleration,
        double deceleration, double accelJerkRatio, double decelJerkRatio);

    void JerkRatioSCurveMultiMove(JerkRatioSCurveMoveParameter[] parameters);

    void InterpolateMove((int channel, double position)[] channelAndPositions, double velocity, double acceleration,
        double deceleration, double accelJerkRatio, double decelJerkRatio);

    public void JerkRatioSCurveRelativeMove(int channel, double distance, double velocity, double acceleration,
        double deceleration,
        double accelJerkRatio, double decelJerkRatio);

    void Wait(int channel, PositionType type = PositionType.CommandAndActual);
    void Wait(int channel, int timeout, PositionType type = PositionType.CommandAndActual);
    bool IsMoving(int channel, PositionType type = PositionType.CommandAndActual);
    void SetCommandAndActualPosition(int channel, double position);
    void SetCommandPosition(int channel, double position);
    void SetActualPosition(int channel, double position);
    void SetAcceleration(int channel, double acceleration);
    void SetDeceleration(int channel, double deceleration);
    void SetAccelJerk(int channel, double jerk);
    void SetDecelJerk(int channel, double jerk);
    double GetCommandPosition(int channel);
    double GetActualPosition(int channel);
    double GetCommandVelocity(int channel);
    double GetActualVelocity(int channel);
    void BuiltinInitialize(int channel);

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

    public void SetSyncGearRatio(int masterChannel, int slaveChannel, double gearRatio, double velocity,
        double acceleration,
        double deceleration, double accelJerkRatio, double decelJerkRatio);

    public void SpecialCommand(int channel, Dict data);
}