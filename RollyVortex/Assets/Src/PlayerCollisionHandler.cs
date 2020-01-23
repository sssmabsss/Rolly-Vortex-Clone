using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
    public int SectionsTraversed = 0; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Obstacle"))
        {
            Debug.Log("omae wa mou shindeiru");
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PipeSection"))
        {
            ++SectionsTraversed;
        }
    }

}
