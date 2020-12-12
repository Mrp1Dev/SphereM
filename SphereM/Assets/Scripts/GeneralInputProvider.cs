using UnityEngine;
using UnityEngine.InputSystem;

public class GeneralInputProvider : MonoBehaviour, IInputProvider
{
    public float HorizontalAxis { get; private set; }
    public bool DriftHeld { get; private set; }
    void OnSteer(InputValue input)
    {
        HorizontalAxis = input.Get<float>();
    }

    void OnDrift(InputValue input)
    {
        DriftHeld = input.Get<float>() > Mathf.Epsilon;
    }
    
}
