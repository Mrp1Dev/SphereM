using UnityEngine;
using UnityEngine.Rendering;

public class GeneralFrictionAffected : AffectedByStates, IFrictionAffected
{
    [SerializeField] [Range(0f,1f)]
    private float defaultFriction;
    public float Friction { get; private set; }

    [SerializeField]
    private float speedLossPercent;
    public float SpeedLossPercent { get; private set; }


    void Update()
    {
        Friction = defaultFriction;
        if (driftInfo.IsDrifting)
            Friction +=
                defaultFriction * driftMultipliersProvider.DriftMultipliers.friction - defaultFriction;

        SpeedLossPercent = speedLossPercent;
        if (driftInfo.IsDrifting)
            SpeedLossPercent += 
                speedLossPercent * driftMultipliersProvider.DriftMultipliers.speedLossPercent - speedLossPercent;
    }
}
