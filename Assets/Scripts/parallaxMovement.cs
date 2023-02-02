using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallaxMovement : MonoBehaviour
{

    private float startPos;
    private float length;
    [SerializeField] private float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * parallaxEffect);
        if (Mathf.Abs(transform.position.y) > startPos + length)
        {
            transform.position = new Vector3(transform.position.x, startPos, transform.position.z);
        } else if (Mathf.Abs(transform.position.y) > startPos + length)
        {
            transform.position = new Vector3(transform.position.x, startPos, transform.position.z);
        }
    }
}
