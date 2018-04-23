using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createItems : MonoBehaviour {
    public GameObject createObject;     // 生成するオブジェクト

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //マウスカーソル位置にオブジェクト生成
    public void create()
    {
        GameObject item = Instantiate(createObject);
        Vector3 screenPos = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);

        item.transform.position = worldPos;
    }
}
