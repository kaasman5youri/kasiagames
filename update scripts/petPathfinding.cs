using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petPathfinding : MonoBehaviour
{
    public int petSpeed;
    public int detectDistance;
    float deltaPosX;
    float deltaPosZ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("player");
        deltaPosX = transform.position.x - Player.transform.position.x;
        deltaPosZ = transform.position.z - Player.transform.position.z;

        if (deltaPosX > -detectDistance && deltaPosX < detectDistance && deltaPosZ > -detectDistance && deltaPosZ < detectDistance && float.IsNaN(FlowFieldProvider.GetVector(transform.position).x) == false && float.IsNaN(FlowFieldProvider.GetVector(transform.position).y) == false && float.IsNaN(FlowFieldProvider.GetVector(transform.position).z) == false)
        {
            Vector3 direction = FlowFieldProvider.GetVector(transform.position);
            transform.position = transform.position + direction * petSpeed / 10;
        }
    }
}
