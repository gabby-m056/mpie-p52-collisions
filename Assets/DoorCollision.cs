using UnityEngine;

public class DoorCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        GameObject parent = transform.parent.gameObject;
        Animation a = parent.GetComponent<Animation>();
        a.Play("Open_Animation");
    }
}
