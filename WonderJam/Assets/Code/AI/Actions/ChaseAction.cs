﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "AI/Actions/Chase")]

public class ChaseAction : Action {

    public override void Execute(StateController controller)
    {
        Chase(controller);
    }

    private void Chase(StateController controller)
    {

    }
}
