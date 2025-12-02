using UnityEngine;

public class BarrierMoveTrigger : MonoBehaviour
{
    public GameObject barrierTimeline;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        barrierTimeline.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        barrierTimeline.gameObject.SetActive(true);
    }
}
