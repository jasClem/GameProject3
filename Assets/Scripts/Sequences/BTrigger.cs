using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class BTrigger : MonoBehaviour {

    public GameObject TextBox;
    //GameObject Variable for our GUI textbox

    public GameObject GreenArrow;
    //GameObject Variable for our green arrow

    public GameObject TriggerBox;
    //Trigger box collider

    void OnTriggerEnter () {
        GreenArrow.SetActive(true);
        //Enable green arrow

        StartCoroutine(ScenePlayer());
        //Start scene

    }
	

	IEnumerator ScenePlayer () {

        TriggerBox.GetComponent<BoxCollider>().enabled = false;
        //Turn off box collider

        TextBox.GetComponent<Text>().text = "Is that a gun on the table?";
        //Display text

        yield return new WaitForSeconds(2f);
        //Wait 2 seconds

        TextBox.GetComponent<Text>().text = "I might need it...";
        //Display next text

        yield return new WaitForSeconds(2f);
        //Wait 2 seconds

        TextBox.GetComponent<Text>().text = "";
        //Clear textbox

        TriggerBox.SetActive(false);
    }
}
