using UnityEngine;

public abstract class AffectedByStates : MonoBehaviour
{
    protected DriftInfoProvider driftInfo;
    protected IDriftMultipliers driftMultipliersProvider;

    protected virtual void Awake()
    {
        driftInfo = GetComponent<DriftInfoProvider>();
        driftMultipliersProvider = GetComponent<IDriftMultipliers>();
    }
}
