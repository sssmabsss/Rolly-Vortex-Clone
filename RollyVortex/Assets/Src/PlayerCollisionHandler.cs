using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public int SectionsTraversed = 0;
    public ParticleSystem PS;
    public PipeEngine PE;

    private IEnumerator coroutine;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Obstacle"))
        {
            PE.Speed = 0;
            PS.Play(); 
        }   
    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("PipeSection"))
        {

            ++SectionsTraversed;
           
        }
    }

}
