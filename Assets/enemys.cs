using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("Cube");

        // プレハブを元にオブジェクトを生成する
        GameObject instance = (GameObject)Instantiate(obj,
                                                      new Vector3(5.0f, 0.0f, 0.0f),
                                                      Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
