using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContoller : MonoBehaviour {


    [SerializeField]
    private Rigidbody2D a;

    [SerializeField]
    private float b;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 pos = this.transform.position;
            pos.x += 0.1f;
            this.transform.position = new Vector3(pos.x , pos.y , pos.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 pos = this.transform.position;
            pos.x -= 0.1f;
            this.transform.position = new Vector3(pos.x, pos.y, pos.z);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 aaaaa = new Vector2(0, b);
            a.AddForce(aaaaa);
        }
    }
}
