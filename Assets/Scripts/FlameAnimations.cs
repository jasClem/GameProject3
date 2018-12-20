using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimations : MonoBehaviour
{

    public int LightMode;
    //Integer variable to change light animation

    public GameObject FlameLight;
    //GameObject variable for light

    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(AnimateLight());
            // vvv - Start Light Corutine - vvv
        }

    }

    IEnumerator AnimateLight()
    {
        LightMode = Random.Range(1, 4);
        //Random number for light animation cycle

        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim1");
            //First randomly selected animation
        }
        if (LightMode == 2)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim2");
            //Second randomly selected animation
        }
        if (LightMode == 3)
        {
            FlameLight.GetComponent<Animation>().Play("TorchAnim3");
            //Third randomly selected animation
        }

        yield return new WaitForSeconds(0.99f);
        //Wait for selected time.

        LightMode = 0;
        //Reset integer for randomization

    }
}
