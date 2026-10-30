using UnityEngine;

public class BotonSound : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = .2f;
    private float lastClickTime;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float timeSinceLastClick = Time.time - lastClickTime;

            if(timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                Camera.main?.GetComponent<AudioSource>().Stop();
            } else
            {
                Camera.main?.GetComponent<AudioSource>().Play();
            }
            lastClickTime = Time.time;
        }
    }
}
