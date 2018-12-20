using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class TVTurnOff : MonoBehaviour {

    public float TheDistance;
    //Public float variable for distance to object

    public GameObject ActionKeyText;
    //Public GameObject variabe for our Action Key Text

    public GameObject ActionText;
    //Public GameObject variable to out Action Text for the TV

    public GameObject TVScreen;
    //Public GameObject variable for TV Screen

    public GameObject TVLight;
    //Public GameObject variable for TV light

    public GameObject Skull;
    //Public GameObject variable for out Skull crosshair

    public GameObject RedSkull;
    //Public GameObject variable for our Alt crosshair

    public float DistanceAway = 2f;
    //Public float variable for our required distance to object


    void Update()
    {

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
                if (TVScreen.GetComponent<MeshRenderer>().enabled)
                {
                    TVScreen.GetComponent<MeshRenderer>().enabled = false;
                    TVLight.GetComponent<Light>().enabled = false;
                    TVScreen.GetComponent<VideoPlayer>().enabled = false;
                    //Disable TV & light if on
                } else
                {
                    TVScreen.GetComponent<MeshRenderer>().enabled = true;
                    TVLight.GetComponent<Light>().enabled = true;
                    TVScreen.GetComponent<VideoPlayer>().enabled = true;
                    //Enable TV if off
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
