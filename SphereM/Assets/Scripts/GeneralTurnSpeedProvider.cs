using UnityEngine;

public class GeneralTurnSpeedProvider : MonoBehaviour, ITurnSpeedProvider
{
    [SerializeField]
    private float stockSpeed;
    public float Speed { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Speed = stockSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
