using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Teste") {
            Debug.Log("Teste");
        }
    }

    // void OnCollisionStay2D(Collision2D collision) {
    //     Debug.Log("Está Colidindo");
    // }

    // void OnCollisionExit2D(Collision2D collision) {
    //     Debug.Log("Saiu da Colisão");
    // }
}
