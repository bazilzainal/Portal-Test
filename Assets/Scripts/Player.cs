using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public float hInput;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
    }

    public void FixedUpdate()
    {


        if (hInput != 0)
        {
            rb.AddForce(new Vector2(hInput * moveSpeed * Time.fixedDeltaTime, 0));
        }
        
    }
}