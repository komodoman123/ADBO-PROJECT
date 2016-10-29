using UnityEngine;
using System.Collections;

public class ControllerPocong : MonoBehaviour
{

    public Rigidbody2D rb;
    public bool falling;
    public float jump;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerPrefs.SetInt("speed", 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * PlayerPrefs.GetInt("speed") * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && falling == false)
        {
            rb.velocity = new Vector3(0, jump);
        }
    }
}
