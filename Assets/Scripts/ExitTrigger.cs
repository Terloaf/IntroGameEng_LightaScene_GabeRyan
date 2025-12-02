using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    public GameObject ExitTimeline;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ExitTimeline.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ExitTimeline.gameObject.SetActive(true);
        Destroy(gameObject);
    }
}
