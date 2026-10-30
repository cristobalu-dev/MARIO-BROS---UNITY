using UnityEngine;

public class accionesMoneda : MonoBehaviour
{
    public AudioClip itemSoundClip;
    public float itemSoundVolume = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "mario")
        {
            AudioSource.PlayClipAtPoint(itemSoundClip, Camera.main.transform.position, itemSoundVolume);
        }

    }
}
