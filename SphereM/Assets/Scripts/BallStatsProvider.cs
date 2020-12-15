using UnityEngine;

public class BallStatsProvider : StatsProvider
{
    [SerializeField]
    private Stats stockStats;
    public override Stats Stats { get => currentStats; protected set => currentStats = value; }

    [SerializeField]
    private DriftInfoProvider driftInfoProvider;
    private Stats driftMultipliers;
    private Stats currentStats;

    [SerializeField]
    private float driftChangesSpeed;


    private void Start()
    {
        driftMultipliers = driftInfoProvider.Multipliers;
    }

    private void Update()
    {

        if (driftInfoProvider.IsDrifting)
        {
            currentStats.acceleration +=
                ApplyMultiplier(stockStats.acceleration, driftMultipliers.acceleration);

            currentStats.topSpeedKPH += ApplyMultiplier(stockStats.topSpeedKPH, driftMultipliers.topSpeedKPH);

            currentStats.friction +=
                ApplyMultiplier(stockStats.friction, driftMultipliers.friction);

            currentStats.speedLossPercent +=
                ApplyMultiplier(stockStats.speedLossPercent, driftMultipliers.speedLossPercent);

            currentStats.turnSpeed +=
                ApplyMultiplier(stockStats.turnSpeed, driftMultipliers.turnSpeed);
        }
        else
        {
            currentStats = stockStats;

        }
    }

    private float ApplyMultiplier(float baseValue, float multiplier)
    {
        return baseValue * multiplier - baseValue;
    }
}
