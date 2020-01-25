using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTiro : MonoBehaviour
{
    public float velTiro = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(velTiro * Time.deltaTime,0));
    }
}
