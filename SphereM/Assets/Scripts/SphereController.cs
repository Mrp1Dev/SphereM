using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb = default;
    [SerializeField]
    private StatsProvider statsProvider;
    private Stats stats;
    private IInputProvider inputProvider;

    private void Awake()
    {
        inputProvider = GetComponent<IInputProvider>();
    }

    private void Update()
    {
        stats = statsProvider.Stats;
    }

    private void FixedUpdate()
    {
        rb.velocity += ForwardAccel();
       
        rb.angularVelocity = transform.up * stats.turnSpeed * inputProvider.SmoothedHorizontalAxis;
    }

    private Vector3 ForwardAccel()
    {
        return transform.forward * stats.acceleration * Time.deltaTime;
        
    }
}
