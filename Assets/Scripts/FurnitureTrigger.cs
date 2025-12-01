using UnityEngine;

public class FurnitureTrigger : MonoBehaviour
{
    public GameObject Timeline;
    public GameObject Trigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Timeline.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
        Timeline.gameObject.SetActive(true);
        Destroy(Trigger);
        
    }
}
