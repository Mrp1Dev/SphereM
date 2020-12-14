using UnityEngine;

public class BallStatsProvider : StatsProvider
{
    [SerializeField]
    private Stats stats;

    public override Stats Stats { get; protected set; }

    private void Awake()
    {
        Stats = stats;
    }
}
