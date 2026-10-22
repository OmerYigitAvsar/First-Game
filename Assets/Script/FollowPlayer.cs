using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player; // player'ın konumunu alıyor
    public Vector3 offset; // x, y, z bölüyor

    void Update()
    {
        transform.position = player.position + offset;
    }
}
