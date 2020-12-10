using UnityEngine;

public class GeneralAccelerationProvider : MonoBehaviour, IAccelerationProvider
{
    [SerializeField] 
    private float stockAcceleration;
    public float Acceleration { get; private set; }

    private void Start()
    {
        Acceleration = stockAcceleration;
    }
}
