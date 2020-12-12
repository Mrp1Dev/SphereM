using UnityEngine;

public class Multipliers : MonoBehaviour, IDriftMultipliers, INitroMultipliers
{
    [SerializeField]
    private StatMultipliers driftMultipliers;
    public StatMultipliers DriftMultipliers => driftMultipliers;

    [SerializeField]
    private StatMultipliers nitroMultipliers;
    public StatMultipliers NitroMultipliers => nitroMultipliers;
}
