using UnityEngine;

public class GeneralFrictionAffected : AffectedByStates, IFrictionAffected
{
    [SerializeField]
    private StatsProvider statsProvider;
    public float Friction { get; private set; }

    public float SpeedLossPercent { get; private set; }


    void Update()
    {
        Friction = statsProvider.Stats.friction;
    
        SpeedLossPercent = statsProvider.Stats.speedLossPercent;
    }
}
