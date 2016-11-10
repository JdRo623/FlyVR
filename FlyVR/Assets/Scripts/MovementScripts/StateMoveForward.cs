using UnityEngine;
using System.Collections;

public class StateMoveForward : MovementState {
    public Vector3 movementVector;
    public float speedFoward;
    private GameObject mob;
    // Use this for initialization
    void Start () { 
        mob = MovementStateHandler.mob;
	}
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = mob.transform.position;
        movementVector.z = speedFoward * Time.deltaTime;
        mob.transform.Translate(movementVector);
    }
}
