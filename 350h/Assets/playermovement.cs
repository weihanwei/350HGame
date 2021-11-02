
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rd;
    public float forwardForce = 2000f;
    public float sodewaysForace = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello ,world!");
        rd.useGravity = false;
       // rd.addForce();
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetKey("w");
    }
    void FixedUpdate() {
        rd.AddForce(0,0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rd.AddForce(sodewaysForace * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rd.AddForce(-sodewaysForace * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
