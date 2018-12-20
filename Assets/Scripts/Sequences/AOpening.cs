using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class AOpening : MonoBehaviour {

    public GameObject ThePlayer;
    //Public GameObject variabe for the player

    public GameObject FadeScreenIn;
    //Public GameObject for black image

    public Image FadeImage;
    //Public Image variable for black image

    public GameObject TextBox;
    //Public GameObject variable for text box


	void Start () {

        FadeScreenIn.SetActive(true);
        //Enable black screen

        FadeImage.canvasRenderer.SetAlpha(1.0f);
        //Set image alpha to 1

        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        //Disable player

        StartCoroutine(ScenePlayer());
        //Start scene
	}

    IEnumerator ScenePlayer()

    {
        yield return new WaitForSeconds(1f);
        //Wait 1 second

        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        //Enable player

        FadeImage.CrossFadeAlpha(0.0f, 1.5f, false);
        //Fade out black image

        TextBox.GetComponent<Text>().text = "Where am I?";
        //Display text

        yield return new WaitForSeconds(1.5f);
        //wait 1.5 seconds

        FadeScreenIn.SetActive(false);
        //Disable black image

        TextBox.GetComponent<Text>().text = "";
        //Clear text

        yield return new WaitForSeconds(3f);
        //Wait 3 seconds

        TextBox.GetComponent<Text>().text = "I need to find a way out...";
        //Display text

        yield return new WaitForSeconds(2.5f);
        //Wait 2.5 seconds

        TextBox.GetComponent<Text>().text = "";
        //Clear text box
    }
}
