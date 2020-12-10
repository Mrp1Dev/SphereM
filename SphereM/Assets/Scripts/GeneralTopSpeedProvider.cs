using UnityEngine;

public class GeneralTopSpeedProvider : MonoBehaviour, ITopSpeedProvider
{
    [SerializeField]
    private float stockTopSpeed;
    public float TopSpeed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        TopSpeed = stockTopSpeed;
    }
}
