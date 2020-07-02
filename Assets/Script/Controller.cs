using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // ←・→　押下時の処理
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += transform.forward * 0.04f;

        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            transform.position -= transform.forward * 0.04f;
        }
    }

    // 衝突の瞬間判定
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + "Enter");
    }

    // 衝突中の判定
    void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name + "Stay");
    }

    // 衝突離脱の判定
    void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "Exit");
    }


}
