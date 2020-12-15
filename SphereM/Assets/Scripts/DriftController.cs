using UnityEngine;

public class DriftController : DriftInfoProvider
{
    [SerializeField]
    private Stats driftMultipliers;
    public override Stats Multipliers { get; protected set ; }
    public override bool IsDrifting { get; protected set; }

    private IInputProvider input;

    private void Awake()
    {
        input = GetComponent<IInputProvider>();
        Multipliers = driftMultipliers;
        IsDrifting = input.DriftHeld;
    }

    void Update()
    {
        Multipliers = driftMultipliers;
        IsDrifting = input.DriftHeld;
    }
}
