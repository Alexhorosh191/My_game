using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class Rotation : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 0 + moveSpeed) * Time.deltaTime);
        
    }
}

//transform.Rotate(new Vector3(0, 0, 360) * Time.deltaTime);