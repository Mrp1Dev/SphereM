using UnityEngine;

public class GeneralAccelerationProvider : AffectedByStates, IAccelerationProvider
{
    [SerializeField] 
    private float stockAcceleration;
    public float Acceleration { get; private set; }

    private void Start()
    {
        Acceleration = stockAcceleration;
    }

    private void Update()
    {
        Acceleration = stockAcceleration;
        if (driftInfo.IsDrifting)
        {
            float multiplier = driftMultipliersProvider.DriftMultipliers.topSpeed;
            Acceleration += stockAcceleration * multiplier - stockAcceleration;
        }
    }
}
