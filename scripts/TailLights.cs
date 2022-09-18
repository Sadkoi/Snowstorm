using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailLights : MonoBehaviour
{
    public Material brakeLights;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") < 0){
            brakeLights.SetColor("_EmissionColor", Color.red);
        }else{
            brakeLights.SetColor("_EmissionColor", Color.black);
        }
    }
}
