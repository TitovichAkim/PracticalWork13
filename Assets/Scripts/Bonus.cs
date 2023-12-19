using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bonus : MonoBehaviour
{
    public ParticleSystem captureEffect;
    public GameObject panelWithText;
    public GameObject coin;
    public GameObject lucky;
    public void Trigger (GameObject trigger)
    {
        if(trigger.CompareTag("ball"))
        {
            lucky = trigger;
            captureEffect.Play();
            panelWithText.SetActive(true);
            Destroy(coin);
            Invoke("DestroyBall", 3f);
        }
    }
    public void DestroyBall ()
    {
        panelWithText.SetActive(false);
        if(lucky != null)
        {
            lucky.GetComponent<BallDestroy>().DestroyThisBall();
            Destroy(this.gameObject);
        }
    }
}
