using UnityEngine;

public class GeneralTopSpeedProvider : AffectedByStates, ITopSpeedProvider
{
    [SerializeField]
    private float stockTopSpeed;
    public float TopSpeed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        TopSpeed = stockTopSpeed;
    }

    void Update()
    {
        TopSpeed = stockTopSpeed;
        if (driftInfo.IsDrifting)
        {
            float multiplier = driftMultipliersProvider.DriftMultipliers.topSpeed;
            TopSpeed += stockTopSpeed * multiplier - stockTopSpeed;
        }
    }
}
