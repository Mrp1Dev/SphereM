using UnityEngine;

public abstract class AffectedByStates : MonoBehaviour
{
    protected IDriftInfoProvider driftInfo;
    protected IDriftMultipliers driftMultipliersProvider;

    protected virtual void Awake()
    {
        driftInfo = GetComponent<IDriftInfoProvider>();
        driftMultipliersProvider = GetComponent<IDriftMultipliers>();
    }
}
