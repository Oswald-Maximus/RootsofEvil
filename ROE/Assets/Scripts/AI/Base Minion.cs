using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMinion : MonoBehaviour {

#region Stats
public int maxHp;
public int hp;
public double morale;
public double atk;
public double build;
public double speed;
public int def;
public bool friendly;
public int range;
#endregion
	
#region Functions
public void Build()
{

}
public void Patrol()
{

}
public void Attack()
{

}
public void Flee()
{

}
public void Die()
{

}
public void MoraleChange(int change)
{
	morale += change;
}
public void rest()
{
	hp++;
}
public void MoraleDecay()
{

}
#endregion
}
