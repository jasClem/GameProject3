using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {

    public static float DistanceFromTarget;
    //Public Static Float Variable to show distance from target

    public float ToTarget;
    //Public float to show distance to target
	
	void Update () {

        RaycastHit Hit;
        //Raycast hit variable to check for hits looking forward

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            //Change ToHit to distance to objects in front of player

            DistanceFromTarget = ToTarget;
            //Change DistanceFromTaret to distance of objects in front of player
        }

    }
}
