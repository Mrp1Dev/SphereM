using System.Collections.Generic;
using UnityEngine;

public class OrthogonalFriction : MonoBehaviour
{
    private List<GameObject> affected = new List<GameObject>();

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<IFrictionAffected>(out var IFrictionAffected))
        {
            affected.Add(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IFrictionAffected>(out var IFrictionAffected))
        {
            affected.Remove(collision.gameObject);
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < affected.Count; i++)
        {
            var frictionAffected = affected[i].GetComponent<IFrictionAffected>();
            var affectedRigidbody = affected[i].GetComponent<Rigidbody>();

            //1 when velocity is orthogonal to the ball's forward, 0 when same.
            var frictionCoef = Mathf.Lerp(0f, frictionAffected.Friction,
                1f - Vector3.Dot(affectedRigidbody.velocity.normalized, affectedRigidbody.transform.forward));

            var speedReduction = (1f - frictionAffected.SpeedLossPercent / 100f);

            //Does the friction, only reduces relative forward speed by a set %
            affectedRigidbody.velocity -= (affectedRigidbody.velocity -
                Vector3.Project(affectedRigidbody.velocity, affectedRigidbody.transform.forward) *
                speedReduction) * frictionCoef;
        }
    }
}
