using UnityEngine;

public class ClonePlayers : MonoBehaviour
{
    [Header("Reference")]
    public GameObject playerAttractor;
    public GameObject player;
    
    [Header("Change Values")]
    public bool add = false;
    public bool multiply = false;
    public int count = 10;
    
    //private
    private CloningAction palyerCloning;

    void Start()
    {
        palyerCloning = player.GetComponent<CloningAction>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().tag == "Player")
        {
            playerAttractor.SetActive(true);
            if(multiply)
            {
                palyerCloning.ClonePlayer_Multiply(count);
            }
            if(add)
            {
                palyerCloning.ClonePlayer_Sum(count);
            }
            playerAttractor.SetActive(false);
            Destroy(gameObject);
        }
    }
}
