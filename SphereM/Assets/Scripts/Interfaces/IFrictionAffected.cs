using UnityEngine;

public interface IFrictionAffected
{
    float Friction { get; }
    float SpeedLossPercent { get; }
}
