using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEngine : MonoBehaviour
{
    public float Speed = -1;

    public float DepthToDiscardSection = -20f;
    public float DepthToSpawnNewSection = 48f;

    public float PipeSectionDepth = 12;

    public PipeGenerator Generator = null;

    public bool _isIdle = true;

    public GameObject startButtonPanel;

    private void Start()
    {
        _isIdle = true;
        startButtonPanel.SetActive(true);

    }

    public void OnGameStart()
    {
        if (_isIdle)
        {
            startButtonPanel.SetActive(false);
            _isIdle = false;
        }
    }

    void Update()
    {
            if (!_isIdle)
            {
                float LastSectionDepth = 0f;
                Vector3 movement = Vector3.forward * Speed * Time.deltaTime;
                foreach (Transform child in transform)
                {
                    child.Translate(movement);

                    if (LastSectionDepth < child.transform.position.z)
                    {
                        LastSectionDepth = child.transform.position.z;
                    }

                    if (child.transform.position.z < DepthToDiscardSection)
                    {
                        Generator.DiscardPipeSelection(child.gameObject);
                    }


                }

                if (LastSectionDepth < DepthToSpawnNewSection)
                {
                    Generator.SpawnPipeSection(new Vector3(0f, 0f, LastSectionDepth + PipeSectionDepth));
                }
            }
    }
}
