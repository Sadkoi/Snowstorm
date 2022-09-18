using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    public GameObject target;
    public GameObject target2;
    public GameObject swivel;
    public GameObject camera;

    private float smooth = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update(){
        swivel.transform.position = target.transform.position;
        Vector3 euler = swivel.transform.eulerAngles;
        euler.y = Mathf.LerpAngle(euler.y, target.transform.rotation.eulerAngles.y, smooth);
        euler.x = Mathf.LerpAngle(euler.x, target.transform.rotation.eulerAngles.x, smooth);
        euler.z = Mathf.LerpAngle(euler.z, target.transform.rotation.eulerAngles.z, smooth);
        swivel.transform.eulerAngles = euler;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        
    }
}
