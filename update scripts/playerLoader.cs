using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerLoader : MonoBehaviour
{
    bool done = false;
    public List<GameObject> Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = new List<GameObject>(Resources.LoadAll<GameObject>("DebugTiles"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3 && !done)
        {
            Instantiate(Player[2], new Vector3(250, 0, 150), Quaternion.identity);
            done = true;
        }
    }
}
