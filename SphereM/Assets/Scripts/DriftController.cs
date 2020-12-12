using UnityEngine;

public class DriftController : MonoBehaviour, IDriftInfoProvider
{
    public bool IsDrifting { get; private set; }
    private IInputProvider input;

    private void Awake()
    {
        input = GetComponent<IInputProvider>();
    }

    void Update()
    {
        IsDrifting = input.DriftHeld;
    }
}
