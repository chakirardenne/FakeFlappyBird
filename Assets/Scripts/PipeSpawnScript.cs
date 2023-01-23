using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnRate = 10 ;
    private float _timer = 0;
    public float heightOffSet = 10;
    void Start() { 
        SpawnPipe();
    }

    // Update is called once per frame
    void Update() {
        CheckSpawnRate();
    }

    private void SpawnPipe() {
        var lowestPoint = transform.position.y - heightOffSet;
        var highestPoint = transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

    private void CheckSpawnRate() {
        if (_timer < spawnRate) {
            _timer += Time.deltaTime;
        }
        else {
            SpawnPipe();
            _timer = 0;
        }
    }
}
