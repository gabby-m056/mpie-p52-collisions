using UnityEngine;

public class FPSCollision : MonoBehaviour
{

    public int playerAmmo =0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")&& playerAmmo >0){
            //shoot
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
            RaycastHit result; 
            if(Physics.Raycast(ray, out result)){
                GameObject g = result.collider.gameObject;
                Animation a = g.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
                playerAmmo--;
            }
           

        }
        else
        {
            AudioSource noAmmo = GetComponent<AudioSource>();
            noAmmo.Play();
        }
    }

    void OnTriggerEnter(Collider other){
        
        if(other.gameObject.name == "AmmoBox"){
            playerAmmo +=20;
            other.gameObject.SetActive(false);
        }
    }
}
