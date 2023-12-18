using UnityEngine;
using UnityEngine.SceneManagement;


public class BallDestroy : MonoBehaviour
{
    public ParticleSystem dethPS;

    public void DestroyThisBall ()
    {
        dethPS.Play();
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        Invoke("Restart", 3f);
    }

    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
