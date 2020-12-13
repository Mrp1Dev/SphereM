using TMPro;
using UnityEngine;

public class RelativeForwardSpeedMeter : MonoBehaviour
{
    [SerializeField]
    private Rigidbody objectRigibody;

    [SerializeField]
    private TMP_Text text;

    private void Update()
    {
        text.text = GetSpeedString();
    }

    private string GetSpeedString()
    {
        string relativeForwardSpeed = 
            (Vector3.Project(objectRigibody.velocity, objectRigibody.transform.forward).magnitude
            * 3.6f).ToString("F0");//3.6 is m/s to km/h
        return "Speed: " +
            relativeForwardSpeed  + "km/h";
    }
}
