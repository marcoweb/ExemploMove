using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3f;

    private Rigidbody2D rb;
    private Vector2 direcaoDeMovimento;

    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        direcaoDeMovimento = new Vector2(horizontal, vertical);
    }

    void FixedUpdate() {
        Vector3 movePosition = (velocidade * Time.fixedDeltaTime * direcaoDeMovimento) + rb.position;
        rb.MovePosition(movePosition);
    }
}
