using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public int SectionsTraversed = 0;
    public ParticleSystem PS;
    public PipeEngine PE;
    public GameObject Panel;

    private IEnumerator coroutine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Obstacle"))
        {
            PE.Speed = 0;
            PS.Play();
            SceneManager.LoadScene(0);        }   
    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("PipeSection"))
        {

            ++SectionsTraversed;
           
        }
    }

}
