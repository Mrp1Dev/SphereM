using UnityEngine;

public abstract class StatsProvider : MonoBehaviour
{
    public abstract Stats Stats { get; protected set; }
}
