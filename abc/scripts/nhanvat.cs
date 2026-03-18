using UnityEngine;

public class nhanvat : MonoBehaviour
{
    public float speed = 5f;
    public bool coChiaKhoa = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, y, 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
