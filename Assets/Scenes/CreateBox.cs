using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBox : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cube = Instantiate(cubePrefab, new Vector3(0,0,0), Quaternion.identity);
            cube.transform.position = new Vector3(0, 0, 0);
            cube.transform.localScale = new Vector3(1, 1, 1);
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
