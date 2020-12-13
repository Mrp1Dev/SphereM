using UnityEngine;
using UnityEngine.InputSystem;

public class GeneralInputProvider : MonoBehaviour, IInputProvider
{
    [SerializeField]
    private float smoothSenstivity = 3f;
    public float RawHorizontalAxis { get; private set; }
    
    public bool DriftHeld { get; private set; }

    public float SmoothedHorizontalAxis { get; private set; }

    void OnSteer(InputValue input)
    {
        RawHorizontalAxis = input.Get<float>();
    }

    void OnDrift(InputValue input)
    {
        DriftHeld = input.Get<float>() > Mathf.Epsilon;
    }

    private void Update()
    {
        SmoothedHorizontalAxis = Mathf.
            MoveTowards(SmoothedHorizontalAxis, RawHorizontalAxis, smoothSenstivity * Time.deltaTime);
    }

}
