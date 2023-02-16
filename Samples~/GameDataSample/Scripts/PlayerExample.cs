using Snowdrama.GameData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExample : MonoBehaviour
{
    public GameDataObject gameDataObject;
    public BoolGameDataKey aliveGameKey;

    public float speed;
    Rigidbody rigid;
    Vector3 force;




    private void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!gameDataObject.gameData.GetFlagBool(aliveGameKey)) { return; } //can't move if dead
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            force.y = speed;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            force.y = -speed;
        }
        else
        {
            force.y = 0;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            force.x = -speed;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            force.x = speed;
        }
        else
        {
            force.x = 0;
        }
        rigid.AddForce(force);
        rigid.velocity *= 0.9f;
    }
}
