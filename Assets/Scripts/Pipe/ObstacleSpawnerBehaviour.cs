using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerBehaviour : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject container;

    public float nextSpawnInSeconds = 1f;
    public float distance;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > nextSpawnInSeconds)
        {
            GameObject tmp = Instantiate(pipePrefab);
            tmp.transform.position = transform.position + new Vector3(0f, Random.Range(-distance, distance), 0f);
            tmp.transform.parent = container.transform;

            _timer = 0;

            Destroy(tmp, 3f);
        }

        _timer += Time.deltaTime;
    }
}
