using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrptHareket : MonoBehaviour
{

    public int speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(string.Format("x : {0}", this.transform.position.x.ToString()));
        Debug.Log(string.Format("y : {0}", this.transform.position.y.ToString()));
        Debug.Log(string.Format("z : {0}", this.transform.position.z.ToString()));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0.0)
        {
            this.transform.position = new Vector3(this.transform.position.x - speed, this.transform.position.y, this.transform.position.z);
        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x + speed, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetAxis("Vertical") < 0.0)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - speed);
        } else
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + speed);
        }
    }
}
