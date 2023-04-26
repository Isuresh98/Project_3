using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Parallax : MonoBehaviour
{
    public float speed = 0.1f;
    public float endPointOffset = 10f;
    private float length;
    private float startpos;

    // Start is called before the first frame update
    void Start()
    {
        length = GetComponent<Tilemap>().size.x * GetComponent<Tilemap>().cellSize.x;
        startpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = (Camera.main.transform.position.x * speed);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        // Check if the camera has reached the end of the parallax background
        if (Camera.main.transform.position.x > (startpos + length - endPointOffset))
        {
            // Move the parallax background to its original starting position, plus an additional offset
            startpos += length;
        }
        else if (Camera.main.transform.position.x < (startpos - length - endPointOffset))
        {
            // Move the parallax background to its original starting position, minus an additional offset
            startpos -= length;
        }
    }
}
