using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGun : MonoBehaviour {

    public float TheDistance;
    //Public float variable for distance to object

    public GameObject ActionKeyText;
    //Public GameObject variabe for our Action Key Text

    public GameObject ActionText;
    //Public GameObject variable to out Action Text for the gun

    public GameObject Gun;
    //Public GameObject variable for the gun object

    public GameObject PlayerGun;
    //Public GameObject vaiable for player's gun

    public GameObject Skull;
    //Public GameObject variable for out Skull crosshair

    public GameObject RedSkull;
    //Public GameObject variable for our Alt crosshair

    public GameObject GreenArrow;
    //Public GameObject variable for the green arrow

    public float DistanceAway = 2f;
    //Public float variable for our required distance to object

	
	void Update () {
        TheDistance = PlayerCasting.DistanceFromTarget;
        //Get player's distance from object

    }

    void OnMouseOver()
    {
        if (TheDistance <= DistanceAway)
        {
            ActionKeyText.SetActive(true);
            ActionText.SetActive(true);
            Skull.SetActive(false);
            RedSkull.SetActive(true);
            //If close to object enable action text/switch crosshair
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= DistanceAway)
            {
                if (TheDistance <= DistanceAway)
                {
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionKeyText.SetActive(false);
                    ActionText.SetActive(false);
                    Skull.SetActive(true);
                    RedSkull.SetActive(false);
                    GreenArrow.SetActive(false);
                    Gun.SetActive(false);
                    PlayerGun.SetActive(true);
                    //If player presses action button, turn of action text/switch crosshair/disable gun prop/enable player gun
                }
                if (TheDistance >= DistanceAway)
                {

                }

            }
            if (TheDistance >= DistanceAway)
            {

            }
        }
        if (TheDistance >= DistanceAway)
        {
            ActionKeyText.SetActive(false);
            ActionText.SetActive(false);
            Skull.SetActive(true);
            RedSkull.SetActive(false);
            //If to far from object disable action text/switch crosshair
        }
    }

    void OnMouseExit()
    {
        ActionKeyText.SetActive(false);
        ActionText.SetActive(false);
        Skull.SetActive(true);
        RedSkull.SetActive(false);
        //If not looking at object disable action text/switch crosshair

    }
}
