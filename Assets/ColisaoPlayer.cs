using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoPlayer : MonoBehaviour
{
    Gerenciador gerenciador = new Gerenciador();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void CollisionManager(Collision2D collision) {
    //     if(collision.gameObject.tag == "Teste") {
    //         Debug.Log("Teste Manager");
    //     }
    // }


    void OnCollisionEnter2D(Collision2D collision){
        gerenciador.TestaColisao(collision);
    }

    void OnCollisionStay2D(Collision2D collision) {
        // CollisionManager(collision);
        gerenciador.TestaColisao(collision);
    }

    // void OnCollisionExit2D(Collision2D collision) {
    //     Debug.Log("Saiu da Colisão");
    // }
}
