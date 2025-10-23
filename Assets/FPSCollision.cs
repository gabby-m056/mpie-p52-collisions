using UnityEngine;

public class FPSCollision : MonoBehaviour
{

    public int playerAmmo =0
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        
        if(other.gameObject.name == "AmmoBox"){
            playerAmmo +=20;
            other.gameObject.SetActive(false);
        }
    }
}
