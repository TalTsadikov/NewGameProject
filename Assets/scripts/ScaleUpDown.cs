using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpDown : MonoBehaviour
{
    private float limit;
    private bool ReachMaxSize;
    private bool ReachMinSize;
    public float MaxSize;
    public float MinSize;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(limit, limit, limit);
        ReachMaxSize = true;
        ReachMinSize = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (limit >= MaxSize)
        {
            ReachMaxSize = true;
            ReachMinSize = false;
        }
        if (limit <= MinSize)
        {
            ReachMinSize = true;
            ReachMaxSize = false;
        }
        if (ReachMaxSize)
        {
            limit = limit - 0.05f;
            transform.localScale = new Vector3(limit, limit, limit);
        }
        if (ReachMinSize)
        {
            limit = limit + 0.05f;
            transform.localScale = new Vector3(limit, limit, limit);
            ReachMaxSize = false;
        }
    }
}