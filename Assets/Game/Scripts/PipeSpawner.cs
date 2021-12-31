using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    [SerializeField] GameObject pipePrefab;
    [SerializeField] float height;
    [SerializeField] float maxTime = 1;

    private float timer = 0f;

    void Start()
    {
        CreatePipeChangeTransformOpsitionsDestroyLater();
    }

    void Update()
    {
        if(timer > maxTime)
        {
            CreatePipeChangeTransformOpsitionsDestroyLater();

            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void CreatePipeChangeTransformOpsitionsDestroyLater()
    {
        GameObject newPipe = Instantiate(pipePrefab);

        PipeTransformOptions(newPipe.transform);

        WaitAndDestroyPipe(newPipe, 10f);
    }

    private void PipeTransformOptions(Transform pipeTransform)
    {
        pipeTransform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    private void WaitAndDestroyPipe(GameObject pipe, float duration)
    {
        Destroy(pipe, duration);
    }
}
