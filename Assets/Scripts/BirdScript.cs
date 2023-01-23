using UnityEngine;

public class BirdScript : MonoBehaviour {

    public Rigidbody2D birdRigidBody2D;
    public float flapSpeed = 10f; 
    public LogicManagerScript logicScript;
    public bool birdIsAlive = true;

    void Start() {
        logicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            birdRigidBody2D.velocity = Vector2.up * flapSpeed;  
        }
    }

    private void OnCollisionEnter2D() {
        logicScript.GameOver();
        birdIsAlive = false;
    }
}
