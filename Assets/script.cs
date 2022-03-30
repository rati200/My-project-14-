using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{   

   [SerializeField] private GameObject go;

     

      [SerializeField] private Vector2 v2;


    // Start is called before the first frame update
    void Start()
    {
        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if(Input.GetKey(KeyCode.Space)){
            Instantiate(go, v2, Quaternion.identity);}

        

    }
}
