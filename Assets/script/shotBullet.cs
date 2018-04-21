using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotBullet : MonoBehaviour {
    public KeyCode shotKey;
    public GameObject bulletPrehub;
    public float bulletSpeed;
    private bool isFacingRight;

	// Use this for initialization
	void Start () {
        isFacingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(shotKey))
        {
            // 弾丸の複製
            GameObject bullet = GameObject.Instantiate(bulletPrehub) as GameObject;

            Vector2 force;

            if (isFacingRight)
                force = Vector2.right;
            else
                force = Vector2.left;

            force *= bulletSpeed;
            Debug.Log(force);

            // Rigidbodyに力を加えて発射
            bullet.GetComponent<Rigidbody2D>().AddForce(force);
            // 弾丸の位置を調整
            bullet.transform.position = transform.position;
        }
    }
}
