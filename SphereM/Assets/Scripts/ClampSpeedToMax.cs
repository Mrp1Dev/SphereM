using UnityEngine;

public class ClampSpeedToMax : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    private StatsProvider statsProvider;

    // Start is called before the first frame update
    void Awake()
    {
        statsProvider = GetComponent<StatsProvider>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var topSpeed = statsProvider.Stats.topSpeedKPH;
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, topSpeed/3.6f);
    }
}
