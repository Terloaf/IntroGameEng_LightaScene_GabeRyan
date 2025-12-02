using UnityEngine;

public class ImageScaler : MonoBehaviour
{
    public GameObject canvasSize;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = canvasSize.transform.localScale;
    }
}
