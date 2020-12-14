using UnityEngine;

public class GeneralTurnSpeedProvider : AffectedByStates, ITurnSpeedProvider
{
    [SerializeField]
    private float stockSpeed;

    public float Speed { get; private set; }

    private float dampVelocity;
    

    void Update()
    {
        Speed = stockSpeed;
        if (driftInfo.IsDrifting)
        {
            float driftMultiplier = driftMultipliersProvider.DriftMultipliers.turnSpeed;
            Speed += stockSpeed * driftMultiplier - stockSpeed;
        }
        
    }
}
