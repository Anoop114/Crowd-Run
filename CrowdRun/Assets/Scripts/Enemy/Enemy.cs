using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            Handheld.Vibrate();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
