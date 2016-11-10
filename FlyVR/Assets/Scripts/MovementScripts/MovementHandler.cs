using UnityEngine;
using System.Collections;

public class MovementHandler : MovementState {
    public Vector3 movementVector;
    public GameObject mob;
    public float speedSides;
	// Use this for initialization
	void OnEnable () {
       movementVector=new Vector3(0,0,0);
}

// Update is called once per frame
void Update () {
        Debug.Log("MovementHandler");
        SetRotation();
        MoveSides();
    }
    void SetRotation() {
    mob.transform.rotation = new Quaternion(0
    , Camera.main.transform.localRotation.y
    , mob.transform.rotation.z
    , mob.transform.rotation.w);
        mob.transform.Translate(movementVector);
    }
    void MoveSides() { 
        movementVector.y = Camera.main.transform.rotation.x * speedSides * -1 * Time.deltaTime;
        movementVector.x = Camera.main.transform.rotation.z * speedSides*-1*Time.deltaTime;
    }
    void Move2CenterFromSides(int side) {

    }
    void OnTriggerEnter(Collider other) {
    }
}
