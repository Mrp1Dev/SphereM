using UnityEngine;

public class GeneralFrictionAffected : MonoBehaviour, IFrictionAffected
{
    [SerializeField] [Range(0f,1f)]
    private float defaultFriction;
    public float Friction => defaultFriction;

    [SerializeField]
    private float speedLossPercent;
    public float SpeedLossPercent => speedLossPercent;


    void Update()
    {
        
    }
}
