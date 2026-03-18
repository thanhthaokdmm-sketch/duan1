using UnityEngine;

public class cuadich : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Cua dich da san sang");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            nhanvat nv = other.GetComponent<nhanvat>();

            if (nv.coChiaKhoa == true)
            {
                Debug.Log("Chuc mung! Ban da ve dich!");
            }
            else
            {
                Debug.Log("Ban can chia khoa de mo cua!");
            }
        }
    }
}
