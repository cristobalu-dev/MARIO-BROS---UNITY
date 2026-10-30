using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody2D cuerpo;
    [SerializeField] private float velocidad;
    [SerializeField] private SpriteRenderer spriteRenderer;


    public Transform floorCollission;
    public float RadioFloor;
    public bool is_onfloor;
    public LayerMask QueEsPiso;


    [SerializeField] private Animator anim;

    private float xPosLastFrame;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>();
        velocidad = 15;
        
    }

    // Update is called once per frame
    void Update()
    {   
        
        float movHorizontal = Input.GetAxis("Horizontal");
        //float movVertical = Input.GetAxis("Vertical");

        //cuerpo.linearVelocity = new Vector2(movHorizontal, movVertical) * velocidad;
        cuerpo.linearVelocity = new Vector2(movHorizontal * velocidad, cuerpo.linearVelocity.y);

        if (is_onfloor == true)
        {
            anim.SetBool("jump", false);
            if(movHorizontal != 0)
            {
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            } 
        } else
        {
            anim.SetBool("isRunning", false);
            anim.SetBool("jump", true);
        }


        if(Input.GetButtonDown("Jump") && is_onfloor){
            GetComponent<AudioSource>().Play();
            cuerpo.AddForce(new Vector2(0,1) *2000);
        }

        is_onfloor = Physics2D.OverlapCircle(floorCollission.position, RadioFloor, QueEsPiso);

        flipPlayerX();
    }


    private void flipPlayerX()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1,1,1);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("power"))
        {
            transform.localPosition = new Vector3(-369.96f,-175.325f,0);
        }
    }
}
