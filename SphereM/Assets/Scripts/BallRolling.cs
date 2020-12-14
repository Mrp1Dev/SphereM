using UnityEngine;

public class BallRolling : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb = default;
    [SerializeField]
    private float radius = 0.5f;
    // Update is called once per frame
    void Update()
    {
        float distance = (rb.velocity * Time.deltaTime).magnitude;
        float angle = distance * (180f / Mathf.PI) / radius;

        //rotates the ball on it's parent's right axis depending on the distance travelled.
        transform.localRotation =
            Quaternion.Euler(Vector3.right * angle) * transform.localRotation;
    }
}
