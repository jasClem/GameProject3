using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionKeyText;
    public GameObject ActionTextOpen;
    public GameObject ActionTextClose;
    public GameObject TheDoor;
    public AudioSource CreakSound;

    public bool DoorOpen = false;

    public float DistanceAway = 3f;

    public GameObject Skull;
    public GameObject RedSkull;
	

	void Update () {

        TheDistance = PlayerCasting.DistanceFromTarget;
		
	}

    void OnMouseOver()
    {
        if (!DoorOpen)
        {
            if (TheDistance <= DistanceAway)
            {
                ActionKeyText.SetActive(true);
                ActionTextOpen.SetActive(true);
                Skull.SetActive(false);
                RedSkull.SetActive(true);
            }
            if (Input.GetButtonDown("Action"))
            {
                if (TheDistance <= DistanceAway)
                {
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionKeyText.SetActive(false);
                    ActionTextOpen.SetActive(false);
                    Skull.SetActive(true);
                    RedSkull.SetActive(false);
                    TheDoor.GetComponent<Animation>().Play("DoorOpenAnim");
                    CreakSound.Play();
                    DoorOpen = true;
                }
                if (TheDistance >= DistanceAway)
                {

                }
            }
            if (TheDistance >= DistanceAway)
            {
                ActionKeyText.SetActive(false);
                ActionTextOpen.SetActive(false);
                Skull.SetActive(true);
                RedSkull.SetActive(false);
            }
        }

        else if (DoorOpen)
        {
            if (TheDistance <= DistanceAway)
            {
                ActionKeyText.SetActive(true);
                ActionTextClose.SetActive(true);
                Skull.SetActive(false);
                RedSkull.SetActive(true);
            }
            if (Input.GetButtonDown("Action"))
            {
                if (TheDistance <= DistanceAway)
                {
                    this.GetComponent<BoxCollider>().enabled = false;
                    ActionKeyText.SetActive(false);
                    ActionTextClose.SetActive(false);
                    Skull.SetActive(true);
                    RedSkull.SetActive(false);
                    TheDoor.GetComponent<Animation>().Play("DoorCloseAnim");
                    CreakSound.Play();
                    DoorOpen = false;
                }
                if (TheDistance >= DistanceAway)
                {

                }
            }
            if (TheDistance >= DistanceAway)
            {
                ActionKeyText.SetActive(false);
                ActionTextClose.SetActive(false);
                Skull.SetActive(true);
                RedSkull.SetActive(false);
                this.GetComponent<BoxCollider>().enabled = true;
            }

        }
        
    }

    void OnMouseExit()
    {
        ActionKeyText.SetActive(false);
        Skull.SetActive(true);
        RedSkull.SetActive(false);
        this.GetComponent<BoxCollider>().enabled = true;

        if (!DoorOpen)
        {
            ActionTextOpen.SetActive(false);

        }

        else if (DoorOpen)
        {
            ActionTextClose.SetActive(false);
        }
        

    }
}
