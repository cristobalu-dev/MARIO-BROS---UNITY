using UnityEngine;

public class power : MonoBehaviour
{

    public float x;
    public float y;
    public float z;
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.tag == "mario")
        {
            collision.transform.position = new Vector3(x,y,z);
            GetComponent<AudioSource>().Play();
        }
    }
}