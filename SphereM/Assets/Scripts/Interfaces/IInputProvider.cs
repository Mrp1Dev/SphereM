public interface IInputProvider
{
    float RawHorizontalAxis { get; }
    float SmoothedHorizontalAxis { get; }
    bool DriftHeld { get; }
}
