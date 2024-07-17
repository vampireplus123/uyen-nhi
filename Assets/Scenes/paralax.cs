using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class paralax : MonoBehaviour

{
    // Start is called before the first frame update
    private float startPos, length;
    public GameObject cam;
    public float paralaxEffect;
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = cam.transform.position.x * paralaxEffect;
        float movement = cam.transform.position.x * (1 - paralaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if(movement > startPos + length)
        {
            startPos += length;
        } else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
