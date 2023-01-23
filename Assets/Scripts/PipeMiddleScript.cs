using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour {
    // Start is called before the first frame update
    public LogicManagerScript logicScript;
    void Start() {
        logicScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.layer == 3) {
            logicScript.AddScore(1);
        }
    }
}
