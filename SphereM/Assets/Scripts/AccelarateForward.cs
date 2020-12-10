using UnityEngine;

public class AccelarateForward : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb = default;
    private IAccelerationProvider accelProvider;

    private void Awake()
    {
        accelProvider = GetComponent<IAccelerationProvider>();
    }

    private void FixedUpdate()
    {
        float acceleration = accelProvider.Acceleration;
        rb.velocity += transform.forward * acceleration * Time.deltaTime;
    }
}
