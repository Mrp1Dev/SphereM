using UnityEngine;

public abstract class DriftInfoProvider : MonoBehaviour
{
    public abstract bool IsDrifting { get; protected set; }
    public abstract Stats Multipliers { get; protected set; }
}
