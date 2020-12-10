using UnityEngine;

public class Turning : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private IInputProvider input;
    private ITurnSpeedProvider turnSpeedProvider;

    // Start is called before the first frame update
    void Awake()
    {
        input = GetComponent<IInputProvider>();
        turnSpeedProvider = GetComponent<ITurnSpeedProvider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.angularVelocity = transform.up * input.HorizontalAxis * turnSpeedProvider.Speed * Time.deltaTime;
    }
}
