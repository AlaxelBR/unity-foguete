using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaTiro : MonoBehaviour
{
    public GameObject canhao;
    public GameObject tiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiro, new Vector3(canhao.transform.position.x, canhao.transform.position.y, canhao.transform.position.z), canhao.transform.rotation);
        }
    }
}
