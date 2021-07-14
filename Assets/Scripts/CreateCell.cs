using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    // Start is called before the first frame update
    public void Create1()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(gameObject, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
