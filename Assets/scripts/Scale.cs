using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;


    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = pos1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.localScale == pos2.position)
        {
            nextPos = pos1.position;
        }

        transform.localScale = Vector3.MoveTowards(transform.localScale, nextPos, speed * Time.deltaTime);
    }
}