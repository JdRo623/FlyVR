using UnityEngine;
using System.Collections;

public class StateMoveDown : MovementState {
    public Vector3 movementVector;
    public float speedDown;
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
        movementVector.y = speedDown * Time.deltaTime *-1;
        mob.transform.Translate(movementVector);
    }
}
