using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour {

    public GameObject PlayerGun;
    //Player's gun

    public GameObject GunFlash;
    //Gun flash

    public AudioSource PistolShot;
    //Gun sound

    public bool IsShot = false;
    //Shooting bool


	void Update () {

        if(Input.GetButtonDown("Fire1"))
        {
            if (IsShot == false)
            {
                StartCoroutine(ShootGun());
                //Check for player firing gun
            }
        }
		
	}

    IEnumerator ShootGun()
    {
        IsShot = true;
        //Enable shooting bool

        PlayerGun.GetComponent<Animation>().Play("PistolShoot");
        //play gun shooting animation

        GunFlash.SetActive(true);
        GunFlash.GetComponent<Animation>().Play("GunFlashAnim");
        PistolShot.Play();
        //Play gun flash & sounds

        yield return new WaitForSeconds(0.5f);
        GunFlash.SetActive(false);
        //Disable gun flash

        IsShot = false;
        //Disable shooting bool
    }
}
