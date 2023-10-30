using UnityEngine;

public class Gerenciador
{
    public void TestaColisao(Collision2D collision) {
        if(collision.gameObject.tag == "Teste") {
            Debug.Log("Teste : Generenciador");
        }
    }
}
