using UnityEngine;
using System.Collections;

public class StateMoveRigth : MovementState {

    public Vector3 movementVector;
    public float speedRigth;
    private GameObject mob;
    public float resetTime;
    // Use this for initialization
    void Start()
    {
        mob = MovementStateHandler.mob;
    }
    void OnEnable()
    {
        movementVector = new Vector3(0, 0, 0);
        Invoke("resetState", resetTime);
    }
    void resetState()
    {
        GetComponentInChildren<MovementStateHandler>().initConfig();
    }
    // Update is called once per frame
    void Update()
    {
        movementVector.x = speedRigth * Time.deltaTime;
        mob.transform.Translate(movementVector);
    }
}
