
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playermovement;
    // Start is called before the first frame update
    //只在玩家发生碰撞之后在调用函数
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "Obstacle")
        {
             playermovement.enabled = false;//停止物体的移动
            //Debug.Log("Obstacle");
        }
    }
}
