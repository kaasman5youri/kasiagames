using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPathfinding : MonoBehaviour
{
    public int enemySpeed;
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
        int layerMask = 1 << 8;
        GameObject Player = GameObject.Find("player");
        deltaPosX = transform.position.x - Player.transform.position.x;
        deltaPosZ = transform.position.z - Player.transform.position.z;

        if (deltaPosX > -detectDistance && deltaPosX < detectDistance && deltaPosZ + 5 > -detectDistance && deltaPosZ < detectDistance && float.IsNaN(FlowFieldProvider.GetVector(transform.position).x) == false && float.IsNaN(FlowFieldProvider.GetVector(transform.position).y) == false && float.IsNaN(FlowFieldProvider.GetVector(transform.position).z) == false)
        {
            Vector3 direction = FlowFieldProvider.GetVector(transform.position);
            if (!Physics.Raycast(transform.position, direction, enemySpeed * Time.deltaTime + 5, layerMask))
            {
                transform.position = transform.position + direction * enemySpeed / 10;
            }
        }
    }
}
