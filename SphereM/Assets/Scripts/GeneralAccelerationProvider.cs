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
}
