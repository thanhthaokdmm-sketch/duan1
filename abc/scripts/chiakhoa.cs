using UnityEngine;

public class chiakhoa : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Chia khoa da xuat hien");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            nhanvat nv = other.GetComponent<nhanvat>(); // l?y script nhân v?t
            nv.coChiaKhoa = true;                       // ðánh d?u ð? có ch?a khóa

            Destroy(gameObject);                        // xóa ch?a khóa
        }
    }
}
