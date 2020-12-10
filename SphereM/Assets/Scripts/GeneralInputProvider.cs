using UnityEngine;

public class GeneralInputProvider : MonoBehaviour, IInputProvider
{
    public float HorizontalAxis { get; private set; }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
    }
}
