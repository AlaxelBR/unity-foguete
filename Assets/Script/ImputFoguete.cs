using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImputFoguete : MonoBehaviour
{

    public float vel = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x * Time.deltaTime * vel, y * Time.deltaTime * vel));
    }
}
