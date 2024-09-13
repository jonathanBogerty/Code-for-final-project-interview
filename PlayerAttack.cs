using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform attackTransform;
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private LayerMask attackablelayer;

    private RaycastHit2D[] hits;

    private void Update()
    {
        if (PlayerInput.instance.PlayerControls.Attack.Attack.WasPressedThisFrame())
        {
            //attack
        }
    }

    private void Attack()
    {
        hits = Physics2D.CircleCastAll(attackTransform.position,attackRange,attackTransform.right, 0f, attackablelayer);
    
        for (int i = 0; i < hits.Length; i++)
        {
            PlayerHealth2 health2 = hits[i].collider.gameObject.GetComponent<PlayerHealth2>();

            if (health2 != null)
            {
                //damage
            }
        }
    }
}
