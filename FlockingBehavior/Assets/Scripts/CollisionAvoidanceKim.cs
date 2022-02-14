using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoidanceKim : Kinematic
{
    CollisionAvoidance myMoveType;



    public Kinematic[] myTargets;
    private void Start()
    {
        myMoveType = new CollisionAvoidance();
        myMoveType.character = this;
        myMoveType.targets = myTargets;




    }

    protected override void Update()
    {
        steeringUpdate = myMoveType.getSteering();    
        base.Update();
    }
}
