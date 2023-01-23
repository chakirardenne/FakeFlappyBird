using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour {
    // Start is called before the first frame update
    public float pipeSpeed = 5;
    public float deadZone = -45;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.left * (Time.deltaTime * pipeSpeed));
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
