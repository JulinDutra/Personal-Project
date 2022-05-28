using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Bullet : Enemy
{
    // 
    public override void SpawnEnemy(Transform target)
    {
        base.SpawnEnemy(target);
        BulletTrack();
    }

    void BulletTrack()
    {
        // Leaves a bullet trail on the screen that the bullet will pass through
    }
}
