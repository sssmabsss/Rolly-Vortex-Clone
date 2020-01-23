using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{

    public GameObject PipeSectionPrefab = null;
    public GameObject pipeContainer = null;

    public GameObject PipeObstaclePrefab = null;
    public int PipeSubdivision = 12;

    public List<ObstacleConfiguration> ObstacleConfigs = new List<ObstacleConfiguration>();

    public Material ObstacleMaterial = null;

    void Start()
    {
        
    }

    public void SpawnPipeSection(Vector3 position)
    {

       GameObject section = GameObject.Instantiate(
                                PipeSectionPrefab,
                                position,
                                Quaternion.identity,
                                pipeContainer.transform);

        Transform obstacleContainer = section.transform.Find("ObstacleContainer");


        int index = Random.Range(0, ObstacleConfigs.Count);
        ObstacleConfiguration config = ObstacleConfigs[index];

        

        for (int i = 0; i < PipeSubdivision; i++)
        {
            if (config.Obstacles[i])
            {

                float currentRotation = 30f * i;

                GameObject obstacle = Instantiate(PipeObstaclePrefab, obstacleContainer);
                obstacle.transform.localPosition = new Vector3(
                    Mathf.Cos(currentRotation * Mathf.Deg2Rad) * 5f,
                    Mathf.Sin(currentRotation * Mathf.Deg2Rad) * 5f,
                    0f);

                obstacle.transform.rotation = Quaternion.Euler(0f, 0f, currentRotation);

                MeshRenderer mesh = obstacle.GetComponent<MeshRenderer>();
                mesh.material = ObstacleMaterial;
            }
        }
    
    }

    public void DiscardPipeSelection(GameObject PipeSection)
    {
        Destroy(PipeSection);
    }
}
