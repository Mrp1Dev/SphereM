using UnityEngine;

public class ClampSpeedToMax : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private ITopSpeedProvider topSpeedProvider;

    // Start is called before the first frame update
    void Awake()
    {
        topSpeedProvider = GetComponent<ITopSpeedProvider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var topSpeed = topSpeedProvider.TopSpeed;
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, topSpeed);
    }
}
