using UnityEngine;

public class DoorSlamTrigger : MonoBehaviour
{
    public GameObject Timeline;
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

    }
}
